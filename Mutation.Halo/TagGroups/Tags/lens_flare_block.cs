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
    
    
    [TagGroupDefinitionAttribute(cacheFileSize: 100, tagFileSize: 124, version: 2, groupTag: "lens", parentGroupTag: "", name: "lens_flare", minimumVersion: EngineVersion.Halo2Xbox, maximumVersion: EngineVersion.Halo2Vista)]
    public class lens_flare_block
    {
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField0 = new Explanation(name: "LENS FLARE");
        
        [EditorMarkUpAttribute(displayName: "falloff angle", unitsSpecifier: "degrees")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float falloff_angle;
        
        [EditorMarkUpAttribute(displayName: "cutoff angle", unitsSpecifier: "degrees")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float cutoff_angle;
        
        [PaddingAttribute(PaddingType.Skip, 4)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [PaddingAttribute(PaddingType.Skip, 4)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding1;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField1 = new Explanation(name: "OCCLUSION", explanation: "Occlusion factor affects overall lens flare brightness and can also affect scale." +
    " Occlusion never affects rotation.");
        
        [EditorMarkUpAttribute(displayName: "occlusion radius", unitsSpecifier: "world units", tooltipText: "radius of the square used to test occlusion")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float occlusion_radius;
        
        [EditorMarkUpAttribute(displayName: "occlusion offset direction")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public e_occlusion_offset_direction occlusion_offset_direction;
        
        [EditorMarkUpAttribute(displayName: "occlusion inner radius scale")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public e_occlusion_inner_radius_scale occlusion_inner_radius_scale;
        
        [EditorMarkUpAttribute(displayName: "near fade distance", unitsSpecifier: "world units", tooltipText: "distance at which the lens flare brightness is maximum")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float near_fade_distance;
        
        [EditorMarkUpAttribute(displayName: "far fade distance", unitsSpecifier: "world units", tooltipText: "distance at which the lens flare brightness is minimum; set to zero to disable di" +
    "stance fading")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float far_fade_distance;
        
        [EditorMarkUpAttribute(displayName: "bitmap")]
        [TagReferenceAttribute("bitm")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference bitmap;
        
        [EditorMarkUpAttribute(displayName: "flags")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public b_flags flags;
        
        [PaddingAttribute(PaddingType.Skip, 2)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding2;
        
        [PaddingAttribute(PaddingType.Useless, 76)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding3;
        
        [EditorMarkUpAttribute(displayName: "rotation function")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public e_rotation_function rotation_function;
        
        [PaddingAttribute(PaddingType.Padding, 2)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding4;
        
        [EditorMarkUpAttribute(displayName: "rotation function scale", unitsSpecifier: "degrees")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float rotation_function_scale;
        
        [PaddingAttribute(PaddingType.Useless, 24)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding5;
        
        [EditorMarkUpAttribute(displayName: "corona scale", tooltipText: "amount to stretch the corona")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealVector2d corona_scale;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField2 = new Explanation(name: "EFFECT PARAMETERS", explanation: "Only affects lens flares created by effects.");
        
        [EditorMarkUpAttribute(displayName: "falloff function")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public e_falloff_function falloff_function;
        
        [PaddingAttribute(PaddingType.Padding, 2)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding6;
        
        [PaddingAttribute(PaddingType.Useless, 24)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding7;
        
        [EditorMarkUpAttribute(displayName: "reflections")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<lens_flare_reflection_block> reflections;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField3 = new Explanation(name: "ANIMATION");
        
        [EditorMarkUpAttribute(displayName: "flags")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public b_flags1 flags1;
        
        [PaddingAttribute(PaddingType.Padding, 2)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding8;
        
        [EditorMarkUpAttribute(displayName: "brightness")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<lens_flare_scalar_animation_block> brightness;
        
        [EditorMarkUpAttribute(displayName: "color")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<lens_flare_color_animation_block> color;
        
        [EditorMarkUpAttribute(displayName: "rotation")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<lens_flare_scalar_animation_block> rotation;
        
        [PaddingAttribute(PaddingType.Useless, 4)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding9;
        
        public enum e_occlusion_offset_direction : short
        {
            
            [EditorMarkUpAttribute(displayName: "toward viewer")]
            toward_viewer = 0x0,
            
            [EditorMarkUpAttribute(displayName: "marker forward")]
            marker_forward = 0x1,
            
            [EditorMarkUpAttribute(displayName: "none")]
            none = 0x2,
        }
        
        public enum e_occlusion_inner_radius_scale : short
        {
            
            [EditorMarkUpAttribute(displayName: "none")]
            none = 0x0,
            
            [EditorMarkUpAttribute(displayName: "1/2")]
            _1_2 = 0x1,
            
            [EditorMarkUpAttribute(displayName: "1/4")]
            _1_4 = 0x2,
            
            [EditorMarkUpAttribute(displayName: "1/8")]
            _1_8 = 0x3,
            
            [EditorMarkUpAttribute(displayName: "1/16")]
            _1_16 = 0x4,
            
            [EditorMarkUpAttribute(displayName: "1/32")]
            _1_32 = 0x5,
            
            [EditorMarkUpAttribute(displayName: "1/64")]
            _1_64 = 0x6,
        }
        
        [FlagsAttribute()]
        public enum b_flags : short
        {
            
            [EditorMarkUpAttribute(displayName: "sun")]
            sun = 0x1,
            
            [EditorMarkUpAttribute(displayName: "no occlusion test")]
            no_occlusion_test = 0x2,
            
            [EditorMarkUpAttribute(displayName: "only render in first person")]
            only_render_in_first_person = 0x4,
            
            [EditorMarkUpAttribute(displayName: "only render in third person")]
            only_render_in_third_person = 0x8,
            
            [EditorMarkUpAttribute(displayName: "fade in more quickly")]
            fade_in_more_quickly = 0x10,
            
            [EditorMarkUpAttribute(displayName: "fade out more quickly")]
            fade_out_more_quickly = 0x20,
            
            [EditorMarkUpAttribute(displayName: "scale by marker")]
            scale_by_marker = 0x40,
        }
        
        public enum e_rotation_function : short
        {
            
            [EditorMarkUpAttribute(displayName: "none")]
            none = 0x0,
            
            [EditorMarkUpAttribute(displayName: "rotation A")]
            rotation_a = 0x1,
            
            [EditorMarkUpAttribute(displayName: "rotation B")]
            rotation_b = 0x2,
            
            [EditorMarkUpAttribute(displayName: "rotation-translation")]
            rotation_translation = 0x3,
            
            [EditorMarkUpAttribute(displayName: "translation")]
            translation = 0x4,
        }
        
        public enum e_falloff_function : short
        {
            
            [EditorMarkUpAttribute(displayName: "linear")]
            linear = 0x0,
            
            [EditorMarkUpAttribute(displayName: "late")]
            late = 0x1,
            
            [EditorMarkUpAttribute(displayName: "very late")]
            very_late = 0x2,
            
            [EditorMarkUpAttribute(displayName: "early")]
            early = 0x3,
            
            [EditorMarkUpAttribute(displayName: "very early")]
            very_early = 0x4,
            
            [EditorMarkUpAttribute(displayName: "cosine")]
            cosine = 0x5,
            
            [EditorMarkUpAttribute(displayName: "zero")]
            zero = 0x6,
            
            [EditorMarkUpAttribute(displayName: "one")]
            one = 0x7,
        }
        
        [FlagsAttribute()]
        public enum b_flags1 : short
        {
            
            [EditorMarkUpAttribute(displayName: "synchronized")]
            synchronized = 0x1,
        }
    }
    
    #region lens_flare_reflection_block
    [TagBlockDefinitionAttribute(cacheFileSize: 48, tagFileSize: 48, alignment: 4, maxBlockCount: 32)]
    public class lens_flare_reflection_block
    {
        
        [EditorMarkUpAttribute(displayName: "flags")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public b_flags flags;
        
        [PaddingAttribute(PaddingType.Padding, 2)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [EditorMarkUpAttribute(displayName: "bitmap index")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short bitmap_index;
        
        [PaddingAttribute(PaddingType.Padding, 2)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding1;
        
        [PaddingAttribute(PaddingType.Useless, 20)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding2;
        
        [EditorMarkUpAttribute(displayName: "position", unitsSpecifier: "along flare axis", tooltipText: "0 is on top of light, 1 is opposite light, 0.5 is the center of the screen, etc.")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float position;
        
        [EditorMarkUpAttribute(displayName: "rotation offset", unitsSpecifier: "degrees")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float rotation_offset;
        
        [PaddingAttribute(PaddingType.Useless, 4)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding3;
        
        [EditorMarkUpAttribute(displayName: "radius", unitsSpecifier: "world units", tooltipText: "interpolated by external input")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealBounds radius;
        
        [PaddingAttribute(PaddingType.Useless, 4)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding4;
        
        [EditorMarkUpAttribute(displayName: "brightness", unitsSpecifier: "[0,1]", tooltipText: "interpolated by external input")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealFractionBounds brightness;
        
        [PaddingAttribute(PaddingType.Useless, 4)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding5;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField0 = new Explanation(name: "TINT COLOR", explanation: @"Tinting and modulating are not the same; 'tinting' a reflection will color the darker regions but leave the highlights, while 'modulating' will color everything uniformly. The modulation factor controls how much the reflection is modulated as opposed to tinted (0 is tinted, 1 is modulated).");
        
        [EditorMarkUpAttribute(displayName: "modulation factor", unitsSpecifier: "[0,1]")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float modulation_factor;
        
        [EditorMarkUpAttribute(displayName: "color")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealColorRgb color;
        
        [PaddingAttribute(PaddingType.Useless, 48)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding6;
        
        [FlagsAttribute()]
        public enum b_flags : short
        {
            
            [EditorMarkUpAttribute(displayName: "align rotation with screen center")]
            align_rotation_with_screen_center = 0x1,
            
            [EditorMarkUpAttribute(displayName: "radius NOT scaled by distance")]
            radius_not_scaled_by_distance = 0x2,
            
            [EditorMarkUpAttribute(displayName: "radius scaled by occlusion factor")]
            radius_scaled_by_occlusion_factor = 0x4,
            
            [EditorMarkUpAttribute(displayName: "occluded by solid objects")]
            occluded_by_solid_objects = 0x8,
            
            [EditorMarkUpAttribute(displayName: "ignore light color")]
            ignore_light_color = 0x10,
            
            [EditorMarkUpAttribute(displayName: "not affected by inner occlusion")]
            not_affected_by_inner_occlusion = 0x20,
        }
    }
    #endregion
    
    #region lens_flare_scalar_animation_block
    [TagBlockDefinitionAttribute(cacheFileSize: 8, tagFileSize: 8, alignment: 4, maxBlockCount: 1)]
    public class lens_flare_scalar_animation_block
    {
        
        [EditorMarkUpAttribute(displayName: "function")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public scalar_function_struct_block function;
    }
    #endregion
    
    #region lens_flare_color_animation_block
    [TagBlockDefinitionAttribute(cacheFileSize: 8, tagFileSize: 8, alignment: 4, maxBlockCount: 1)]
    public class lens_flare_color_animation_block
    {
        
        [EditorMarkUpAttribute(displayName: "function")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public color_function_struct_block function;
    }
    #endregion
}