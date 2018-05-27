using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutation.Halo.TagGroups.Attributes
{
    /// <summary>
    /// Custom attribute for versioning fields in tag definitions.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class EngineVersionAttribute : Attribute
    {
        /// <summary>
        /// Minimum supported engine version this field is for.
        /// </summary>
        public EngineVersion MinimumVersion { get; private set; }

        /// <summary>
        /// Maximum supported engine version this field is for.
        /// </summary>
        public EngineVersion MaximumVersion { get; private set; }

        /// <summary>
        /// Initializes a new EngineVersionAttribute using the values provided.
        /// </summary>
        /// <param name="min">Minimum supported engine version</param>
        /// <param name="max">Maximum supported engine version</param>
        public EngineVersionAttribute(EngineVersion min, EngineVersion max = EngineVersion.Maximum)
        {
            // Initialize fields.
            this.MinimumVersion = min;
            this.MaximumVersion = max;
        }

        /// <summary>
        /// Creates a EngineVersionAttribute CodeDOM declaration.
        /// </summary>
        /// <param name="min">Minimum supported engine version for the field.</param>
        /// <param name="max">Maximum supported engine version for the field.</param>
        /// <returns>A CodeDOM attribute declaration.</returns>
        public static CodeAttributeDeclaration CreateAttributeDeclaration(EngineVersion min, EngineVersion max = EngineVersion.Maximum)
        {
            // Create the attribute declaration and initialize it with the values provided.
            CodeAttributeDeclaration attribute = new CodeAttributeDeclaration(typeof(EngineVersionAttribute).Name, new CodeAttributeArgument[]
            {
                new CodeAttributeArgument(new CodeSnippetExpression(string.Format("min: {0}", string.Format("EngineVersion.{0}", Enum.GetName(typeof(EngineVersion), min))))),
                new CodeAttributeArgument(new CodeSnippetExpression(string.Format("max: {0}", string.Format("EngineVersion.{0}", Enum.GetName(typeof(EngineVersion), max)))))
            });

            // Return the attribute declaration.
            return attribute;
        }
    }
}
