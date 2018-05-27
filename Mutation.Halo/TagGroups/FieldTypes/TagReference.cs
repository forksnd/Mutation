using Mutation.Halo.TagGroups.Attributes;
using Mutation.HEK.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Mutation.Halo.TagGroups.FieldTypes
{
#warning TagReference not fully implemented
    [GuerillaType(field_type._field_tag_reference)]
    [StructLayout(LayoutKind.Sequential, Size = kSizeOf)]
    public class TagReference
    {
        /// <summary>
        /// Size of the TagReference struct.
        /// </summary>
        public const int kSizeOf = 8;

        /// <summary>
        /// Group tag of the referenced tag.
        /// </summary>
        public GroupTag GroupTag { get; set; }

        /// <summary>
        /// Datum index of the referenced tag.
        /// </summary>
        public datum_index Datum { get; set; }

        /// <summary>
        /// Gets the allowed group tag for the tag referenced.
        /// </summary>
        public GroupTag AllowedGroupTag
        {
            get
            {
                // Get the tag reference attribute on this field.
                object[] attributes = this.GetType().GetCustomAttributes(typeof(TagReferenceAttribute), false);
                return (attributes[0] as TagReferenceAttribute).GroupTag;
            }
        }

        /// <summary>
        /// Initializes a new TagReference object to a null reference.
        /// </summary>
        public TagReference()
        {
            this.GroupTag = GroupTag.Null;
            this.Datum = datum_index.NONE;
        }

        /// <summary>
        /// Initializes a new TagReference using the values provided.
        /// </summary>
        /// <param name="groupTag">Group tag of the tag being referenced.</param>
        /// <param name="datum">Datum index of the tag being referenced.</param>
        public TagReference(GroupTag groupTag, datum_index datum)
        {
            this.GroupTag = groupTag;
            this.Datum = datum;
        }
    }
}
