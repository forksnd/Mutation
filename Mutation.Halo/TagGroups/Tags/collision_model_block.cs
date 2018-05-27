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
    
    
    [TagGroupDefinitionAttribute(cacheFileSize: 52, tagFileSize: 76, version: 10, groupTag: "coll", parentGroupTag: "", name: "collision_model", minimumVersion: EngineVersion.Halo2Xbox, maximumVersion: EngineVersion.Halo2Vista)]
    public class collision_model_block
    {
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "import info")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<global_tag_import_info_block> import_info;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "errors")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<global_error_report_categories_block> errors;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "flags")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public b_flags flags;
        
        [PaddingAttribute(PaddingType.Useless, 124)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "materials")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<collision_model_material_block> materials;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "regions")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<collision_model_region_block> regions;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "pathfinding spheres")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<collision_model_pathfinding_sphere_block> pathfinding_spheres;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "nodes")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<collision_model_node_block> nodes;
        
        [FlagsAttribute()]
        public enum b_flags : uint
        {
            
            [EditorMarkUpAttribute(displayName: "contains open edges")]
            contains_open_edges = 0x1,
        }
    }
    
    #region collision_model_material_block
    [TagBlockDefinitionAttribute(cacheFileSize: 4, tagFileSize: 4, alignment: 4, maxBlockCount: 32)]
    public class collision_model_material_block
    {
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly | EditorMarkUpFlags.BlockName, displayName: "name")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public string_id name;
    }
    #endregion
    
    #region collision_model_region_block
    [TagBlockDefinitionAttribute(cacheFileSize: 12, tagFileSize: 12, alignment: 4, maxBlockCount: 16)]
    public class collision_model_region_block
    {
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly | EditorMarkUpFlags.BlockName, displayName: "name")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public string_id name;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "permutations")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<collision_model_permutation_block> permutations;
    }
    #endregion
    
    #region collision_model_permutation_block
    [TagBlockDefinitionAttribute(cacheFileSize: 20, tagFileSize: 20, alignment: 4, maxBlockCount: 32)]
    public class collision_model_permutation_block
    {
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly | EditorMarkUpFlags.BlockName, displayName: "name")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public string_id name;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "bsps")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<collision_model_bsp_block> bsps;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "bsp_physics")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<collision_bsp_physics_block> bsp_physics;
    }
    #endregion
    
    #region collision_model_bsp_block
    [TagBlockDefinitionAttribute(cacheFileSize: 68, tagFileSize: 68, alignment: 4, maxBlockCount: 64)]
    public class collision_model_bsp_block
    {
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "node index")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short node_index;
        
        [PaddingAttribute(PaddingType.Padding, 2)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [PaddingAttribute(PaddingType.Useless, 16)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding1;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "bsp")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public global_collision_bsp_struct_block bsp;
    }
    #endregion
    
    #region collision_model_pathfinding_sphere_block
    [TagBlockDefinitionAttribute(cacheFileSize: 20, tagFileSize: 20, alignment: 4, maxBlockCount: 32)]
    public class collision_model_pathfinding_sphere_block
    {
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "node")]
        [BlockIndexAttribute(blockName: "collision_model_node_block")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short node;
        
        [EditorMarkUpAttribute(displayName: "flags")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public b_flags flags;
        
        [PaddingAttribute(PaddingType.Useless, 12)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "center")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealPoint3d center;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "radius")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float radius;
        
        [FlagsAttribute()]
        public enum b_flags : short
        {
            
            [EditorMarkUpAttribute(displayName: "remains when open")]
            remains_when_open = 0x1,
            
            [EditorMarkUpAttribute(displayName: "vehicle only")]
            vehicle_only = 0x2,
            
            [EditorMarkUpAttribute(displayName: "with sectors")]
            with_sectors = 0x4,
        }
    }
    #endregion
    
    #region collision_model_node_block
    [TagBlockDefinitionAttribute(cacheFileSize: 12, tagFileSize: 12, alignment: 4, maxBlockCount: 255)]
    public class collision_model_node_block
    {
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly | EditorMarkUpFlags.BlockName, displayName: "name")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public string_id name;
        
        [PaddingAttribute(PaddingType.Padding, 2)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "parent node")]
        [BlockIndexAttribute(blockName: "collision_model_node_block")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short parent_node;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "next sibling node")]
        [BlockIndexAttribute(blockName: "collision_model_node_block")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short next_sibling_node;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "first child node")]
        [BlockIndexAttribute(blockName: "collision_model_node_block")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short first_child_node;
    }
    #endregion
}
