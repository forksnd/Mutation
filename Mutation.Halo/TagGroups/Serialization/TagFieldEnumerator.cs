using Mutation.Halo.TagGroups.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mutation.Halo.TagGroups.Serialization
{
    public class TagFieldIterator
    {
        /// <summary>
        /// Minimum engine version for fields
        /// </summary>
        public EngineVersion MinimumVersion { get; private set; }

        /// <summary>
        /// Maximum engine version for fields
        /// </summary>
        public EngineVersion MaximumVersion { get; private set; }

        /// <summary>
        /// Editor flags the fields must contain
        /// </summary>
        public EditorMarkUpFlags ContainsEditorFlags { get; private set; }

        /// <summary>
        /// Editor flags the fields must not contain
        /// </summary>
        public EditorMarkUpFlags ExcludesEditorFlags { get; private set; }

        /// <summary>
        /// Field flags the fields must contain
        /// </summary>
        public TagFieldFlags ContainsFieldFlags { get; private set; }

        /// <summary>
        /// Field flags the fields must not contain
        /// </summary>
        public TagFieldFlags ExcludesFieldFlags { get; private set; }

        /// <summary>
        /// Current position in the list of fields
        /// </summary>
        public int Position { get; private set; }

        private FieldInfo[] fields;

        /// <summary>
        /// Initializes a new TagFieldIterator using the specified enumeration filters.
        /// </summary>
        /// <param name="fields">Array of fields to iterator over</param>
        /// <param name="minimumVersion">Minimum engine version of each field</param>
        /// <param name="maximumVersion">Maximum engine version of each field</param>
        /// <param name="containsEditorFlags">Editor flags each field must contain</param>
        /// <param name="excludesEditorFlags">Editor flags each field must not contain</param>
        /// <param name="containsFieldFlags">Field flags each field must contain</param>
        /// <param name="excludesFieldFlags">Field flags each field must not contain</param>
        public TagFieldIterator(FieldInfo[] fields, EngineVersion minimumVersion, EngineVersion maximumVersion, EditorMarkUpFlags containsEditorFlags, EditorMarkUpFlags excludesEditorFlags,
            TagFieldFlags containsFieldFlags, TagFieldFlags excludesFieldFlags)
        {
            // Initialize fields.
            this.fields = fields;
            this.MinimumVersion = minimumVersion;
            this.MaximumVersion = maximumVersion;
            this.ContainsEditorFlags = containsEditorFlags;
            this.ExcludesEditorFlags = excludesEditorFlags;
            this.ContainsFieldFlags = containsFieldFlags;
            this.ExcludesFieldFlags = excludesFieldFlags;

            this.Position = 0;
        }

        /// <summary>
        /// Gets a boolean indicating if there are more fields to iterate over or not.
        /// </summary>
        /// <returns>True if there are more fields to iterate over, false otherwise.</returns>
        public bool HasNext()
        {
            // Return true if there are more fields to iterate over.
            return this.Position < this.fields.Length;
        }

        /// <summary>
        /// Resets the iterator position back to the beginning of the field collection.
        /// </summary>
        public void Reset()
        {
            // Reset the iterator position back to the first field.
            this.Position = 0;
        }

        /// <summary>
        /// Increments the current position of the iterator.
        /// </summary>
        /// <param name="iter"></param>
        /// <returns></returns>
        public static TagFieldIterator operator ++(TagFieldIterator iter)
        {
            // Check to make sure we haven't reached the end of the fields.
            if (iter.HasNext() == false)
            {
                // Reached the end of the iterator.
                throw new InvalidOperationException("Tried to move iterator past the end of the collection!");
            }

            // Increment position.
            iter.Position++;

            // Return iterator.
            return iter;
        }

        /// <summary>
        /// Gets the field at the current position.
        /// </summary>
        public FieldInfo CurrentField
        {
            get
            {
                return this.fields[this.Position];
            }
        }
    }

    public class TagFieldEnumerator
    {
        protected object tagDefinition;

        public FieldInfo[] tagFields;

        /// <summary>
        /// Initializes a new TagFieldEnumerator to enumerate fields in the specified object.
        /// </summary>
        /// <param name="tagData">Object containing the fields to enumerate.</param>
        public TagFieldEnumerator(object tagData)
        {
            // Initialize fields.
            this.tagDefinition = tagData;

            // Get a list of fields from the tag object that are public and do not have the NonTagField flag.
            this.tagFields = this.tagDefinition.GetType().GetFields(BindingFlags.Public | BindingFlags.Instance).Where(
                fieldInfo =>
                {
                    // Check if the field has a TagFieldFlags attribute.
                    TagFieldFlagsAttribute attribute = (TagFieldFlagsAttribute)fieldInfo.GetCustomAttribute(typeof(TagFieldFlagsAttribute));
                    if (attribute != null && (attribute.Flags & TagFieldFlags.NonTagField) != 0)
                    {
                        // Tag field contains the TagFieldFlags attribute and has hte NonTagField flag set.
                        return false;
                    }

                    // Field does not contain the NonTagField flag.
                    return true;
                }).ToArray();
        }

        /// <summary>
        /// Create a new TagFieldIterator that will iterator over fields matching the specified search criteria.
        /// </summary>
        /// <param name="minimumVersion">Minimum engine version of each field</param>
        /// <param name="maximumVersion">Maximum engine version of each field</param>
        /// <param name="containsEditorFlags">Editor flags each field must contain</param>
        /// <param name="excludesEditorFlags">Editor flags each field must not contain</param>
        /// <param name="containsFieldFlags">Field flags each field must contain</param>
        /// <param name="excludesFieldFlags">Field flags each field must not contain</param>
        /// <returns>A TagFieldIterator</returns>
        public TagFieldIterator CreateIterator(EngineVersion minimumVersion = EngineVersion.Minimum, EngineVersion maximumVersion = EngineVersion.Maximum, 
            EditorMarkUpFlags containsEditorFlags = EditorMarkUpFlags.None, EditorMarkUpFlags excludesEditorFlags = EditorMarkUpFlags.None, 
            TagFieldFlags containsFieldFlags = TagFieldFlags.None, TagFieldFlags excludesFieldFlags = TagFieldFlags.None)
        {
            // Create the initial list of fields.
            FieldInfo[] fields = this.tagFields;

            // Check if there is a min or max version filter.
            if (minimumVersion != EngineVersion.Minimum || maximumVersion != EngineVersion.Maximum)
            {
                // Get a list of fields that match the specified engine versions.
                fields = fields.Where(
                    field =>
                    {
                        // Check for the engine version attribute.
                        EngineVersionAttribute version = (EngineVersionAttribute)field.GetCustomAttribute(typeof(EngineVersionAttribute));
                        if (version == null || minimumVersion > version.MinimumVersion || maximumVersion < version.MaximumVersion)
                        {
                            // Field does not contain an EngineVersionAttribute or does not meet the filter criteria.
                            return false;
                        }

                        // Field matches filter criteria.
                        return true;
                    }).ToArray();
            }

            // Check if the editor contains flags are set.
            if (containsEditorFlags != EditorMarkUpFlags.None)
            {
                // Get a list of fields that match the specified flag filters.
                fields = fields.Where(
                    field =>
                    {
                        // Check for an EditorMarkUp attribute.
                        EditorMarkUpAttribute markup = (EditorMarkUpAttribute)field.GetCustomAttribute(typeof(EditorMarkUpAttribute));
                        if (markup == null || (markup.Flags & containsEditorFlags) != containsEditorFlags)
                        {
                            // Field does not contain an EditorMarkUp attribute or does meet the filter criteria.
                            return false;
                        }

                        // Field matches filter criteria.
                        return true;
                    }).ToArray();
            }

            // Check if the editor excludes flags are set.
            if (excludesEditorFlags != EditorMarkUpFlags.None)
            {
                // Get a list of fields that match the specified flag filters.
                fields = fields.Where(
                    field =>
                    {
                        // Check for an EditorMarkUp attribute.
                        EditorMarkUpAttribute markup = (EditorMarkUpAttribute)field.GetCustomAttribute(typeof(EditorMarkUpAttribute));
                        if (markup != null && (markup.Flags & excludesEditorFlags) != EditorMarkUpFlags.None)
                        {
                            // Field does not contain an EditorMarkUp attribute or does meet the filter criteria.
                            return false;
                        }

                        // Field matches filter criteria.
                        return true;
                    }).ToArray();
            }

            // Check if the field flags contains are set.
            if (containsFieldFlags != TagFieldFlags.None)
            {
                // Get a list of fields that match the specified flag filters.
                fields = fields.Where(
                    field =>
                    {
                        // Check for a TagFieldFlags attribute.
                        TagFieldFlagsAttribute attribute = (TagFieldFlagsAttribute)field.GetCustomAttribute(typeof(TagFieldFlagsAttribute));
                        if (attribute == null || (attribute.Flags & containsFieldFlags) != containsFieldFlags)
                        {
                            // Field does not contain a TagFieldFlags attribute or does not meet the filter criteria.
                            return false;
                        }

                        // Field matches filter criteria.
                        return true;
                    }).ToArray();
            }

            // Check if the field flags excludes are set.
            if (excludesFieldFlags != TagFieldFlags.None)
            {
                // Get a list of fields that match the specified flag filters.
                fields = fields.Where(
                    field =>
                    {
                        // Check for a TagFieldFlags attribute.
                        TagFieldFlagsAttribute attribute = (TagFieldFlagsAttribute)field.GetCustomAttribute(typeof(TagFieldFlagsAttribute));
                        if (attribute != null && (attribute.Flags & excludesFieldFlags) != TagFieldFlags.None)
                        {
                            // Field does not contain a TagFieldFlags attribute or does not meet the filter criteria.
                            return false;
                        }

                        // Field matches filter criteria.
                        return true;
                    }).ToArray();
            }

            // Sort the fields so that they are in the order they are declared in.
            Array.Sort(fields, (x, y) => x.MetadataToken - y.MetadataToken);

            // Create a new TagFieldIterator using the field indices we found.
            return new TagFieldIterator(fields, minimumVersion, maximumVersion, containsEditorFlags, excludesEditorFlags, containsFieldFlags, excludesFieldFlags);
        }
    }
}
