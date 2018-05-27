using LayoutViewer.CodeDOM;
using LayoutViewer.Guerilla.Attributes;
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
    public class bitmap_block
    {
        [GuerillaPreProcess("bitmap_block")]
        public static void PreProcess(TagBlockDefinition tagBlock)
        {
            // Fix the sprite size enum name.
            tagBlock.TagFields[tagBlock.TagFieldSetLatestIndex][12].Name = "Sprite Size";
        }

        [GuerillaPostProcess("bitmap_block")]
        public static void PostProcess(MutationTagLayoutCreator layoutCreator)
        {
            // Modify the engine version attributes for all of the WDP fields to be vista only.
            for (int i = 37; i < layoutCreator.CodeCreator.CodeNamespace.Types[0].Members.Count; i++)
            {
                // Make sure this is a field and not a type definition.
                if (layoutCreator.CodeCreator.CodeNamespace.Types[0].Members[i].GetType() == typeof(CodeMemberField))
                {
                    // Loop through all of the custom attributes and search for the old EngineVersionAttribute.
                    for (int x = 0; x < layoutCreator.CodeCreator.CodeNamespace.Types[0].Members[i].CustomAttributes.Count; x++)
                    {
                        // Check if this is the EngineVersionAttribute.
                        if (layoutCreator.CodeCreator.CodeNamespace.Types[0].Members[i].CustomAttributes[x].Name == "EngineVersionAttribute")
                        {
                            // Remove the old engine version attribute.
                            layoutCreator.CodeCreator.CodeNamespace.Types[0].Members[i].CustomAttributes.RemoveAt(x);
                            break;
                        }
                    }

                    // Add a new engine version attribute to the field.
                    layoutCreator.CodeCreator.CodeNamespace.Types[0].Members[i].CustomAttributes.Add( 
                        EngineVersionAttribute.CreateAttributeDeclaration(Mutation.Halo.EngineVersion.Halo2Vista));
                }
            }
        }
    }

    public class bitmap_data_block
    {
        [GuerillaPreProcess("bitmap_data_block")]
        public static void PreProcess(TagBlockDefinition tagBlock)
        {
            // Get the correct field set that most closely matches h2x.
            List<tag_field> fields = tagBlock.TagFields[tagBlock.TagFieldSetLatestIndex];

            // Remove the last 10 padding fields.
            for (int i = 0; i < 11; i++)
            {
                // Remove padding fields.
                tagBlock.TagFields[tagBlock.TagFieldSetLatestIndex].RemoveAt(tagBlock.TagFields[tagBlock.TagFieldSetLatestIndex].Count - 1);
            }

            // Add in the texture data offset fields.
            tagBlock.TagFields[tagBlock.TagFieldSetLatestIndex].Add(new tag_field() { type = field_type._field_long_integer, Name = "LOD 1 Texture Data Offset*" });
            tagBlock.TagFields[tagBlock.TagFieldSetLatestIndex].Add(new tag_field() { type = field_type._field_long_integer, Name = "LOD 2 Texture Data Offset*" });
            tagBlock.TagFields[tagBlock.TagFieldSetLatestIndex].Add(new tag_field() { type = field_type._field_long_integer, Name = "LOD 3 Texture Data Offset*" });
            tagBlock.TagFields[tagBlock.TagFieldSetLatestIndex].Add(new tag_field() { type = field_type._field_long_integer, Name = "LOD 4 Texture Data Offset*" });
            tagBlock.TagFields[tagBlock.TagFieldSetLatestIndex].Add(new tag_field() { type = field_type._field_long_integer, Name = "LOD 5 Texture Data Offset*" });
            tagBlock.TagFields[tagBlock.TagFieldSetLatestIndex].Add(new tag_field() { type = field_type._field_long_integer, Name = "LOD 6 Texture Data Offset*" });

            // Add in the texture data size fields.
            tagBlock.TagFields[tagBlock.TagFieldSetLatestIndex].Add(new tag_field() { type = field_type._field_long_integer, Name = "LOD 1 Texture Data Size*" });
            tagBlock.TagFields[tagBlock.TagFieldSetLatestIndex].Add(new tag_field() { type = field_type._field_long_integer, Name = "LOD 2 Texture Data Size*" });
            tagBlock.TagFields[tagBlock.TagFieldSetLatestIndex].Add(new tag_field() { type = field_type._field_long_integer, Name = "LOD 3 Texture Data Size*" });
            tagBlock.TagFields[tagBlock.TagFieldSetLatestIndex].Add(new tag_field() { type = field_type._field_long_integer, Name = "LOD 4 Texture Data Size*" });
            tagBlock.TagFields[tagBlock.TagFieldSetLatestIndex].Add(new tag_field() { type = field_type._field_long_integer, Name = "LOD 5 Texture Data Size*" });
            tagBlock.TagFields[tagBlock.TagFieldSetLatestIndex].Add(new tag_field() { type = field_type._field_long_integer, Name = "LOD 6 Texture Data Size*" });

            // Add in owner field.
            tagBlock.TagFields[tagBlock.TagFieldSetLatestIndex].Add(new tag_field() { type = field_type._field_datum_index, Name = "Owner*" });

            // Add in padding fields.
            tagBlock.TagFields[tagBlock.TagFieldSetLatestIndex].Add(new tag_field() { type = field_type._field_skip, definition_address = 4 });
            tagBlock.TagFields[tagBlock.TagFieldSetLatestIndex].Add(new tag_field() { type = field_type._field_skip, definition_address = 4 });
            tagBlock.TagFields[tagBlock.TagFieldSetLatestIndex].Add(new tag_field() { type = field_type._field_skip, definition_address = 4 });
            tagBlock.TagFields[tagBlock.TagFieldSetLatestIndex].Add(new tag_field() { type = field_type._field_skip, definition_address = 20 });
            tagBlock.TagFields[tagBlock.TagFieldSetLatestIndex].Add(new tag_field() { type = field_type._field_skip, definition_address = 4 });

            // Add the terminator field back.
            tagBlock.TagFields[tagBlock.TagFieldSetLatestIndex].Add(new tag_field() { type = field_type._field_terminator });
        }
    }
}
