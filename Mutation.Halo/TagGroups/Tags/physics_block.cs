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
    
    
    [TagGroupDefinitionAttribute(cacheFileSize: 116, tagFileSize: 128, version: 4, groupTag: "phys", parentGroupTag: "", name: "physics", minimumVersion: EngineVersion.Halo2Xbox, maximumVersion: EngineVersion.Halo2Vista)]
    public class physics_block
    {
        
        [EditorMarkUpAttribute(displayName: "radius", tooltipText: "positive uses old inferior physics, negative uses new improved physics")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float radius;
        
        [EditorMarkUpAttribute(displayName: "moment scale")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float moment_scale;
        
        [EditorMarkUpAttribute(displayName: "mass")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float mass;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "center of mass")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealPoint3d center_of_mass;
        
        [EditorMarkUpAttribute(displayName: "density")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float density;
        
        [EditorMarkUpAttribute(displayName: "gravity scale")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float gravity_scale;
        
        [EditorMarkUpAttribute(displayName: "ground friction")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float ground_friction;
        
        [EditorMarkUpAttribute(displayName: "ground depth")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float ground_depth;
        
        [EditorMarkUpAttribute(displayName: "ground damp fraction")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float ground_damp_fraction;
        
        [EditorMarkUpAttribute(displayName: "ground normal k1")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float ground_normal_k1;
        
        [EditorMarkUpAttribute(displayName: "ground normal k0")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float ground_normal_k0;
        
        [PaddingAttribute(PaddingType.Padding, 4)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [EditorMarkUpAttribute(displayName: "water friction")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float water_friction;
        
        [EditorMarkUpAttribute(displayName: "water depth")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float water_depth;
        
        [EditorMarkUpAttribute(displayName: "water density")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float water_density;
        
        [PaddingAttribute(PaddingType.Padding, 4)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding1;
        
        [EditorMarkUpAttribute(displayName: "air friction")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float air_friction;
        
        [PaddingAttribute(PaddingType.Padding, 4)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding2;
        
        [EditorMarkUpAttribute(displayName: "xx moment")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float xx_moment;
        
        [EditorMarkUpAttribute(displayName: "yy moment")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float yy_moment;
        
        [EditorMarkUpAttribute(displayName: "zz moment")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float zz_moment;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "inertial matrix and inverse")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<inertial_matrix_block> inertial_matrix_and_inverse;
        
        [EditorMarkUpAttribute(displayName: "powered mass points")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<powered_mass_point_block> powered_mass_points;
        
        [EditorMarkUpAttribute(displayName: "mass points")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<mass_point_block> mass_points;
    }
    
    #region inertial_matrix_block
    [TagBlockDefinitionAttribute(cacheFileSize: 36, tagFileSize: 36, alignment: 4, maxBlockCount: 2)]
    public class inertial_matrix_block
    {
        
        [EditorMarkUpAttribute(displayName: "yy+zz    -xy     -zx")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealVector3d yy_zz_____xy______zx;
        
        [EditorMarkUpAttribute(displayName: " -xy    zz+xx    -yz")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealVector3d @__xy____zz_xx_____yz;
        
        [EditorMarkUpAttribute(displayName: " -zx     -yz    xx+yy")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealVector3d @__zx______yz____xx_yy;
    }
    #endregion
    
    #region powered_mass_point_block
    [TagBlockDefinitionAttribute(cacheFileSize: 128, tagFileSize: 128, alignment: 4, maxBlockCount: 32)]
    public class powered_mass_point_block
    {
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.BlockName, displayName: "name")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public String32 name;
        
        [EditorMarkUpAttribute(displayName: "flags")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public b_flags flags;
        
        [EditorMarkUpAttribute(displayName: "antigrav strength")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float antigrav_strength;
        
        [EditorMarkUpAttribute(displayName: "antigrav offset")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float antigrav_offset;
        
        [EditorMarkUpAttribute(displayName: "antigrav height")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float antigrav_height;
        
        [EditorMarkUpAttribute(displayName: "antigrav damp fraction")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float antigrav_damp_fraction;
        
        [EditorMarkUpAttribute(displayName: "antigrav normal k1")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float antigrav_normal_k1;
        
        [EditorMarkUpAttribute(displayName: "antigrav normal k0")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float antigrav_normal_k0;
        
        [EditorMarkUpAttribute(displayName: "damage source region name")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public string_id damage_source_region_name;
        
        [PaddingAttribute(PaddingType.Padding, 64)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [FlagsAttribute()]
        public enum b_flags : uint
        {
            
            [EditorMarkUpAttribute(displayName: "ground friction")]
            ground_friction = 0x1,
            
            [EditorMarkUpAttribute(displayName: "water friction")]
            water_friction = 0x2,
            
            [EditorMarkUpAttribute(displayName: "air friction")]
            air_friction = 0x4,
            
            [EditorMarkUpAttribute(displayName: "water lift")]
            water_lift = 0x8,
            
            [EditorMarkUpAttribute(displayName: "air lift")]
            air_lift = 0x10,
            
            [EditorMarkUpAttribute(displayName: "thrust")]
            thrust = 0x20,
            
            [EditorMarkUpAttribute(displayName: "antigrav")]
            antigrav = 0x40,
            
            [EditorMarkUpAttribute(displayName: "gets damage from region")]
            gets_damage_from_region = 0x80,
        }
    }
    #endregion
    
    #region mass_point_block
    [TagBlockDefinitionAttribute(cacheFileSize: 128, tagFileSize: 128, alignment: 4, maxBlockCount: 32)]
    public class mass_point_block
    {
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly | EditorMarkUpFlags.BlockName, displayName: "name")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public String32 name;
        
        [EditorMarkUpAttribute(displayName: "powered mass point")]
        [BlockIndexAttribute(blockName: "powered_mass_point_block")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short powered_mass_point;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "model node")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short model_node;
        
        [EditorMarkUpAttribute(displayName: "flags")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public b_flags flags;
        
        [EditorMarkUpAttribute(displayName: "relative mass")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float relative_mass;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "mass")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float mass;
        
        [EditorMarkUpAttribute(displayName: "relative density")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float relative_density;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "density")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float density;
        
        [EditorMarkUpAttribute(displayName: "position")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealPoint3d position;
        
        [EditorMarkUpAttribute(displayName: "forward")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealVector3d forward;
        
        [EditorMarkUpAttribute(displayName: "up")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealVector3d up;
        
        [EditorMarkUpAttribute(displayName: "friction type")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public e_friction_type friction_type;
        
        [PaddingAttribute(PaddingType.Padding, 2)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [EditorMarkUpAttribute(displayName: "friction parallel scale")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float friction_parallel_scale;
        
        [EditorMarkUpAttribute(displayName: "friction perpendicular scale")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float friction_perpendicular_scale;
        
        [EditorMarkUpAttribute(displayName: "radius")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float radius;
        
        [PaddingAttribute(PaddingType.Padding, 20)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding1;
        
        [FlagsAttribute()]
        public enum b_flags : uint
        {
            
            [EditorMarkUpAttribute(displayName: "metallic")]
            metallic = 0x1,
        }
        
        public enum e_friction_type : short
        {
            
            [EditorMarkUpAttribute(displayName: "point")]
            point = 0x0,
            
            [EditorMarkUpAttribute(displayName: "forward")]
            forward = 0x1,
            
            [EditorMarkUpAttribute(displayName: "left")]
            left = 0x2,
            
            [EditorMarkUpAttribute(displayName: "up")]
            up = 0x3,
        }
    }
    #endregion
}
