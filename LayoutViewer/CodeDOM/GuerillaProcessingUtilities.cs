using Mutation.Halo;
using Mutation.Halo.TagGroups.Attributes;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayoutViewer.CodeDOM
{
    public class GuerillaProcessingUtilities
    {
        /// <summary>
        /// Updates the mark up flags for an EditorMarkUpAttribute declaration.
        /// </summary>
        /// <param name="attribute">Attribute declaration to update</param>
        /// <param name="flags">Flags to add to the attribute declaration</param>
        public static void UpdateEditorMarkUpAttribute(CodeAttributeDeclaration attribute, EditorMarkUpFlags flags)
        {
            // Verify this is actually a EditorMarkUpAttribute and not something else.
            if (attribute.Name != "EditorMarkUpAttribute")
            {
                // Wrong type of attribute.
                throw new InvalidOperationException("Attribute is not a EditorMarkUpAttribute object!");
            }

            // Check if there are new mark up flags.
            if (flags != EditorMarkUpFlags.None)
            {
                // Find the attribute argument for the mark up flags.
                bool found = false;
                for (int i = 0; i < attribute.Arguments.Count; i++)
                {
                    // Check if this is the argument we are looking for.
                    CodeSnippetExpression argument = (CodeSnippetExpression)attribute.Arguments[i].Value;
                    if (argument.Value.Contains("flags:") == true)
                    {
                        // Update the attribute argument.
                        argument.Value += string.Format(" | {0}", EditorMarkUpAttribute.MarkUpFlagsToString(flags));
                        found = true;
                        break;
                    }
                }

                // Check if we found the argument or not.
                if (found == false)
                {
                    // No flags were set for the attribute, add them in.
                    attribute.Arguments.Insert(0, new CodeAttributeArgument(new CodeSnippetExpression(string.Format("flags: {0}", EditorMarkUpAttribute.MarkUpFlagsToString(flags)))));
                }
            }
        }

        /// <summary>
        /// Updates the EngineVersionAttribute for the field if it exists or adds it if it does not.
        /// </summary>
        /// <param name="field">Field the attribute will be placed on</param>
        /// <param name="minimumVersion">New minimum supported engine version</param>
        /// <param name="maximumVersion">New maximum supported engine version</param>
        public static void UpdateEngineVersionAttribute(CodeMemberField field, EngineVersion minimumVersion = EngineVersion.Halo2Xbox, EngineVersion maximumVersion = EngineVersion.Halo2Vista)
        {
            // Loop through all of the custom attributes and search for the old EngineVersionAttribute.
            for (int x = 0; x < field.CustomAttributes.Count; x++)
            {
                // Check if this is the EngineVersionAttribute.
                if (field.CustomAttributes[x].Name == "EngineVersionAttribute")
                {
                    // Remove the old engine version attribute.
                    field.CustomAttributes.RemoveAt(x);
                    break;
                }
            }

            // Add a new engine version attribute to the field.
            field.CustomAttributes.Add(EngineVersionAttribute.CreateAttributeDeclaration(minimumVersion, maximumVersion));
        }
    }
}
