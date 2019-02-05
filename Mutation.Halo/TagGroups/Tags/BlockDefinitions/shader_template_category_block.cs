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
    
    
    #region shader_template_category_block
    [TagBlockDefinitionAttribute(cacheFileSize: 12, tagFileSize: 16, alignment: 4, maxBlockCount: 16)]
    public class shader_template_category_block
    {
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.BlockName, displayName: "Name")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public string_id name;
        
        [EditorMarkUpAttribute(displayName: "Parameters")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<shader_template_parameter_block> parameters;
    }
    #endregion
    
    #region shader_template_parameter_block
    [TagBlockDefinitionAttribute(cacheFileSize: 52, tagFileSize: 52, alignment: 4, maxBlockCount: 64)]
    public class shader_template_parameter_block
    {
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.BlockName, displayName: "Name")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public string_id name;
        
        [EditorMarkUpAttribute(displayName: "Explanation")]
        [TagDataAttribute(maxSize: 65535, alignment: 4, maxSizeString: "UNSIGNED_SHORT_MAX")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagData explanation;
        
        [EditorMarkUpAttribute(displayName: "Type")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public e_type type;
        
        [EditorMarkUpAttribute(displayName: "Flags")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public b_flags flags;
        
        [EditorMarkUpAttribute(displayName: "Default Bitmap")]
        [TagReferenceAttribute("bitm")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference default_bitmap;
        
        [EditorMarkUpAttribute(displayName: "Default Const Value")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float default_const_value;
        
        [EditorMarkUpAttribute(displayName: "Default Const Color")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealColorRgb default_const_color;
        
        [EditorMarkUpAttribute(displayName: "Bitmap Type")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public e_bitmap_type bitmap_type;
        
        [PaddingAttribute(PaddingType.Padding, 2)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [EditorMarkUpAttribute(displayName: "Bitmap Animation Flags")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public b_bitmap_animation_flags bitmap_animation_flags;
        
        [PaddingAttribute(PaddingType.Padding, 2)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding1;
        
        [EditorMarkUpAttribute(displayName: "Bitmap Scale")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float bitmap_scale;
        
        public enum e_type : short
        {
            
            [EditorMarkUpAttribute(displayName: "Bitmap")]
            bitmap = 0x0,
            
            [EditorMarkUpAttribute(displayName: "Value")]
            value = 0x1,
            
            [EditorMarkUpAttribute(displayName: "Color")]
            color = 0x2,
            
            [EditorMarkUpAttribute(displayName: "Switch")]
            @switch = 0x3,
        }
        
        [FlagsAttribute()]
        public enum b_flags : short
        {
            
            [EditorMarkUpAttribute(displayName: "Animated")]
            animated = 0x1,
            
            [EditorMarkUpAttribute(displayName: "Hide Bitmap Reference")]
            hide_bitmap_reference = 0x2,
        }
        
        public enum e_bitmap_type : short
        {
            
            [EditorMarkUpAttribute(displayName: "2D")]
            _2d = 0x0,
            
            [EditorMarkUpAttribute(displayName: "3D")]
            _3d = 0x1,
            
            [EditorMarkUpAttribute(displayName: "Cube Map")]
            cube_map = 0x2,
        }
        
        [FlagsAttribute()]
        public enum b_bitmap_animation_flags : short
        {
            
            [EditorMarkUpAttribute(displayName: "Scale Uniform")]
            scale_uniform = 0x1,
            
            [EditorMarkUpAttribute(displayName: "Scale")]
            scale = 0x2,
            
            [EditorMarkUpAttribute(displayName: "Translation")]
            translation = 0x4,
            
            [EditorMarkUpAttribute(displayName: "Rotation")]
            rotation = 0x8,
            
            [EditorMarkUpAttribute(displayName: "Index")]
            index = 0x10,
        }
    }
    #endregion
}