using LayoutViewer.Guerilla.Attributes;
using Mutation.HEK.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayoutViewer.Guerilla.Tags
{
    public class sound_permutation_chunk_block
    {
        [GuerillaPreProcess("sound_permutation_chunk_block")]
        public static void PreProcess(TagBlockDefinition tagBlock)
        {
            // Make the raw data offset field read only.
            tagBlock.TagFields[tagBlock.GetFieldSetIndexClosestToH2Xbox()][0].Name = "file offset*";

            // Set the field name for the raw data size field.
            tagBlock.TagFields[tagBlock.GetFieldSetIndexClosestToH2Xbox()][1].Name = "file size*";
        }
    }
}
