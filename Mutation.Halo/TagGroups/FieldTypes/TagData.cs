using Mutation.Halo.TagGroups.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Mutation.Halo.TagGroups.FieldTypes
{
#warning TagData not fully implemented
    [GuerillaType(HEK.Common.field_type._field_data)]
    [StructLayout(LayoutKind.Sequential, Size = kSizeOf)]
    public class TagData
    {
        /// <summary>
        /// Size of a TagData struct.
        /// </summary>
        public const int kSizeOf = 8;

        /// <summary>
        /// Gets or sets the size of the tag data.
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// Gets or sets the address of the tag data.
        /// </summary>
        public uint Address { get; set; }

        /// <summary>
        /// Gets or sets the tag data blob.
        /// </summary>
        public byte[] Data { get; set; }

        /// <summary>
        /// Gets the maximum size of the tag data.
        /// </summary>
        public int MaxSize
        {
            get
            {
                // Get the TagDataAttribute attached to this field.
                object[] attributes = this.GetType().GetCustomAttributes(typeof(TagDataAttribute), false);
                return (attributes[0] as TagDataAttribute).MaxSize;
            }
        }

        /// <summary>
        /// Gets the alignment interval for the tag data blob.
        /// </summary>
        public int Alignment
        {
            get
            {
                // Get the TagDataAttribute attached to this field.
                object[] attributes = this.GetType().GetCustomAttributes(typeof(TagDataAttribute), false);
                return (attributes[0] as TagDataAttribute).Alignment;
            }
        }

        /// <summary>
        /// Gets the string represntation of the maximum allowed size for the tag data blob.
        /// </summary>
        public string MaxSizeString
        {
            get
            {
                // Get the TagDataAttribute attached to this field.
                object[] attributes = this.GetType().GetCustomAttributes(typeof(TagDataAttribute), false);
                return (attributes[0] as TagDataAttribute).MaxSizeString;
            }
        }
    }
}
