using LayoutViewer.Guerilla.Attributes;
using Mutation.HEK.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayoutViewer.Guerilla.Tags.BlockDefinitions
{
    public class shader_postprocess_bitmap_new_block
    {
        [GuerillaPreProcess("shader_postprocess_bitmap_new_block")]
        public static void PreProcess(TagBlockDefinition tagBlock)
        {
            // Change the bitmap_group field to a datum_index.
            tagBlock.TagFields[tagBlock.GetFieldSetIndexClosestToH2Xbox()][0].type = field_type._field_datum_index;
        }
    }
}
