using LayoutViewer.CodeDOM;
using LayoutViewer.Guerilla.Attributes;
using Mutation.HEK.Common;
using Mutation.HEK.Common.TagFieldDefinitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayoutViewer.Guerilla.Tags.BlockDefinitions
{
    public class global_geometry_block_info_struct_block
    {
        [GuerillaPreProcess("global_geometry_block_info_struct_block")]
        public static void PreProcess(TagBlockDefinition tagBlock)
        {
            // Change padding field to owner datum index.
            tagBlock.TagFields[tagBlock.GetFieldSetIndexClosestToH2Xbox()][6] = new tag_field() { Name = "owner tag*", type = field_type._field_datum_index };
        }
    }
}
