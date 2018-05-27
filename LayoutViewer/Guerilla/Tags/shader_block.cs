using LayoutViewer.CodeDOM;
using LayoutViewer.Guerilla.Attributes;
using Mutation.Halo;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayoutViewer.Guerilla.Tags
{
    public class shader_block
    {
        [GuerillaPostProcess("shader_block")]
        public static void PostProcess(MutationTagLayoutCreator layoutCreator)
        {
            // Make the two depth bias fields vista only.
            GuerillaProcessingUtilities.UpdateEngineVersionAttribute((CodeMemberField)layoutCreator.CodeCreator.CodeNamespace.Types[0].Members[22], EngineVersion.Halo2Vista, EngineVersion.Halo2Vista);
            GuerillaProcessingUtilities.UpdateEngineVersionAttribute((CodeMemberField)layoutCreator.CodeCreator.CodeNamespace.Types[0].Members[23], EngineVersion.Halo2Vista, EngineVersion.Halo2Vista);
        }
    }
}
