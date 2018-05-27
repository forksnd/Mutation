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
    
    
    [TagGroupDefinitionAttribute(cacheFileSize: 176, tagFileSize: 188, version: 1, groupTag: "weat", parentGroupTag: "", name: "weather_system", minimumVersion: EngineVersion.Halo2Xbox, maximumVersion: EngineVersion.Halo2Vista)]
    public class weather_system_block
    {
        
        [EditorMarkUpAttribute(displayName: "particle system")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<global_particle_system_lite_block> particle_system;
        
        [EditorMarkUpAttribute(displayName: "background plates")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<global_weather_background_plate_block> background_plates;
        
        [EditorMarkUpAttribute(displayName: "wind model")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public global_wind_model_struct_block wind_model;
        
        [EditorMarkUpAttribute(displayName: "fade radius")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float fade_radius;
    }
    
    #region global_particle_system_lite_block
    [TagBlockDefinitionAttribute(cacheFileSize: 140, tagFileSize: 140, alignment: 4, maxBlockCount: 1)]
    public class global_particle_system_lite_block
    {
        
        [EditorMarkUpAttribute(displayName: "sprites")]
        [TagReferenceAttribute("bitm")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference sprites;
        
        [EditorMarkUpAttribute(displayName: "view box width")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float view_box_width;
        
        [EditorMarkUpAttribute(displayName: "view box height")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float view_box_height;
        
        [EditorMarkUpAttribute(displayName: "view box depth")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float view_box_depth;
        
        [EditorMarkUpAttribute(displayName: "exclusion radius")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float exclusion_radius;
        
        [EditorMarkUpAttribute(displayName: "max velocity")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float max_velocity;
        
        [EditorMarkUpAttribute(displayName: "min mass")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float min_mass;
        
        [EditorMarkUpAttribute(displayName: "max mass")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float max_mass;
        
        [EditorMarkUpAttribute(displayName: "min size")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float min_size;
        
        [EditorMarkUpAttribute(displayName: "max size")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float max_size;
        
        [EditorMarkUpAttribute(displayName: "maximum number of particles")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public int maximum_number_of_particles;
        
        [EditorMarkUpAttribute(displayName: "initial velocity")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealVector3d initial_velocity;
        
        [EditorMarkUpAttribute(displayName: "bitmap animation speed")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float bitmap_animation_speed;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "geometry block info")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public global_geometry_block_info_struct_block geometry_block_info;
        
        [EditorMarkUpAttribute(displayName: "particle system data")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<particle_system_lite_data_block> particle_system_data;
        
        [EditorMarkUpAttribute(displayName: "type")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public e_type type;
        
        [PaddingAttribute(PaddingType.Padding, 2)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [EditorMarkUpAttribute(displayName: "mininum opacity")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float mininum_opacity;
        
        [EditorMarkUpAttribute(displayName: "maxinum opacity")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float maxinum_opacity;
        
        [EditorMarkUpAttribute(displayName: "rain streak scale")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float rain_streak_scale;
        
        [EditorMarkUpAttribute(displayName: "rain line width")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float rain_line_width;
        
        [PaddingAttribute(PaddingType.Padding, 4)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding1;
        
        [PaddingAttribute(PaddingType.Padding, 4)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding2;
        
        [PaddingAttribute(PaddingType.Padding, 4)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding3;
        
        public enum e_type : short
        {
            
            [EditorMarkUpAttribute(displayName: "generic")]
            generic = 0x0,
            
            [EditorMarkUpAttribute(displayName: "snow")]
            snow = 0x1,
            
            [EditorMarkUpAttribute(displayName: "rain")]
            rain = 0x2,
            
            [EditorMarkUpAttribute(displayName: "rain splash")]
            rain_splash = 0x3,
            
            [EditorMarkUpAttribute(displayName: "bugs")]
            bugs = 0x4,
            
            [EditorMarkUpAttribute(displayName: "sand storm")]
            sand_storm = 0x5,
            
            [EditorMarkUpAttribute(displayName: "debris")]
            debris = 0x6,
            
            [EditorMarkUpAttribute(displayName: "bubbles")]
            bubbles = 0x7,
        }
    }
    #endregion
    
    #region particle_system_lite_data_block
    [TagBlockDefinitionAttribute(cacheFileSize: 48, tagFileSize: 48, alignment: 4, maxBlockCount: 1)]
    public class particle_system_lite_data_block
    {
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "particles render data")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<particles_render_data_block> particles_render_data;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "particles other data")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<particles_update_data_block> particles_other_data;
        
        [PaddingAttribute(PaddingType.Padding, 32)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
    }
    #endregion
    
    #region particles_render_data_block
    [TagBlockDefinitionAttribute(cacheFileSize: 20, tagFileSize: 20, alignment: 4, maxBlockCount: 4096)]
    public class particles_render_data_block
    {
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "position.x")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float position_x;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "position.y")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float position_y;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "position.z")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float position_z;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "size")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float size;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "color")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public ColorRgb color;
    }
    #endregion
    
    #region particles_update_data_block
    [TagBlockDefinitionAttribute(cacheFileSize: 32, tagFileSize: 32, alignment: 4, maxBlockCount: 4096)]
    public class particles_update_data_block
    {
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "velocity.x")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float velocity_x;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "velocity.y")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float velocity_y;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "velocity.z")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float velocity_z;
        
        [PaddingAttribute(PaddingType.Padding, 12)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "mass")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float mass;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "creation time stamp")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float creation_time_stamp;
    }
    #endregion
    
    #region global_weather_background_plate_block
    [TagBlockDefinitionAttribute(cacheFileSize: 936, tagFileSize: 936, alignment: 4, maxBlockCount: 3)]
    public class global_weather_background_plate_block
    {
        
        [EditorMarkUpAttribute(displayName: "texture 0")]
        [TagReferenceAttribute("bitm")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference texture_0;
        
        [EditorMarkUpAttribute(displayName: "texture 1")]
        [TagReferenceAttribute("bitm")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference texture_1;
        
        [EditorMarkUpAttribute(displayName: "texture 2")]
        [TagReferenceAttribute("bitm")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference texture_2;
        
        [EditorMarkUpAttribute(displayName: "plate positions 0")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float plate_positions_0;
        
        [EditorMarkUpAttribute(displayName: "plate positions 1")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float plate_positions_1;
        
        [EditorMarkUpAttribute(displayName: "plate positions 2")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float plate_positions_2;
        
        [EditorMarkUpAttribute(displayName: "move speed 0")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealVector3d move_speed_0;
        
        [EditorMarkUpAttribute(displayName: "move speed 1")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealVector3d move_speed_1;
        
        [EditorMarkUpAttribute(displayName: "move speed 2")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealVector3d move_speed_2;
        
        [EditorMarkUpAttribute(displayName: "texture scale 0")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float texture_scale_0;
        
        [EditorMarkUpAttribute(displayName: "texture scale 1")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float texture_scale_1;
        
        [EditorMarkUpAttribute(displayName: "texture scale 2")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float texture_scale_2;
        
        [EditorMarkUpAttribute(displayName: "jitter 0")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealVector3d jitter_0;
        
        [EditorMarkUpAttribute(displayName: "jitter 1")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealVector3d jitter_1;
        
        [EditorMarkUpAttribute(displayName: "jitter 2")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealVector3d jitter_2;
        
        [EditorMarkUpAttribute(displayName: "plate z near")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float plate_z_near;
        
        [EditorMarkUpAttribute(displayName: "plate z far")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float plate_z_far;
        
        [EditorMarkUpAttribute(displayName: "depth blend z near")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float depth_blend_z_near;
        
        [EditorMarkUpAttribute(displayName: "depth blend z far")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float depth_blend_z_far;
        
        [EditorMarkUpAttribute(displayName: "opacity 0")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float opacity_0;
        
        [EditorMarkUpAttribute(displayName: "opacity 1")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float opacity_1;
        
        [EditorMarkUpAttribute(displayName: "opacity 2")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float opacity_2;
        
        [EditorMarkUpAttribute(displayName: "flags")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public b_flags flags;
        
        [EditorMarkUpAttribute(displayName: "tint color0")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealColorRgb tint_color0;
        
        [EditorMarkUpAttribute(displayName: "tint color1")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealColorRgb tint_color1;
        
        [EditorMarkUpAttribute(displayName: "tint color2")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealColorRgb tint_color2;
        
        [EditorMarkUpAttribute(displayName: "mass 1")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float mass_1;
        
        [EditorMarkUpAttribute(displayName: "mass 2")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float mass_2;
        
        [EditorMarkUpAttribute(displayName: "mass 3")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float mass_3;
        
        [PaddingAttribute(PaddingType.Padding, 736)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [FlagsAttribute()]
        public enum b_flags : uint
        {
            
            [EditorMarkUpAttribute(displayName: "forward motion")]
            forward_motion = 0x1,
            
            [EditorMarkUpAttribute(displayName: "auto position planes")]
            auto_position_planes = 0x2,
            
            [EditorMarkUpAttribute(displayName: "auto scale planesauto update speed")]
            auto_scale_planesauto_update_speed = 0x4,
        }
    }
    #endregion
    
    #region global_wind_model_struct_block
    [TagBlockDefinitionAttribute(cacheFileSize: 156, tagFileSize: 156, alignment: 4, maxBlockCount: 1)]
    public class global_wind_model_struct_block
    {
        
        [EditorMarkUpAttribute(displayName: "wind tiling scale")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float wind_tiling_scale;
        
        [EditorMarkUpAttribute(displayName: "wind primary heading/pitch/strength")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealVector3d wind_primary_heading_pitch_strength;
        
        [EditorMarkUpAttribute(displayName: "primary rate of change")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float primary_rate_of_change;
        
        [EditorMarkUpAttribute(displayName: "primary min strength")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float primary_min_strength;
        
        [PaddingAttribute(PaddingType.Padding, 4)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [PaddingAttribute(PaddingType.Padding, 4)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding1;
        
        [PaddingAttribute(PaddingType.Padding, 12)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding2;
        
        [EditorMarkUpAttribute(displayName: "wind gusting heading/pitch/strength")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealVector3d wind_gusting_heading_pitch_strength;
        
        [EditorMarkUpAttribute(displayName: "gust diretional rate of change")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float gust_diretional_rate_of_change;
        
        [EditorMarkUpAttribute(displayName: "gust strength rate of change")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float gust_strength_rate_of_change;
        
        [EditorMarkUpAttribute(displayName: "gust cone angle")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float gust_cone_angle;
        
        [PaddingAttribute(PaddingType.Padding, 4)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding3;
        
        [PaddingAttribute(PaddingType.Padding, 4)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding4;
        
        [PaddingAttribute(PaddingType.Padding, 12)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding5;
        
        [PaddingAttribute(PaddingType.Padding, 12)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding6;
        
        [PaddingAttribute(PaddingType.Padding, 12)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding7;
        
        [PaddingAttribute(PaddingType.Padding, 12)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding8;
        
        [EditorMarkUpAttribute(displayName: "turbulance rate of change")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float turbulance_rate_of_change;
        
        [EditorMarkUpAttribute(displayName: "turbulence_scale x, y, z")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealVector3d turbulence_scale_x__y__z;
        
        [EditorMarkUpAttribute(displayName: "gravity constant")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float gravity_constant;
        
        [EditorMarkUpAttribute(displayName: "wind_pirmitives")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<gloal_wind_primitives_block> wind_pirmitives;
        
        [PaddingAttribute(PaddingType.Padding, 4)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding9;
    }
    #endregion
    
    #region gloal_wind_primitives_block
    [TagBlockDefinitionAttribute(cacheFileSize: 24, tagFileSize: 24, alignment: 4, maxBlockCount: 128)]
    public class gloal_wind_primitives_block
    {
        
        [EditorMarkUpAttribute(displayName: "position")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealVector3d position;
        
        [EditorMarkUpAttribute(displayName: "radius")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float radius;
        
        [EditorMarkUpAttribute(displayName: "strength")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float strength;
        
        [EditorMarkUpAttribute(displayName: "wind primitive type")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public e_wind_primitive_type wind_primitive_type;
        
        [PaddingAttribute(PaddingType.Padding, 2)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        public enum e_wind_primitive_type : short
        {
            
            [EditorMarkUpAttribute(displayName: "vortex")]
            vortex = 0x0,
            
            [EditorMarkUpAttribute(displayName: "gust")]
            gust = 0x1,
            
            [EditorMarkUpAttribute(displayName: "implosion")]
            implosion = 0x2,
            
            [EditorMarkUpAttribute(displayName: "explosion")]
            explosion = 0x3,
        }
    }
    #endregion
}
