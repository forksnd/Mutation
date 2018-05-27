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
    
    
    #region global_collision_bsp_struct_block
    [TagBlockDefinitionAttribute(cacheFileSize: 64, tagFileSize: 64, alignment: 4, maxBlockCount: 1)]
    public class global_collision_bsp_struct_block
    {
        
        // CacheOffset: 0, TagOffset: 0
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "BSP 3D Nodes")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<bsp3d_nodes_block> bsp_3d_nodes;
        
        // CacheOffset: 8, TagOffset: 8
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "Planes")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<planes_block> planes;
        
        // CacheOffset: 16, TagOffset: 16
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "Leaves")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<leaves_block> leaves;
        
        // CacheOffset: 24, TagOffset: 24
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "BSP 2D References")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<bsp2d_references_block> bsp_2d_references;
        
        // CacheOffset: 32, TagOffset: 32
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "BSP 2D Nodes")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<bsp2d_nodes_block> bsp_2d_nodes;
        
        // CacheOffset: 40, TagOffset: 40
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "Surfaces")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<surfaces_block> surfaces;
        
        // CacheOffset: 48, TagOffset: 48
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "Edges")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<edges_block> edges;
        
        // CacheOffset: 56, TagOffset: 56
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "Vertices")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<vertices_block> vertices;
    }
    #endregion
}
