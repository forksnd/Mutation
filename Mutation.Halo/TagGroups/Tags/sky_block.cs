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
    
    
    [TagGroupDefinitionAttribute(cacheFileSize: 172, tagFileSize: 220, version: 1, groupTag: "sky ", parentGroupTag: "", name: "sky", minimumVersion: EngineVersion.Halo2Xbox, maximumVersion: EngineVersion.Halo2Vista)]
    public class sky_block
    {
        
        [EditorMarkUpAttribute(displayName: "Render Model")]
        [TagReferenceAttribute("mode")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference render_model;
        
        [EditorMarkUpAttribute(displayName: "Animation Graph")]
        [TagReferenceAttribute("jmad")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference animation_graph;
        
        [EditorMarkUpAttribute(displayName: "Flags")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public b_flags flags;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.Unknown1, displayName: "Render Model Scale", tooltipText: "Multiplier by which to scale the model\'s geometry up or down (0 defaults to stand" +
    "ard, 0.03).")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float render_model_scale;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.Unknown1, displayName: "Movement Scale", tooltipText: "How much the sky moves to remain centered on the player (0 defaults to 1.0, which" +
    " means no parallax).")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float movement_scale;
        
        [EditorMarkUpAttribute(displayName: "Cube Map")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<sky_cubemap_block> cube_map;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField0 = new Explanation(name: "AMBIENT LIGHT");
        
        [EditorMarkUpAttribute(displayName: "Indoor Ambient Color", tooltipText: "Indoor ambient light color.")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealColorRgb indoor_ambient_color;
        
        [PaddingAttribute(PaddingType.Padding, 4)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [EditorMarkUpAttribute(displayName: "Outdoor Ambient Color", tooltipText: "Indoor ambient light color.")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealColorRgb outdoor_ambient_color;
        
        [PaddingAttribute(PaddingType.Padding, 4)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding1;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField1 = new Explanation(name: "FOG");
        
        [EditorMarkUpAttribute(displayName: "Fog Spread Distance", unitsSpecifier: "world units", tooltipText: "How far fog spreads into adjacent clusters.")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float fog_spread_distance;
        
        [EditorMarkUpAttribute(displayName: "Atmospheric Fog")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<sky_atmospheric_fog_block> atmospheric_fog;
        
        [EditorMarkUpAttribute(displayName: "Secondary Fog")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<sky_atmospheric_fog_block> secondary_fog;
        
        [EditorMarkUpAttribute(displayName: "Sky Fog")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<sky_fog_block> sky_fog;
        
        [EditorMarkUpAttribute(displayName: "Patchy Fog")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<sky_patchy_fog_block> patchy_fog;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField2 = new Explanation(name: "BLOOM OVERRIDE");
        
        [EditorMarkUpAttribute(displayName: "Amount", unitsSpecifier: "[0,1]")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float amount;
        
        [EditorMarkUpAttribute(displayName: "Threshold", unitsSpecifier: "[0,1]")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float threshold;
        
        [EditorMarkUpAttribute(displayName: "Brightness", unitsSpecifier: "[0,1]")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float brightness;
        
        [EditorMarkUpAttribute(displayName: "Gamma Power")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float gamma_power;
        
        [EditorMarkUpAttribute(displayName: "Lights")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<sky_light_block> lights;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField3 = new Explanation(name: "ROTATION");
        
        [EditorMarkUpAttribute(displayName: "Global Sky Rotation")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float global_sky_rotation;
        
        [EditorMarkUpAttribute(displayName: "Shader Functions")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<sky_shader_function_block> shader_functions;
        
        [EditorMarkUpAttribute(displayName: "Animations")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<sky_animation_block> animations;
        
        [PaddingAttribute(PaddingType.Padding, 12)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding2;
        
        [EditorMarkUpAttribute(displayName: "Clear Color")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealColorRgb clear_color;
        
        [FlagsAttribute()]
        public enum b_flags : uint
        {
            
            [EditorMarkUpAttribute(displayName: "Fixed in World Space")]
            fixed_in_world_space = 0x1,
            
            [EditorMarkUpAttribute(displayName: "Depreciated")]
            depreciated = 0x2,
            
            [EditorMarkUpAttribute(displayName: "Sky Casts Light from Below")]
            sky_casts_light_from_below = 0x4,
            
            [EditorMarkUpAttribute(displayName: "Disable Sky in Lightmaps")]
            disable_sky_in_lightmaps = 0x8,
            
            [EditorMarkUpAttribute(displayName: "Fog Only Affects Containing Clusters")]
            fog_only_affects_containing_clusters = 0x10,
            
            [EditorMarkUpAttribute(displayName: "Use Clear Color")]
            use_clear_color = 0x20,
        }
    }
    
    #region sky_cubemap_block
    [TagBlockDefinitionAttribute(cacheFileSize: 12, tagFileSize: 12, alignment: 4, maxBlockCount: 1)]
    public class sky_cubemap_block
    {
        
        [EditorMarkUpAttribute(displayName: "Cube Map Reference")]
        [TagReferenceAttribute("bitm")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference cube_map_reference;
        
        [EditorMarkUpAttribute(displayName: "Power Scale", tooltipText: "0 Defaults to 1.")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float power_scale;
    }
    #endregion
    
    #region sky_atmospheric_fog_block
    [TagBlockDefinitionAttribute(cacheFileSize: 24, tagFileSize: 24, alignment: 4, maxBlockCount: 1)]
    public class sky_atmospheric_fog_block
    {
        
        [EditorMarkUpAttribute(displayName: "Color")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealColorRgb color;
        
        [EditorMarkUpAttribute(displayName: "Maximum Density", unitsSpecifier: "[0,1]", tooltipText: "Fog density is clamped to this value.")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float maximum_density;
        
        [EditorMarkUpAttribute(displayName: "Start Distance", unitsSpecifier: "world units", tooltipText: "Before this distance there is no fog.")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float start_distance;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.Unknown1, displayName: "Opaque Distance", unitsSpecifier: "world units", tooltipText: "Fog becomes opaque (maximum density) at this distance from the viewer.")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float opaque_distance;
    }
    #endregion
    
    #region sky_fog_block
    [TagBlockDefinitionAttribute(cacheFileSize: 16, tagFileSize: 16, alignment: 4, maxBlockCount: 1)]
    public class sky_fog_block
    {
        
        [EditorMarkUpAttribute(displayName: "Color")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealColorRgb color;
        
        [EditorMarkUpAttribute(displayName: "Density", unitsSpecifier: "[0,1]", tooltipText: "Fog density is clamped to this value.")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float density;
    }
    #endregion
    
    #region sky_patchy_fog_block
    [TagBlockDefinitionAttribute(cacheFileSize: 80, tagFileSize: 80, alignment: 4, maxBlockCount: 1)]
    public class sky_patchy_fog_block
    {
        
        [EditorMarkUpAttribute(displayName: "Color")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealColorRgb color;
        
        [PaddingAttribute(PaddingType.Padding, 12)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [EditorMarkUpAttribute(displayName: "Density", unitsSpecifier: "[0,1]")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealFractionBounds density;
        
        [EditorMarkUpAttribute(displayName: "Distance", unitsSpecifier: "world units")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealBounds distance;
        
        [PaddingAttribute(PaddingType.Padding, 32)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding1;
        
        [EditorMarkUpAttribute(displayName: "Patchy Fog")]
        [TagReferenceAttribute("fpch")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference patchy_fog;
    }
    #endregion
    
    #region sky_light_block
    [TagBlockDefinitionAttribute(cacheFileSize: 52, tagFileSize: 52, alignment: 4, maxBlockCount: 8)]
    public class sky_light_block
    {
        
        [EditorMarkUpAttribute(displayName: "Direction Vector")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealVector3d direction_vector;
        
        [EditorMarkUpAttribute(displayName: "Direction")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealEulerAngle2d direction;
        
        [EditorMarkUpAttribute(displayName: "Lens Flare")]
        [TagReferenceAttribute("lens")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference lens_flare;
        
        [EditorMarkUpAttribute(displayName: "Fog")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<sky_light_fog_block> fog;
        
        [EditorMarkUpAttribute(displayName: "Fog Opposite")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<sky_light_fog_block> fog_opposite;
        
        [EditorMarkUpAttribute(displayName: "Radiosity")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<sky_radiosity_light_block> radiosity;
    }
    #endregion
    
    #region sky_light_fog_block
    [TagBlockDefinitionAttribute(cacheFileSize: 44, tagFileSize: 44, alignment: 4, maxBlockCount: 1)]
    public class sky_light_fog_block
    {
        
        [EditorMarkUpAttribute(displayName: "Color")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealColorRgb color;
        
        [EditorMarkUpAttribute(displayName: "Maximum Density", unitsSpecifier: "[0,1]", tooltipText: "Fog density is clamped to this value.")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float maximum_density;
        
        [EditorMarkUpAttribute(displayName: "Start Distance", unitsSpecifier: "world units", tooltipText: "Before this distance there is no fog.")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float start_distance;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.Unknown1, displayName: "Opaque Distance", unitsSpecifier: "world units", tooltipText: "Fog becomes opaque (maximum density) at this distance from the viewer.")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float opaque_distance;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField0 = new Explanation(name: "FOG INFLUENCES");
        
        [EditorMarkUpAttribute(displayName: "Cone", unitsSpecifier: "degrees")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public AngleBounds cone;
        
        [EditorMarkUpAttribute(displayName: "Atmospheric Fog Influence", unitsSpecifier: "[0,1]")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float atmospheric_fog_influence;
        
        [EditorMarkUpAttribute(displayName: "Secondary Fog Influence", unitsSpecifier: "[0,1]")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float secondary_fog_influence;
        
        [EditorMarkUpAttribute(displayName: "Sky Fog Influence", unitsSpecifier: "[0,1]")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float sky_fog_influence;
    }
    #endregion
    
    #region sky_radiosity_light_block
    [TagBlockDefinitionAttribute(cacheFileSize: 40, tagFileSize: 40, alignment: 4, maxBlockCount: 1)]
    public class sky_radiosity_light_block
    {
        
        [EditorMarkUpAttribute(displayName: "Flags")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public b_flags flags;
        
        [EditorMarkUpAttribute(displayName: "Color", unitsSpecifier: "", tooltipText: "Light color.")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealColorRgb color;
        
        [EditorMarkUpAttribute(displayName: "Power", unitsSpecifier: "[0,+inf]", tooltipText: "Light power from 0 to infinity.")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float power;
        
        [EditorMarkUpAttribute(displayName: "Test Distance", unitsSpecifier: "world units", tooltipText: "Length of the ray for shadow testing.")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float test_distance;
        
        [PaddingAttribute(PaddingType.Padding, 12)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [EditorMarkUpAttribute(displayName: "Diameter", unitsSpecifier: "degrees", tooltipText: "Angular diameter of the light source in the sky.")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float diameter;
        
        [FlagsAttribute()]
        public enum b_flags : uint
        {
            
            [EditorMarkUpAttribute(displayName: "Affects Exteriors")]
            affects_exteriors = 0x1,
            
            [EditorMarkUpAttribute(displayName: "Affects Interiors")]
            affects_interiors = 0x2,
            
            [EditorMarkUpAttribute(displayName: "Direct Illumination in Lightmaps")]
            direct_illumination_in_lightmaps = 0x4,
            
            [EditorMarkUpAttribute(displayName: "Indirect Illumination in Lightmaps")]
            indirect_illumination_in_lightmaps = 0x8,
        }
    }
    #endregion
    
    #region sky_shader_function_block
    [TagBlockDefinitionAttribute(cacheFileSize: 36, tagFileSize: 36, alignment: 4, maxBlockCount: 8)]
    public class sky_shader_function_block
    {
        
        [PaddingAttribute(PaddingType.Padding, 4)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.BlockName, displayName: "Global Function Name", tooltipText: "Global function that controls this shader value.")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public String32 global_function_name;
    }
    #endregion
    
    #region sky_animation_block
    [TagBlockDefinitionAttribute(cacheFileSize: 36, tagFileSize: 36, alignment: 4, maxBlockCount: 8)]
    public class sky_animation_block
    {
        
        [EditorMarkUpAttribute(displayName: "Animation Index", tooltipText: "Index of the animation in the animation graph.")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short animation_index;
        
        [PaddingAttribute(PaddingType.Padding, 2)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [EditorMarkUpAttribute(displayName: "Period", unitsSpecifier: "sec")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float period;
        
        [PaddingAttribute(PaddingType.Padding, 28)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding1;
    }
    #endregion
}
