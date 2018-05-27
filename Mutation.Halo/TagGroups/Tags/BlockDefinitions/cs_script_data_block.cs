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
    
    
    #region cs_script_data_block
    [TagBlockDefinitionAttribute(cacheFileSize: 128, tagFileSize: 132, alignment: 4, maxBlockCount: 1)]
    public class cs_script_data_block
    {
        
        [EditorMarkUpAttribute(displayName: "point sets")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<cs_point_set_block> point_sets;
        
        [PaddingAttribute(PaddingType.Padding, 120)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
    }
    #endregion
    
    #region cs_point_set_block
    [TagBlockDefinitionAttribute(cacheFileSize: 48, tagFileSize: 48, alignment: 4, maxBlockCount: 200)]
    public class cs_point_set_block
    {
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.BlockName, displayName: "name")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public String32 name;
        
        [EditorMarkUpAttribute(displayName: "points")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<cs_point_block> points;
        
        [EditorMarkUpAttribute(displayName: "bsp index")]
        [BlockIndexAttribute(blockName: "scenario_structure_bsp_reference_block")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short bsp_index;
        
        [EditorMarkUpAttribute(displayName: "manual reference frame")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short manual_reference_frame;
        
        [EditorMarkUpAttribute(displayName: "flags")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public b_flags flags;
        
        [FlagsAttribute()]
        public enum b_flags : uint
        {
            
            [EditorMarkUpAttribute(displayName: "manual reference frame")]
            manual_reference_frame = 0x1,
            
            [EditorMarkUpAttribute(displayName: "turret deployment")]
            turret_deployment = 0x2,
        }
    }
    #endregion
    
    #region cs_point_block
    [TagBlockDefinitionAttribute(cacheFileSize: 60, tagFileSize: 60, alignment: 4, maxBlockCount: 20)]
    public class cs_point_block
    {
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.BlockName, displayName: "name")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public String32 name;
        
        [EditorMarkUpAttribute(displayName: "position")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealPoint3d position;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "reference frame")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short reference_frame;
        
        [PaddingAttribute(PaddingType.Padding, 2)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [EditorMarkUpAttribute(displayName: "surface index")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public int surface_index;
        
        [EditorMarkUpAttribute(displayName: "facing direction")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealEulerAngle2d facing_direction;
    }
    #endregion
}
