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
    
    
    #region decorator_placement_definition_block
    [TagBlockDefinitionAttribute(cacheFileSize: 48, tagFileSize: 64, alignment: 4, maxBlockCount: 1)]
    public class decorator_placement_definition_block
    {
        
        [EditorMarkUpAttribute(displayName: "Grid Origin")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealPoint3d grid_origin;
        
        [EditorMarkUpAttribute(displayName: "Cell Count per Dimension")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public int cell_count_per_dimension;
        
        [EditorMarkUpAttribute(displayName: "Cache Blocks")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<decorator_cache_block_block> cache_blocks;
        
        [EditorMarkUpAttribute(displayName: "Groups")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<decorator_group_block> groups;
        
        [EditorMarkUpAttribute(displayName: "Cells")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<decorator_cell_collection_block> cells;
        
        [EditorMarkUpAttribute(displayName: "Decals")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<decorator_projected_decal_block> decals;
    }
    #endregion
}
