using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutation.Halo.TagGroups.Attributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class BlockFlagsAttribute : Attribute
    {
        /// <summary>
        /// Gets the name of the block definition this flags apply to.
        /// </summary>
        public string BlockName { get; private set; }

        /// <summary>
        /// Specifies the tag block definition this block flags field applies to.
        /// </summary>
        /// <param name="blockName">Name of the tag block the field applies to.</param>
        public BlockFlagsAttribute(string blockName)
        {
            // Initialize fields.
            this.BlockName = blockName;
        }

        /// <summary>
        /// Creates a BlockFlagsAttribute CodeDOM declaration.
        /// </summary>
        /// <param name="blockName">Name of the block definition the flags apply to</param>
        /// <returns>A CodeDOM attribute declaration.</returns>
        public static CodeAttributeDeclaration CreateAttributeDeclaration(string blockName)
        {
            // Create the attribute declaration and initialize it with the values provided.
            CodeAttributeDeclaration attribute = new CodeAttributeDeclaration(typeof(BlockFlagsAttribute).Name, new CodeAttributeArgument[]
            {
                new CodeAttributeArgument(new CodeSnippetExpression(string.Format("blockName: \"{0}\"", blockName)))
            });

            // Return the attribute declaration.
            return attribute;
        }
    }
}
