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
    
    
    #region global_hud_multitexture_overlay_definition
    [TagBlockDefinitionAttribute(cacheFileSize: 452, tagFileSize: 480, alignment: 4, maxBlockCount: 30)]
    public class global_hud_multitexture_overlay_definition
    {
        
        [PaddingAttribute(PaddingType.Padding, 2)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [EditorMarkUpAttribute(displayName: "type")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short type;
        
        [EditorMarkUpAttribute(displayName: "framebuffer blend func")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public e_framebuffer_blend_func framebuffer_blend_func;
        
        [PaddingAttribute(PaddingType.Padding, 2)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding1;
        
        [PaddingAttribute(PaddingType.Padding, 32)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding2;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField0 = new Explanation(name: "anchors", explanation: "where you want the origin of the texture.\n*\"texture\" uses the texture coordinates" +
    " supplied\n*\"screen\" uses the origin of the screen as the origin of the texture");
        
        [EditorMarkUpAttribute(displayName: "primary anchor")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public e_primary_anchor primary_anchor;
        
        [EditorMarkUpAttribute(displayName: "secondary anchor")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public e_primary_anchor secondary_anchor;
        
        [EditorMarkUpAttribute(displayName: "tertiary anchor")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public e_primary_anchor tertiary_anchor;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField1 = new Explanation(name: "blending function", explanation: "how to blend the textures together");
        
        [EditorMarkUpAttribute(displayName: "0 to 1 blend func")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public e__0_to_1_blend_func _0_to_1_blend_func;
        
        [EditorMarkUpAttribute(displayName: "1 to 2 blend func")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public e__0_to_1_blend_func _1_to_2_blend_func;
        
        [PaddingAttribute(PaddingType.Padding, 2)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding3;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField2 = new Explanation(name: "map scales", explanation: "how much to scale the textures");
        
        [EditorMarkUpAttribute(displayName: "primary scale")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealPoint2d primary_scale;
        
        [EditorMarkUpAttribute(displayName: "secondary scale")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealPoint2d secondary_scale;
        
        [EditorMarkUpAttribute(displayName: "tertiary scale")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealPoint2d tertiary_scale;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField3 = new Explanation(name: "map offsets", explanation: "how much to offset the origin of the texture");
        
        [EditorMarkUpAttribute(displayName: "primary offset")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealPoint2d primary_offset;
        
        [EditorMarkUpAttribute(displayName: "secondary offset")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealPoint2d secondary_offset;
        
        [EditorMarkUpAttribute(displayName: "tertiary offset")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealPoint2d tertiary_offset;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField4 = new Explanation(name: "map", explanation: "which maps to use");
        
        [EditorMarkUpAttribute(displayName: "primary")]
        [TagReferenceAttribute("bitm")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference primary;
        
        [EditorMarkUpAttribute(displayName: "secondary")]
        [TagReferenceAttribute("bitm")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference secondary;
        
        [EditorMarkUpAttribute(displayName: "tertiary")]
        [TagReferenceAttribute("bitm")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference tertiary;
        
        [EditorMarkUpAttribute(displayName: "primary wrap mode")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public e_primary_wrap_mode primary_wrap_mode;
        
        [EditorMarkUpAttribute(displayName: "secondary wrap mode")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public e_primary_wrap_mode secondary_wrap_mode;
        
        [EditorMarkUpAttribute(displayName: "tertiary wrap mode")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public e_primary_wrap_mode tertiary_wrap_mode;
        
        [PaddingAttribute(PaddingType.Padding, 2)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding4;
        
        [PaddingAttribute(PaddingType.Padding, 184)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding5;
        
        [EditorMarkUpAttribute(displayName: "effectors")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<global_hud_multitexture_overlay_effector_definition> effectors;
        
        [PaddingAttribute(PaddingType.Padding, 128)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding6;
        
        public enum e_framebuffer_blend_func : short
        {
            
            [EditorMarkUpAttribute(displayName: "alpha blend")]
            alpha_blend = 0x0,
            
            [EditorMarkUpAttribute(displayName: "multiply")]
            multiply = 0x1,
            
            [EditorMarkUpAttribute(displayName: "double multiply")]
            double_multiply = 0x2,
            
            [EditorMarkUpAttribute(displayName: "add")]
            add = 0x3,
            
            [EditorMarkUpAttribute(displayName: "subtract")]
            subtract = 0x4,
            
            [EditorMarkUpAttribute(displayName: "component min")]
            component_min = 0x5,
            
            [EditorMarkUpAttribute(displayName: "component max")]
            component_max = 0x6,
            
            [EditorMarkUpAttribute(displayName: "alpha-multiply add")]
            alpha_multiply_add = 0x7,
            
            [EditorMarkUpAttribute(displayName: "constant color blend")]
            constant_color_blend = 0x8,
            
            [EditorMarkUpAttribute(displayName: "inverse constant color blend")]
            inverse_constant_color_blend = 0x9,
            
            [EditorMarkUpAttribute(displayName: "none")]
            none = 0xa,
        }
        
        public enum e_primary_anchor : short
        {
            
            [EditorMarkUpAttribute(displayName: "texture")]
            texture = 0x0,
            
            [EditorMarkUpAttribute(displayName: "screen")]
            screen = 0x1,
        }
        
        public enum e__0_to_1_blend_func : short
        {
            
            [EditorMarkUpAttribute(displayName: "add")]
            add = 0x0,
            
            [EditorMarkUpAttribute(displayName: "subtract")]
            subtract = 0x1,
            
            [EditorMarkUpAttribute(displayName: "multiply")]
            multiply = 0x2,
            
            [EditorMarkUpAttribute(displayName: "multiply2x")]
            multiply2x = 0x3,
            
            [EditorMarkUpAttribute(displayName: "dot")]
            dot = 0x4,
        }
        
        public enum e_primary_wrap_mode : short
        {
            
            [EditorMarkUpAttribute(displayName: "clamp")]
            clamp = 0x0,
            
            [EditorMarkUpAttribute(displayName: "wrap")]
            wrap = 0x1,
        }
    }
    #endregion
    
    #region global_hud_multitexture_overlay_effector_definition
    [TagBlockDefinitionAttribute(cacheFileSize: 220, tagFileSize: 220, alignment: 4, maxBlockCount: 30)]
    public class global_hud_multitexture_overlay_effector_definition
    {
        
        [PaddingAttribute(PaddingType.Padding, 64)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField0 = new Explanation(name: "source/destination", explanation: @"These describe the relationship that causes the effect.
* destination type is the type of variable you want to be effected
* destination tells which texture map (or geometry offset) to apply it to
* source says which value to look at when computing the effect");
        
        [EditorMarkUpAttribute(displayName: "destination type")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public e_destination_type destination_type;
        
        [EditorMarkUpAttribute(displayName: "destination")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public e_destination destination;
        
        [EditorMarkUpAttribute(displayName: "source")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public e_source source;
        
        [PaddingAttribute(PaddingType.Padding, 2)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding1;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField1 = new Explanation(name: "in/out bounds", explanation: "When the source is at the lower inbound, the destination ends up the lower outbou" +
    "nd and vice-versa applies for the upper values.");
        
        [EditorMarkUpAttribute(displayName: "in bounds", unitsSpecifier: "source units")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealBounds in_bounds;
        
        [EditorMarkUpAttribute(displayName: "out bounds", unitsSpecifier: "pixels")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealBounds out_bounds;
        
        [PaddingAttribute(PaddingType.Padding, 64)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding2;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField2 = new Explanation(name: "tint color bounds", explanation: "If destination is tint, these values are used instead of the out bounds.");
        
        [EditorMarkUpAttribute(displayName: "tint color lower bound")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealColorRgb tint_color_lower_bound;
        
        [EditorMarkUpAttribute(displayName: "tint color upper bound")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealColorRgb tint_color_upper_bound;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField3 = new Explanation(name: "periodic functions", explanation: "If you use a periodic function as the source, this lets you tweak it.");
        
        [EditorMarkUpAttribute(displayName: "periodic function")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public e_periodic_function periodic_function;
        
        [PaddingAttribute(PaddingType.Padding, 2)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding3;
        
        [EditorMarkUpAttribute(displayName: "function period", unitsSpecifier: "seconds")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float function_period;
        
        [EditorMarkUpAttribute(displayName: "function phase", unitsSpecifier: "seconds")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float function_phase;
        
        [PaddingAttribute(PaddingType.Padding, 32)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding4;
        
        public enum e_destination_type : short
        {
            
            [EditorMarkUpAttribute(displayName: "tint [0,1]")]
            tint__0_1 = 0x0,
            
            [EditorMarkUpAttribute(displayName: "horizontal offset")]
            horizontal_offset = 0x1,
            
            [EditorMarkUpAttribute(displayName: "vertical offset")]
            vertical_offset = 0x2,
            
            [EditorMarkUpAttribute(displayName: "fade [0,1]")]
            fade__0_1 = 0x3,
        }
        
        public enum e_destination : short
        {
            
            [EditorMarkUpAttribute(displayName: "geometry offset")]
            geometry_offset = 0x0,
            
            [EditorMarkUpAttribute(displayName: "primary map")]
            primary_map = 0x1,
            
            [EditorMarkUpAttribute(displayName: "secondary map")]
            secondary_map = 0x2,
            
            [EditorMarkUpAttribute(displayName: "tertiary map")]
            tertiary_map = 0x3,
        }
        
        public enum e_source : short
        {
            
            [EditorMarkUpAttribute(displayName: "player pitch")]
            player_pitch = 0x0,
            
            [EditorMarkUpAttribute(displayName: "player pitch tangent")]
            player_pitch_tangent = 0x1,
            
            [EditorMarkUpAttribute(displayName: "player yaw")]
            player_yaw = 0x2,
            
            [EditorMarkUpAttribute(flags: EditorMarkUpFlags.Unknown1, displayName: "weapon rounds (loaded")]
            weapon_rounds__loaded = 0x3,
            
            [EditorMarkUpAttribute(flags: EditorMarkUpFlags.Unknown1, displayName: "weapon rounds (inventory")]
            weapon_rounds__inventory = 0x4,
            
            [EditorMarkUpAttribute(displayName: "weapon heat")]
            weapon_heat = 0x5,
            
            [EditorMarkUpAttribute(flags: EditorMarkUpFlags.Unknown1, displayName: "explicit (uses low bound")]
            explicit__uses_low_bound = 0x6,
            
            [EditorMarkUpAttribute(displayName: "weapon zoom level")]
            weapon_zoom_level = 0x7,
        }
        
        public enum e_periodic_function : short
        {
            
            [EditorMarkUpAttribute(displayName: "one")]
            one = 0x0,
            
            [EditorMarkUpAttribute(displayName: "zero")]
            zero = 0x1,
            
            [EditorMarkUpAttribute(displayName: "cosine")]
            cosine = 0x2,
            
            [EditorMarkUpAttribute(flags: EditorMarkUpFlags.Unknown1, displayName: "cosine (variable period")]
            cosine__variable_period = 0x3,
            
            [EditorMarkUpAttribute(displayName: "diagonal wave")]
            diagonal_wave = 0x4,
            
            [EditorMarkUpAttribute(flags: EditorMarkUpFlags.Unknown1, displayName: "diagonal wave (variable period")]
            diagonal_wave__variable_period = 0x5,
            
            [EditorMarkUpAttribute(displayName: "slide")]
            slide = 0x6,
            
            [EditorMarkUpAttribute(flags: EditorMarkUpFlags.Unknown1, displayName: "slide (variable period")]
            slide__variable_period = 0x7,
            
            [EditorMarkUpAttribute(displayName: "noise")]
            noise = 0x8,
            
            [EditorMarkUpAttribute(displayName: "jitter")]
            jitter = 0x9,
            
            [EditorMarkUpAttribute(displayName: "wander")]
            wander = 0xa,
            
            [EditorMarkUpAttribute(displayName: "spark")]
            spark = 0xb,
        }
    }
    #endregion
}