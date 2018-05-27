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
    
    
    #region ui_model_scene_reference_block
    [TagBlockDefinitionAttribute(cacheFileSize: 76, tagFileSize: 84, alignment: 4, maxBlockCount: 32)]
    public class ui_model_scene_reference_block
    {
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField0 = new Explanation(name: "NOTE on coordinate systems", explanation: @"Halo y-axis=ui z-axis, and Halo z-axis=ui y-axis.
As a convention, let's always place objects in the ui scenario such that
they are facing in the '-y' direction, and the camera such that is is
facing the '+y' direction. This way the ui animation for models (which
gets applied to the camera) will always be consisitent.");
        
        [EditorMarkUpAttribute(displayName: "flags")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public b_flags flags;
        
        [EditorMarkUpAttribute(displayName: "animation index")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public e_animation_index animation_index;
        
        [EditorMarkUpAttribute(displayName: "intro animation delay milliseconds")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short intro_animation_delay_milliseconds;
        
        [EditorMarkUpAttribute(displayName: "render depth bias")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short render_depth_bias;
        
        [PaddingAttribute(PaddingType.Padding, 2)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [EditorMarkUpAttribute(displayName: "objects")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<ui_object_reference_block> objects;
        
        [EditorMarkUpAttribute(displayName: "lights")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<ui_light_reference_block> lights;
        
        [EditorMarkUpAttribute(displayName: "animation scale factor")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealVector3d animation_scale_factor;
        
        [EditorMarkUpAttribute(displayName: "camera position")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealPoint3d camera_position;
        
        [PaddingAttribute(PaddingType.Useless, 24)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding1;
        
        [EditorMarkUpAttribute(displayName: "fov degress")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float fov_degress;
        
        [EditorMarkUpAttribute(displayName: "ui viewport")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Rectangle2d ui_viewport;
        
        [EditorMarkUpAttribute(displayName: "UNUSED intro anim")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public string_id unused_intro_anim;
        
        [EditorMarkUpAttribute(displayName: "UNUSED outro anim")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public string_id unused_outro_anim;
        
        [EditorMarkUpAttribute(displayName: "UNUSED ambient anim")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public string_id unused_ambient_anim;
        
        [FlagsAttribute()]
        public enum b_flags : uint
        {
            
            [EditorMarkUpAttribute(displayName: "unused")]
            unused = 0x1,
        }
        
        public enum e_animation_index : short
        {
            
            [EditorMarkUpAttribute(displayName: "NONE")]
            none = 0x0,
            
            [EditorMarkUpAttribute(displayName: "00")]
            _00 = 0x1,
            
            [EditorMarkUpAttribute(displayName: "01")]
            _01 = 0x2,
            
            [EditorMarkUpAttribute(displayName: "02")]
            _02 = 0x3,
            
            [EditorMarkUpAttribute(displayName: "03")]
            _03 = 0x4,
            
            [EditorMarkUpAttribute(displayName: "04")]
            _04 = 0x5,
            
            [EditorMarkUpAttribute(displayName: "05")]
            _05 = 0x6,
            
            [EditorMarkUpAttribute(displayName: "06")]
            _06 = 0x7,
            
            [EditorMarkUpAttribute(displayName: "07")]
            _07 = 0x8,
            
            [EditorMarkUpAttribute(displayName: "08")]
            _08 = 0x9,
            
            [EditorMarkUpAttribute(displayName: "09")]
            _09 = 0xa,
            
            [EditorMarkUpAttribute(displayName: "10")]
            _10 = 0xb,
            
            [EditorMarkUpAttribute(displayName: "11")]
            _11 = 0xc,
            
            [EditorMarkUpAttribute(displayName: "12")]
            _12 = 0xd,
            
            [EditorMarkUpAttribute(displayName: "13")]
            _13 = 0xe,
            
            [EditorMarkUpAttribute(displayName: "14")]
            _14 = 0xf,
            
            [EditorMarkUpAttribute(displayName: "15")]
            _15 = 0x10,
            
            [EditorMarkUpAttribute(displayName: "16")]
            _16 = 0x11,
            
            [EditorMarkUpAttribute(displayName: "17")]
            _17 = 0x12,
            
            [EditorMarkUpAttribute(displayName: "18")]
            _18 = 0x13,
            
            [EditorMarkUpAttribute(displayName: "19")]
            _19 = 0x14,
            
            [EditorMarkUpAttribute(displayName: "20")]
            _20 = 0x15,
            
            [EditorMarkUpAttribute(displayName: "21")]
            _21 = 0x16,
            
            [EditorMarkUpAttribute(displayName: "22")]
            _22 = 0x17,
            
            [EditorMarkUpAttribute(displayName: "23")]
            _23 = 0x18,
            
            [EditorMarkUpAttribute(displayName: "24")]
            _24 = 0x19,
            
            [EditorMarkUpAttribute(displayName: "25")]
            _25 = 0x1a,
            
            [EditorMarkUpAttribute(displayName: "26")]
            _26 = 0x1b,
            
            [EditorMarkUpAttribute(displayName: "27")]
            _27 = 0x1c,
            
            [EditorMarkUpAttribute(displayName: "28")]
            _28 = 0x1d,
            
            [EditorMarkUpAttribute(displayName: "29")]
            _29 = 0x1e,
            
            [EditorMarkUpAttribute(displayName: "30")]
            _30 = 0x1f,
            
            [EditorMarkUpAttribute(displayName: "31")]
            _31 = 0x20,
            
            [EditorMarkUpAttribute(displayName: "32")]
            _32 = 0x21,
            
            [EditorMarkUpAttribute(displayName: "33")]
            _33 = 0x22,
            
            [EditorMarkUpAttribute(displayName: "34")]
            _34 = 0x23,
            
            [EditorMarkUpAttribute(displayName: "35")]
            _35 = 0x24,
            
            [EditorMarkUpAttribute(displayName: "36")]
            _36 = 0x25,
            
            [EditorMarkUpAttribute(displayName: "37")]
            _37 = 0x26,
            
            [EditorMarkUpAttribute(displayName: "38")]
            _38 = 0x27,
            
            [EditorMarkUpAttribute(displayName: "39")]
            _39 = 0x28,
            
            [EditorMarkUpAttribute(displayName: "40")]
            _40 = 0x29,
            
            [EditorMarkUpAttribute(displayName: "41")]
            _41 = 0x2a,
            
            [EditorMarkUpAttribute(displayName: "42")]
            _42 = 0x2b,
            
            [EditorMarkUpAttribute(displayName: "43")]
            _43 = 0x2c,
            
            [EditorMarkUpAttribute(displayName: "44")]
            _44 = 0x2d,
            
            [EditorMarkUpAttribute(displayName: "45")]
            _45 = 0x2e,
            
            [EditorMarkUpAttribute(displayName: "46")]
            _46 = 0x2f,
            
            [EditorMarkUpAttribute(displayName: "47")]
            _47 = 0x30,
            
            [EditorMarkUpAttribute(displayName: "48")]
            _48 = 0x31,
            
            [EditorMarkUpAttribute(displayName: "49")]
            _49 = 0x32,
            
            [EditorMarkUpAttribute(displayName: "50")]
            _50 = 0x33,
            
            [EditorMarkUpAttribute(displayName: "51")]
            _51 = 0x34,
            
            [EditorMarkUpAttribute(displayName: "52")]
            _52 = 0x35,
            
            [EditorMarkUpAttribute(displayName: "53")]
            _53 = 0x36,
            
            [EditorMarkUpAttribute(displayName: "54")]
            _54 = 0x37,
            
            [EditorMarkUpAttribute(displayName: "55")]
            _55 = 0x38,
            
            [EditorMarkUpAttribute(displayName: "56")]
            _56 = 0x39,
            
            [EditorMarkUpAttribute(displayName: "57")]
            _57 = 0x3a,
            
            [EditorMarkUpAttribute(displayName: "58")]
            _58 = 0x3b,
            
            [EditorMarkUpAttribute(displayName: "59")]
            _59 = 0x3c,
            
            [EditorMarkUpAttribute(displayName: "60")]
            _60 = 0x3d,
            
            [EditorMarkUpAttribute(displayName: "61")]
            _61 = 0x3e,
            
            [EditorMarkUpAttribute(displayName: "62")]
            _62 = 0x3f,
            
            [EditorMarkUpAttribute(displayName: "63")]
            _63 = 0x40,
        }
    }
    #endregion
    
    #region ui_object_reference_block
    [TagBlockDefinitionAttribute(cacheFileSize: 32, tagFileSize: 32, alignment: 4, maxBlockCount: 32)]
    public class ui_object_reference_block
    {
        
        [EditorMarkUpAttribute(displayName: "name")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public String32 name;
    }
    #endregion
    
    #region ui_light_reference_block
    [TagBlockDefinitionAttribute(cacheFileSize: 32, tagFileSize: 32, alignment: 4, maxBlockCount: 8)]
    public class ui_light_reference_block
    {
        
        [EditorMarkUpAttribute(displayName: "name")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public String32 name;
    }
    #endregion
}
