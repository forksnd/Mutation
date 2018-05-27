using Mutation.Halo.TagGroups.Attributes;
using Mutation.HEK.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Reflection;

namespace Mutation.Halo.TagGroups.FieldTypes
{
#warning tag_block not fully implemented
    [GuerillaType(field_type._field_block)]
    [GuerillaType(field_type._field_struct)]
    public class tag_block<T> : IList<T>
    {
        /// <summary>
        /// Gets the size of the tag_block struct.
        /// </summary>
        public const int kSizeOf = 8;

        /// <summary>
        /// Gets or sets the number of child blocks this tag_block currently has.
        /// </summary>
        public int Count { get { return this.blocks.Count; } }

        /// <summary>
        /// Gets the address of the tag_block data.
        /// </summary>
        public uint Address { get; set; }

        /// <summary>
        /// Gets the field type of the underlying tag block definition.
        /// </summary>
        public readonly Type Definition = typeof(T);

        /// <summary>
        /// Gets a list of blocks of type <see cref="definition"/>.
        /// </summary>
        private List<T> blocks = new List<T>();

        /// <summary>
        /// Gets the size of the underlying tag block definition when used in a cache map.
        /// </summary>
        public int CacheFileSize
        {
            get
            {
                // Check if there is a TagBlockDefinitionAttribute on this type.
                TagBlockDefinitionAttribute attribute = (TagBlockDefinitionAttribute)this.Definition.GetCustomAttribute(typeof(TagBlockDefinitionAttribute));
                return attribute.CacheFileSize;
            }
        }

        /// <summary>
        /// Gets the size of the underlying tag block definition when used in a tag file.
        /// </summary>
        public int TagFileSize
        {
            get
            {
                // Check if there is a TagBlockDefinitionAttribute on this type.
                TagBlockDefinitionAttribute attribute = (TagBlockDefinitionAttribute)this.Definition.GetCustomAttribute(typeof(TagBlockDefinitionAttribute));
                return attribute.TagFileSize;
            }
        }

        /// <summary>
        /// Gets the alignment for the underlying tag block definition.
        /// </summary>
        public int Alignment
        {
            get
            {
                // Check if there is a TagBlockDefinitionAttribute on this type.
                TagBlockDefinitionAttribute attribute = (TagBlockDefinitionAttribute)this.Definition.GetCustomAttribute(typeof(TagBlockDefinitionAttribute));
                return attribute.Alignment;
            }
        }

        /// <summary>
        /// Gets the maximum number of blocks this tag_block can have.
        /// </summary>
        public int MaxBlockCount
        {
            get
            {
                // Check if there is a TagBlockDefinitionAttribute on this type.
                TagBlockDefinitionAttribute attribute = (TagBlockDefinitionAttribute)this.Definition.GetCustomAttribute(typeof(TagBlockDefinitionAttribute));
                return attribute.MaxBlockCount;
            }
        }

        /// <summary>
        /// Initializes a new tag_block struct using default values.
        /// </summary>
        //public tag_block()
        //{
        //    this.count = 0;
        //    this.address = 0;
        //    this.blocks = new T[this.count];
        //    this.definition = typeof(T);
        //}

        #region IList Members

        public int IndexOf(T item)
        {
            return this.blocks.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            this.blocks.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            this.blocks.RemoveAt(index);
        }

        public T this[int index]
        {
            get
            {
                // Return the block instance.
                return this.blocks[index];
            }
            set
            {
                // Set the block instance.
                this.blocks[index] = value;
            }
        }

        public void Add(T item)
        {
            this.blocks.Add(item);
        }

        public void Clear()
        {
            // Clear the block array.
            this.blocks.Clear();
        }

        public bool Contains(T item)
        {
            return this.blocks.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            this.blocks.CopyTo(array, arrayIndex);
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(T item)
        {
            // Remove the item from the collection.
            return this.blocks.Remove(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.blocks.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.blocks.GetEnumerator();
        }

        #endregion
    }
}
