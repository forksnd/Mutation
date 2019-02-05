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
    public class model_animation_graph_block
    {
        [GuerillaPreProcess("model_animation_graph_block")]
        public static void PreProcess(TagBlockDefinition tagBlock)
        {
            // Add more padding.
            tagBlock.TagFields[tagBlock.GetFieldSetIndexClosestToH2Xbox()].Insert(3, new tag_field() { definition_address = 16, type = field_type._field_pad });
        }

        [GuerillaPostProcess("model_animation_graph_block")]
        public static void PostProcess(MutationTagLayoutCreator layoutCreator)
        {
            // Make the import results tag_block a tag only field.
            layoutCreator.CodeCreator.CodeNamespace.Types[0].Members[5].CustomAttributes.Insert(0,
                TagFieldFlagsAttribute.CreateAttributeDeclaration(TagFieldFlags.TagFileOnly));

            // Create a tag block for the raw data chunks.
            CreateRawDataTagBlock(layoutCreator);

            // Post process the animation pool tag block.
            PostProcess_AnimationPools(layoutCreator);
        }

        private static void CreateRawDataTagBlock(MutationTagLayoutCreator layoutCreator)
        {
            // Setup the tag block field list.
            List<tag_field> RawDataBlockFields = new List<tag_field>();
            RawDataBlockFields.Add(new tag_field() { Name = "owner*", type = field_type._field_datum_index });
            RawDataBlockFields.Add(new tag_field() { Name = "file size*", type = field_type._field_long_integer });
            RawDataBlockFields.Add(new tag_field() { Name = "file offset*", type = field_type._field_long_integer });
            RawDataBlockFields.Add(new tag_field() { Name = "unknown", type = field_type._field_long_integer });
            RawDataBlockFields.Add(new tag_field() { Name = "unknown", type = field_type._field_long_integer });
            RawDataBlockFields.Add(new tag_field() { type = field_type._field_terminator });

            // Create a new code scope for the tag block.
            MutationCodeScope blockScope = layoutCreator.CodeScope.CreateCodeScopeForType("animation_graph_raw_data_block", -1, MutationCodeScopeType.Struct);

            // Compute the definition size.
            int definitionSize = TagLayoutValidator.ComputeMutationDefinitionSize(null, RawDataBlockFields);

            // Create the TagBlockDefinition attribute.
            CodeAttributeDeclaration[] attributes =
            {
                TagBlockDefinitionAttribute.CreateAttributeDeclaration(definitionSize, definitionSize, 4, -1)
            };

            // Create the code creator for the tag block.
            MutationCodeCreator childBlockCodeCreator = layoutCreator.CodeCreator.CreateTagBlockClass(blockScope.Namespace, attributes);

            // Process the tag block fields.
            layoutCreator.ProcessFields(RawDataBlockFields, null, childBlockCodeCreator, blockScope, layoutCreator.CodeScope);

            // Create the field name and markup data.
            string displayName, units, tooltip, color;
            EditorMarkUpFlags markupFlags;
            string fieldName = layoutCreator.CodeScope.CreateCodeSafeFieldName(field_type._field_block, "animation blocks*", out displayName, out units, out tooltip, out color, out markupFlags);

            // Add a tag block field for the raw data block.
            layoutCreator.CodeCreator.ChildCodeCreators[0].AddTagBlockField(fieldName, blockScope.Namespace, new CodeAttributeDeclarationCollection(new CodeAttributeDeclaration[]
            {
                EngineVersionAttribute.CreateAttributeDeclaration(Mutation.Halo.EngineVersion.Halo2Xbox, Mutation.Halo.EngineVersion.Halo2Xbox),
                EditorMarkUpAttribute.CreateAttributeDeclaration(markupFlags, displayName, units, tooltip, color)
            }));

            // Move the animation blocks field up one position in the layout.
            CodeTypeMember field = layoutCreator.CodeCreator.ChildCodeCreators[0].CodeClass.Members[7];
            layoutCreator.CodeCreator.ChildCodeCreators[0].CodeClass.Members.RemoveAt(7);
            layoutCreator.CodeCreator.ChildCodeCreators[0].CodeClass.Members.Insert(6, field);
        }

        public static void PostProcess_AnimationPools(MutationTagLayoutCreator layoutCreator)
        {
            string displayName, units, tooltip, color;
            EditorMarkUpFlags markupFlags;

            // Add in the max random start field for vista.
            string fieldName = layoutCreator.CodeScope.ParentScope.Types["animation_pool_block"].CreateCodeSafeFieldName(field_type._field_short_integer, "max random start frame index", out displayName, out units, out tooltip, out color, out markupFlags);

            // Add the field to the block definition.
            layoutCreator.CodeCreator.ChildCodeCreators[7].AddField(field_type._field_short_integer, fieldName, new CodeAttributeDeclarationCollection(new CodeAttributeDeclaration[]
            {
                EngineVersionAttribute.CreateAttributeDeclaration(Mutation.Halo.EngineVersion.Halo2Vista, Mutation.Halo.EngineVersion.Halo2Vista),
                EditorMarkUpAttribute.CreateAttributeDeclaration(markupFlags, displayName, units, tooltip, color)
            }));

            // Move the field to the correct position within the layout.
            CodeTypeMember field = layoutCreator.CodeCreator.ChildCodeCreators[7].CodeClass.Members[34];
            layoutCreator.CodeCreator.ChildCodeCreators[7].CodeClass.Members.RemoveAt(34);
            layoutCreator.CodeCreator.ChildCodeCreators[7].CodeClass.Members.Insert(26, field);

            // Mark the parent graph fields as xbox only.
            for (int i = 0; i < 4; i++)
            {
                // Update the engine version attribute to be xbox only.
                GuerillaProcessingUtilities.UpdateEngineVersionAttribute((CodeMemberField)layoutCreator.CodeCreator.ChildCodeCreators[7].CodeClass.Members[21 + i], EngineVersion.Halo2Xbox, EngineVersion.Halo2Xbox);

                // Add a block index attribute to the parent animation data index field.
                if (i == 1)
                {
                    // Add the block index attribute.
                    layoutCreator.CodeCreator.ChildCodeCreators[7].CodeClass.Members[21 + i].CustomAttributes.Insert(0, BlockIndexAttribute.CreateAttributeDeclaration("animation_graph_raw_data_block"));
                }
            }
        }
    }
}
