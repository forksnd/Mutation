using LayoutViewer.CodeDOM;
using LayoutViewer.Guerilla.Attributes;
using Mutation.Halo;
using Mutation.Halo.TagGroups.Attributes;
using Mutation.HEK.Common;
using Mutation.HEK.Common.TagFieldDefinitions;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayoutViewer.Guerilla.Tags
{
    public class scenario_structure_bsp_block
    {
        [GuerillaPreProcess("scenario_structure_bsp_block")]
        public static void PreProcess(TagBlockDefinition tagBlock)
        {
            // Add the bsp header fields in.
            tagBlock.TagFields[tagBlock.GetFieldSetIndexClosestToH2Xbox()].Insert(0,
                new tag_field { type = field_type._field_long_integer, Name = "BSP Size*" });
            tagBlock.TagFields[tagBlock.GetFieldSetIndexClosestToH2Xbox()].Insert(1,
                new tag_field { type = field_type._field_long_integer, Name = "BSP Address*" });
            tagBlock.TagFields[tagBlock.GetFieldSetIndexClosestToH2Xbox()].Insert(2,
                new tag_field { type = field_type._field_long_integer, Name = "Lightmap Address*" });
            tagBlock.TagFields[tagBlock.GetFieldSetIndexClosestToH2Xbox()].Insert(3,
                new tag_field { type = field_type._field_tag, Name = "Signature" });
        }

        [GuerillaPostProcess("scenario_structure_bsp_block")]
        public static void PostProcess(MutationTagLayoutCreator layoutCreator)
        {
            // Make the bsp header xbox cache map only fields.
            for (int i = 0; i < 4; i++)
            {
                // Make the field cache map only.
                layoutCreator.CodeCreator.CodeNamespace.Types[0].Members[i].CustomAttributes.Insert(0, 
                    TagFieldFlagsAttribute.CreateAttributeDeclaration(TagFieldFlags.CacheMapOnly));

                // Make the field xbox only.
                GuerillaProcessingUtilities.UpdateEngineVersionAttribute((CodeMemberField)layoutCreator.CodeCreator.CodeNamespace.Types[0].Members[i], EngineVersion.Halo2Xbox, EngineVersion.Halo2Xbox);
            }


            // Make the import info tag block a strip on compile field.
            layoutCreator.CodeCreator.CodeNamespace.Types[0].Members[4].CustomAttributes.Insert(0,
                TagFieldFlagsAttribute.CreateAttributeDeclaration(TagFieldFlags.StripOnCompile));
        }
    }
}
