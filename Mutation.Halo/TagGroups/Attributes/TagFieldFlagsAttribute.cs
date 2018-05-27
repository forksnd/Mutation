using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutation.Halo.TagGroups.Attributes
{
    /// <summary>
    /// Flags that indicate where/when a tag field should be used.
    /// </summary>
    public enum TagFieldFlags
    {
        None = 0,
        /// <summary>
        /// Field is not part of the tag, it is for processing use only.
        /// </summary>
        NonTagField = 1,
        /// <summary>
        /// Field is only present in tag files.
        /// </summary>
        TagFileOnly = 2,
        /// <summary>
        /// Field is only present in cache maps.
        /// </summary>
        CacheMapOnly = 4,
        /// <summary>
        /// Field will be set to 0 during compilation.
        /// </summary>
        StripOnCompile = 8
    }

    /// <summary>
    /// Custom attribute for indicating when a tag field should be used.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class TagFieldFlagsAttribute : Attribute
    {
        /// <summary>
        /// Gets the flags for this field.
        /// </summary>
        public TagFieldFlags Flags { get; private set; }

        /// <summary>
        /// Initializes the TagFieldFlagsAttribute using the flags value provided.
        /// </summary>
        /// <param name="flags"></param>
        public TagFieldFlagsAttribute(TagFieldFlags flags)
        {
            // Initialize fields.
            this.Flags = flags;
        }

        /// <summary>
        /// Creates a TagFlagFieldsAttribute CodeDOM declaration.
        /// </summary>
        /// <param name="flags">Tag field flags for the field.</param>
        /// <returns>A CodeDOM attribute delcaration.</returns>
        public static CodeAttributeDeclaration CreateAttributeDeclaration(TagFieldFlags flags)
        {
            // Create the attribute declaration and initialize it with the flags value provided.
            CodeAttributeDeclaration attribute = new CodeAttributeDeclaration(typeof(TagFieldFlagsAttribute).Name, new CodeAttributeArgument[]
            {
                new CodeAttributeArgument(new CodeSnippetExpression(TagFieldFlagsToString(flags)))
            });

            // Return the attribute declaration.
            return attribute;
        }

        /// <summary>
        /// Converts a TagFieldFlags values into a string representation of the values that are set.
        /// </summary>
        /// <param name="flags">Flags to convert to string.</param>
        /// <returns>String representation of the flag values.</returns>
        private static string TagFieldFlagsToString(TagFieldFlags flags)
        {
            string flagsStr = string.Empty;

            // Get a list of the enum values and names.
            string[] enumNames = Enum.GetNames(typeof(TagFieldFlags));
            Array enumValues = Enum.GetValues(typeof(TagFieldFlags));

            // Loop through all of the options in the markup flags enum and check for each one.
            for (int i = 1; i < enumNames.Length; i++)
            {
                // Check if the flags specified contain the current flag value.
                if ((flags & (TagFieldFlags)enumValues.GetValue(i)) != TagFieldFlags.None)
                {
                    // Add the flag value to the string.
                    if (flagsStr == string.Empty)
                        flagsStr += string.Format("TagFieldFlags.{0}", enumNames[i]);
                    else
                        flagsStr += string.Format(" | TagFieldFlags.{0}", enumNames[i]);
                }
            }

            // Return the string representation of the flag values.
            return flagsStr;
        }
    }
}
