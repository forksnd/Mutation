using Mutation.Halo.TagGroups.FieldTypes;
using Mutation.HEK.Common;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutation.Halo.TagGroups.Attributes
{
    public class TagGroupDefinitionAttribute : Attribute
    {
        /// <summary>
        /// Gets the size of the tag group definition when used in a cache map.
        /// </summary>
        public int CacheFileSize { get; private set; }

        /// <summary>
        /// Gets the size of the tag group definition when used in a tag file.
        /// </summary>
        public int TagFileSize { get; private set; }

        /// <summary>
        /// Gets the version of the tag group definition.
        /// </summary>
        public int Version { get; private set; }

        /// <summary>
        /// Gets the tag group's group tag.
        /// </summary>
        public GroupTag GroupTag { get; private set; }

        /// <summary>
        /// Parent type group tag.
        /// </summary>
        public GroupTag ParentGroupTag { get; private set; }

        /// <summary>
        /// Name of the tag group definition.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the minimum engine version that supports this tag type.
        /// </summary>
        public EngineVersion MinimumVersion { get; private set; }

        /// <summary>
        /// Gets the maximum engine version that supports this tag type.
        /// </summary>
        public EngineVersion MaximumVersion { get; private set; }

        /// <summary>
        /// Initializes a new TagGroupDefinitionAttribute using the values provided.
        /// </summary>
        /// <param name="cacheFileSize">Size of the tag group definition in a cache map.</param>
        /// <param name="tagFileSize">Size of the tag group definition in a tag file.</param>
        /// <param name="version">Definition version.</param>
        /// <param name="groupTag">Group tag for the tag group.</param>
        /// <param name="parentGroupTag">Parent group tag for the tag group.</param>
        /// <param name="name">Name of the tag group.</param>
        /// <param name="minimumVersion">Minimum engine version that supports this tag group.</param>
        /// <param name="maximumVersion">Maximum engine version that supports this tag group.</param>
        public TagGroupDefinitionAttribute(int cacheFileSize, int tagFileSize, int version, string groupTag, string parentGroupTag, string name, EngineVersion minimumVersion, EngineVersion maximumVersion)
        {
            // Initialize fields.
            this.CacheFileSize = cacheFileSize;
            this.TagFileSize = tagFileSize;
            this.Version = version;
            this.GroupTag = groupTag;
            this.ParentGroupTag = parentGroupTag;
            this.Name = name;
        }

        /// <summary>
        /// Creates a TagGroupDefinitionAttribute CodeDOM declaration.
        /// </summary>
        /// <param name="tagGroup">Guerill tag group definition.</param>
        /// <param name="cacheFileSize">Alternative calculated size of the definition in a cache map, overrides fieldSet.size</param>
        /// <param name="tagFileSize">Alternative calculated size of the definition in a tag file, overrides fieldSet.size</param>
        /// <returns>A CodeDOM attribute declaration.</returns>
        public static CodeAttributeDeclaration CreateAttributeDeclaration(tag_group tagGroup, int cacheFileSize = 0, int tagFileSize = 0)
        {
            // Get the latest field set from the guerilla definition.
            tag_field_set fieldSet = tagGroup.Definition.TagFieldSets[tagGroup.Definition.GetFieldSetIndexClosestToH2Xbox()];

            // Setup a TagGroupDefinitionAttribute attribute using the definition info.
            CodeAttributeDeclaration attribute = new CodeAttributeDeclaration(typeof(TagGroupDefinitionAttribute).Name, new CodeAttributeArgument[]
            {
                new CodeAttributeArgument(new CodeSnippetExpression(string.Format("cacheFileSize: {0}", (cacheFileSize != 0 ? cacheFileSize : fieldSet.size)))),
                new CodeAttributeArgument(new CodeSnippetExpression(string.Format("tagFileSize: {0}", (tagFileSize != 0 ? tagFileSize : fieldSet.size)))),
                new CodeAttributeArgument(new CodeSnippetExpression(string.Format("version: {0}", tagGroup.version))),
                new CodeAttributeArgument(new CodeSnippetExpression(string.Format("groupTag: \"{0}\"", tagGroup.GroupTag))),
                new CodeAttributeArgument(new CodeSnippetExpression(string.Format("parentGroupTag: \"{0}\"", tagGroup.ParentGroupTag))),
                new CodeAttributeArgument(new CodeSnippetExpression(string.Format("name: \"{0}\"", tagGroup.Name))),
                new CodeAttributeArgument(new CodeSnippetExpression(string.Format("minimumVersion: {0}", string.Format("EngineVersion.{0}", Enum.GetName(typeof(EngineVersion), EngineVersion.Halo2Xbox))))),
                new CodeAttributeArgument(new CodeSnippetExpression(string.Format("maximumVersion: {0}", string.Format("EngineVersion.{0}", Enum.GetName(typeof(EngineVersion), EngineVersion.Halo2Vista)))))
            });

            // Return the new attribute declaration.
            return attribute;
        }
    }
}
