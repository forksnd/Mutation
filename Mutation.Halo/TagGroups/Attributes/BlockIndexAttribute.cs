using Mutation.Halo.TagGroups.FieldTypes;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutation.Halo.TagGroups.Attributes
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class BlockIndexAttribute : Attribute
    {
        /// <summary>
        /// Gets or sets the name of the tag block definition this field indexes.
        /// </summary>
        public string TagBlockName { get; set; }

        /// <summary>
        /// Delegate function for getting a tag block definition instance for a block index field.
        /// </summary>
        /// <param name="tagIndex">Global tag index.</param>
        /// <returns>True if a block definition instance is successfully retreived, false otherwise.</returns>
        public delegate bool GetBlockProc(datum_index tagIndex);
        /// <summary>
        /// Gets or sets the <see cref="GetBlockProc"/> function for the block index field.
        /// </summary>
        public string GetBlockFunction { get; set; }

        /// <summary>
        /// Delegate function for checking if the selected tag block definition instance is valid.
        /// </summary>
        /// <param name="tagIndex">Global tag index.</param>
        /// <returns>True if the selected block instance is a valid source block for this block index field.</returns>
        public delegate bool IsValidSourceBlockProc(datum_index tagIndex);
        /// <summary>
        /// Gets or sets the <see cref="IsValidSourceBlockProc"/> function for the block index field.
        /// </summary>
        public string IsValidSourceBlockFunction { get; set; }

        /// <summary>
        /// Initializes a new BlockIndexAttribute using the values provided.
        /// </summary>
        /// <param name="blockName">Name of the tag block definition this field indexes</param>
        /// <param name="getBlockProc">Function that will handle getting the tag block instance this field points to</param>
        /// <param name="validSourceBlockProc">Function that determines if a tag block instance is valid.</param>
        public BlockIndexAttribute(string blockName = "", string getBlockProc = "", string validSourceBlockProc = "")
        {
            // Initialize fields.
            this.TagBlockName = blockName;
            this.GetBlockFunction = getBlockProc;
            this.IsValidSourceBlockFunction = validSourceBlockProc;
        }

        /// <summary>
        /// Creates a new BlockIndexAttribute CodeDOM declaration.
        /// </summary>
        /// <param name="blockName">Name of the tag block definition this field indexes</param>
        /// <param name="getBlockProc">Get block procedure</param>
        /// <param name="validSourceBlockProc">Is valid source block procedure</param>
        /// <returns>A CodeDOM attribute declaration</returns>
        public static CodeAttributeDeclaration CreateAttributeDeclaration(string blockName = "", GetBlockProc getBlockProc = null, IsValidSourceBlockProc validSourceBlockProc = null)
        {
            // Create the attribute declaration and initialize it with no parameters.
            CodeAttributeDeclaration attribute = new CodeAttributeDeclaration(typeof(BlockIndexAttribute).Name);

            // Check if the block name field was specified.
            if (blockName != string.Empty)
            {
                // Add the block name parameter.
                attribute.Arguments.Add(new CodeAttributeArgument(new CodeSnippetExpression(string.Format("blockName: \"{0}\"", blockName))));
            }

            // Check if the get block proc field was specified.
            if (getBlockProc != null)
            {
                // Add the get block proc paramter.
                attribute.Arguments.Add(new CodeAttributeArgument(new CodeSnippetExpression(string.Format("getBlockProc: \"{0}\"", getBlockProc.Method.Name))));
            }

            // Check if the valid source block proc is valid.
            if (validSourceBlockProc != null)
            {
                // Add the valid source block proc parameter.
                attribute.Arguments.Add(new CodeAttributeArgument(new CodeSnippetExpression(string.Format("validSourceBlockProc: \"{0}\"", validSourceBlockProc.Method.Name))));
            }

            // Return the attribute declaration.
            return attribute;
        }
    }
}
