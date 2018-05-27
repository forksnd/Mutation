using LayoutViewer.CodeDOM;
using LayoutViewer.Guerilla.Attributes;
using Mutation.HEK.Common;
using Mutation.HEK.Common.TagFieldDefinitions;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayoutViewer.Guerilla.Tags.BlockDefinitions
{
    public class scenario_structure_bsp_reference_block
    {
        [GuerillaPreProcess("scenario_structure_bsp_reference_block")]
        public static void PreProcess(TagBlockDefinition tagBlock)
        {
            // Fix the bsp info fields.
            tagBlock.TagFields[tagBlock.GetFieldSetIndexClosestToH2Xbox()].RemoveAt(0);
            tagBlock.TagFields[tagBlock.GetFieldSetIndexClosestToH2Xbox()].Insert(0, 
                new tag_field { definition_address = 0, group_tag = 0, Name = "Structure BSP Offset*", type = field_type._field_long_integer });
            tagBlock.TagFields[tagBlock.GetFieldSetIndexClosestToH2Xbox()].Insert(1,
                new tag_field { definition_address = 0, group_tag = 0, Name = "Structure BSP Size*", type = field_type._field_long_integer });
            tagBlock.TagFields[tagBlock.GetFieldSetIndexClosestToH2Xbox()].Insert(2,
                new tag_field { definition_address = 0, group_tag = 0, Name = "Structure BSP Base Address*", type = field_type._field_long_integer });
            tagBlock.TagFields[tagBlock.GetFieldSetIndexClosestToH2Xbox()].Insert(3,
                new tag_field { definition_address = 4, group_tag = 0, Name = "", type = field_type._field_pad });
        }

        [GuerillaPostProcess("scenario_structure_bsp_reference_block")]
        public static void PostProcess(MutationTagLayoutCreator layoutCreator)
        {
            // Make the bsp base address field a uint.
            ((CodeMemberField)layoutCreator.CodeCreator.CodeNamespace.Types[0].Members[2]).Type.BaseType = "System.UInt32";
        }
    }
}
