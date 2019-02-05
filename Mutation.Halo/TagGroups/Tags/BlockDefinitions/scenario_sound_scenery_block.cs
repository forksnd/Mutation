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
    
    
    #region scenario_sound_scenery_block
    [TagBlockDefinitionAttribute(cacheFileSize: 80, tagFileSize: 80, alignment: 4, maxBlockCount: 256)]
    public class scenario_sound_scenery_block
    {
        
        [EditorMarkUpAttribute(displayName: "Type")]
        [BlockIndexAttribute(blockName: "scenario_sound_scenery_palette_block")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short type;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.BlockName, displayName: "Name")]
        [BlockIndexAttribute(blockName: "scenario_object_names_block")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short name;
        
        [EditorMarkUpAttribute(displayName: "Object Data")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public scenario_object_datum_struct_block object_data;
        
        [EditorMarkUpAttribute(displayName: "sound_scenery")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public sound_scenery_datum_struct_block sound_scenery;
    }
    #endregion
    
    #region sound_scenery_datum_struct_block
    [TagBlockDefinitionAttribute(cacheFileSize: 28, tagFileSize: 28, alignment: 4, maxBlockCount: 1)]
    public class sound_scenery_datum_struct_block
    {
        
        [EditorMarkUpAttribute(displayName: "Volume Type")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public e_volume_type volume_type;
        
        [EditorMarkUpAttribute(displayName: "Height")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float height;
        
        [EditorMarkUpAttribute(displayName: "Override Distance Bounds")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealBounds override_distance_bounds;
        
        [EditorMarkUpAttribute(displayName: "Override Cone Angle Bounds")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public AngleBounds override_cone_angle_bounds;
        
        [EditorMarkUpAttribute(displayName: "Override Outer Cone Gain", unitsSpecifier: "dB")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float override_outer_cone_gain;
        
        public enum e_volume_type : int
        {
            
            [EditorMarkUpAttribute(displayName: "Sphere")]
            sphere = 0x0,
            
            [EditorMarkUpAttribute(displayName: "Vertical Cylinder")]
            vertical_cylinder = 0x1,
        }
    }
    #endregion
}