//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mutation.Halo.TagGroups.Tags
{
    using System;
    using System.IO;
    using Mutation.Halo;
    using Mutation.Halo.TagGroups;
    using Mutation.Halo.TagGroups.Attributes;
    using Mutation.Halo.TagGroups.FieldTypes;
    
    
    #region animation_index_struct_block
    [TagBlockDefinitionAttribute(cacheFileSize: 4, tagFileSize: 4, alignment: 4, maxBlockCount: 1)]
    public class animation_index_struct_block
    {
        
        // CacheOffset: 0, TagOffset: 0
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "graph index")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short graph_index;
        
        // CacheOffset: 2, TagOffset: 2
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "animation")]
        [BlockIndexAttribute(blockName: "animation_pool_block")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short animation;
    }
    #endregion
}
