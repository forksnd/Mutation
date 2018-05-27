using Mutation.Halo.TagGroups.FieldTypes;
using Mutation.Halo.TagGroups.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Reflection;
using Mutation.Halo.TagGroups.Attributes;

namespace Mutation.Halo.Cache
{
    public class TagInstance
    {
        /// <summary>
        /// Unique datum for this tag.
        /// </summary>
        public datum_index Datum { get; private set; }

        /// <summary>
        /// Group tag
        /// </summary>
        public GroupTag GroupTag { get; private set; }

        /// <summary>
        /// Full file path of the tag.
        /// </summary>
        public string FilePath { get; private set; }

        /// <summary>
        /// Gets or sets the tag instance object.
        /// </summary>
        public object Instance { get; set; }

        public TagInstance(datum_index datum, GroupTag groupTag, string filePath)
        {
            // Initialize fields.
            this.Datum = datum;
            this.GroupTag = groupTag;
            this.FilePath = filePath;
        }

        /// <summary>
        /// Gets the tag instance as the specified type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T GetInstance<T>()
        {
            return (T)this.Instance;
        }
    }

    public class TagCache
    {
        // Internal tag cache.
        private List<TagInstance> tagCache;

        // Next datum index to issue for tags added to the cache.
        private datum_index nextDatum = datum_index._k_starting_datum_index;

        /// <summary>
        /// Array of group tags for this engine version.
        /// </summary>
        public GroupTag[] GroupTags { get; private set; }

        /// <summary>
        /// Array of tag group types for this engine verison.
        /// </summary>
        public Type[] TagGroupTypes { get; private set; }

        /// <summary>
        /// Engine version the tags in the cache belong to.
        /// </summary>
        public EngineVersion Version { get; private set; }

        /// <summary>
        /// Gets the owner object of this TagIndexCache.
        /// </summary>
        public ISerializationContext Owner { get; private set; }

        /// <summary>
        /// Gets the number of tags in the cache.
        /// </summary>
        public int Count { get { return this.tagCache.Count; } }

        /// <summary>
        /// Gets or sets the TagInstance at the specified index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public TagInstance this[int index]
        {
            get
            {
                // Get tag instance.
                return this.tagCache[index];
            }

            set
            {
                // Set tag instance.
                this.tagCache[index] = value;
            }
        }

        /// <summary>
        /// Gets or sets the TagInstance at the specified datum index.
        /// </summary>
        /// <param name="datum"></param>
        /// <returns></returns>
        public TagInstance this[datum_index datum]
        {
            get
            {
                return this.tagCache[datum.index];
            }

            set
            {
                this.tagCache[datum.index] = value;
            }
        }

        /// <summary>
        /// Initializes a new TagCache using the info provided.
        /// </summary>
        /// <param name="version">Engine version of the tag cache.</param>
        /// <param name="owner">Owner of this tag cache.</param>
        public TagCache(EngineVersion version, ISerializationContext owner)
        {
            // Initialize fields.
            this.Version = version;
            this.Owner = owner;
            this.tagCache = new List<TagInstance>();

            // Make sure an owner was provided.
            if (owner == null)
            {
                throw new NullReferenceException("Owner cannot be null");
            }

            // Initialize lists that will be used to build the group tag and tag type arrays.
            List<GroupTag> groupTags = new List<GroupTag>();
            List<Type> tagTypes = new List<Type>();

            // Get a list of all classes with a TagGrouDefinitionAttribute.
            Type[] tagLayoutTypes = Assembly.GetExecutingAssembly().GetTypes().Where(@type => @type.GetCustomAttribute(typeof(TagGroupDefinitionAttribute)) != null).ToArray();

            // Loop through all of the tag group layout ojects build the tag info arrays.
            for (int i = 0; i < tagLayoutTypes.Length; i++)
            {
                // Get the TagGroupDefinition attribute for the current object type.
                TagGroupDefinitionAttribute attribute = (TagGroupDefinitionAttribute)tagLayoutTypes[i].GetCustomAttribute(typeof(TagGroupDefinitionAttribute));

                // Make sure the tag group supports this engine version.
                if (attribute.MinimumVersion > EngineVersion.Halo2Xbox || attribute.MaximumVersion < EngineVersion.Halo2Xbox)
                    continue;

                // Add the info for the current tag group layout to the lists.
                groupTags.Add(attribute.GroupTag);
                tagTypes.Add(tagLayoutTypes[i].GetType());
            }

            // Initialize the tag type arrays using the lists we created.
            this.GroupTags = groupTags.ToArray();
            this.TagGroupTypes = tagTypes.ToArray();
        }

