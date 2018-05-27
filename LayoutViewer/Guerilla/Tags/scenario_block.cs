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
    public class scenario_block
    {
        [GuerillaPreProcess("scenario_block")]
        public static void PreProcess(TagBlockDefinition tagBlock)
        {
            // Rename the map_type enum and add in the missing options.
            enum_definition map_type = (enum_definition)tagBlock.TagFields[tagBlock.GetFieldSetIndexClosestToH2Xbox()][2];
            map_type.Name = "map type";

            // Add in missing options.
            map_type.options = new string[] { "Singleplayer", "Multiplayer", "Main Menu", "Shared", "Singleplayer Shared" };
            map_type.option_count = map_type.options.Length;
        }

        [GuerillaPostProcess("scenario_block")]
        public static void PostProcess(MutationTagLayoutCreator layoutCreator)
        {
            //// Move the map type enum declaration up to the global scope.
            //CodeTypeDeclaration enumDef = (CodeTypeDeclaration)layoutCreator.CodeCreator.CodeNamespace.Types[0].Members[2];
            //layoutCreator.CodeCreator.CodeNamespace.Types[0].Members.RemoveAt(2);
            //layoutCreator.CodeCreator.CodeNamespace.Types.Insert(1, enumDef);

            // Change the display name of the map type field because it pisses me off.
            layoutCreator.CodeCreator.CodeNamespace.Types[0].Members[3].CustomAttributes.RemoveAt(0);

            // Add in a new editor markup attribute with the correct display name.
            layoutCreator.CodeCreator.CodeNamespace.Types[0].Members[3].CustomAttributes.Insert(0,
                EditorMarkUpAttribute.CreateAttributeDeclaration(displayName: "\"Type\""));
        }
    }
}