        /// <summary>
        /// Adds a new TagInstance to the tag cache using the information provided. 
        /// Intended for use with an existing tag stream.
        /// </summary>
        /// <param name="datum">Datum index of the tag to add</param>
        /// <param name="groupTag">Group tag of the tag to add</param>
        /// <param name="filePath">Full file path of the tag to add</param>
        public void Add(datum_index datum, GroupTag groupTag, string filePath)
        {
            // If we are adding a tag from a tag stream then the datums should be sequential, so the datum being
            // added should be equal to the size of the current tag cache.
            if (datum.index != this.tagCache.Count)
            {
                // We are trying to add a datum that is out of order.
                throw new InvalidOperationException("Datum index is out of order");
            }

            // Create a new tag instance using the info provided and add it to the cache.
            TagInstance newTag = new TagInstance(datum, groupTag, filePath);
            this.tagCache.Add(newTag);

            // Update the next datum field.
            this.nextDatum = datum;
            this.nextDatum++;
        }

        /// <summary>
        /// Adds a new TagInstance to the tag cache using the information provided.
        /// Intended for use with a new tag stream.
        /// </summary>
        /// <param name="groupTag">Group tag of the tag to add</param>
        /// <param name="filePath">Full file path of the tag to add</param>
        /// <returns>The datum_index of the newly added tag.</returns>
        public datum_index Add(GroupTag groupTag, string filePath)
        {
            // Create a new tag instance using the info provided and add it to the cache.
            TagInstance newTag = new TagInstance(this.nextDatum, groupTag, filePath);
            this.tagCache.Add(newTag);

            // Update the next datum field.
            this.nextDatum++;

            // Return the new tag's datum_index.
            return newTag.Datum;
        }

        /// <summary>
        /// Removes all tag instances from the tag cache.
        /// </summary>
        public void Clear()
        {
            // Clear all the tag instances.
            this.tagCache.Clear();

            // Reset the next datum index.
            this.nextDatum = datum_index._k_starting_datum_index;
        }

        /// <summary>
        /// Checks if a TagInstance with the specified datum index exists in the tag cache.
        /// </summary>
        /// <param name="datum">Datum index to search for</param>
        /// <returns>True if a tag with the specified datum_index exists in the tag cache, false otherwise.</returns>
        public bool Contains(datum_index datum)
        {
            // Check if the specified datum is within bounds of the tag cache.
            if (datum.index > this.tagCache.Count)
            {
                // Datum is out of bounds and cannot exist in the tag cache.
                return false;
            }

            // Check if the tag instance at the specified index has the same datum index.
            return this.tagCache[datum.index].Datum == datum;
        }

        /// <summary>
        /// Checks if a TagInstance with the specified file path exists in the tag cache.
        /// </summary>
        /// <param name="fileName">Full file path to search for</param>
        /// <returns>True if a tag with the specified file path exists in the tag cache, false otherwise.</returns>
        public bool Contains(string fileName)
        {
            // Check if a tag with the specified file name exists in the tag cache.
            return this.tagCache.Exists(tag => tag.FilePath == fileName);
        }

        /// <summary>
        /// Gets the tag instance for the tag with the datum index specified.
        /// </summary>
        /// <typeparam name="T">Tag group object type</typeparam>
        /// <param name="datum">Datum index of the tag to get</param>
        /// <returns>The tag instance for specified tag</returns>
        public T GetTagInstance<T>(datum_index datum)
        {
            return (T)GetTagInstance(datum, typeof(T));
        }

        /// <summary>
        /// Gets the tag instance for the tag with the datum index specified.
        /// </summary>
        /// <param name="datum">Datum index of the tag to get</param>
        /// <param name="type">Tag group object type</param>
        /// <returns>The tag instance for specified tag</returns>
        public object GetTagInstance(datum_index datum, Type type)
        {
            // Check to make sure the datum index exists in the tag cache.
            if (datum.index > this.tagCache.Count || this.tagCache[datum.index].Datum != datum)
            {
                // Specified datum index does not exist in the tag cache.
                throw new IndexOutOfRangeException("Datum index does not exist in the tag cache");
            }

            // Check if the tag instance has already been instantiated.
            if (this.tagCache[datum.index].Instance == null)
            {
                // Create a tag deserializer to deserialize the tag.
                TagDataDeserializer deserializer = new TagDataDeserializer(this.Version);

                // Setup the reader for this tag.
                BinaryReader reader = this.Owner.BeginDeserialization(SerializationFlags.FileType_TagStream | SerializationFlags.Operation_ReadInPlace, this.tagCache[datum.index]);

                // Deserialize the tag.
                this.tagCache[datum.index].Instance = deserializer.DeserializeTag(this.Owner, reader, SerializationFlags.FileType_TagStream | SerializationFlags.Operation_ReadInPlace, type);

                // End deserialization.
                this.Owner.EndDeserialization();
            }

            // Return the tag instance.
            return this.tagCache[datum.index].Instance;
        }
    }
}
