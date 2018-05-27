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
    
    
    [TagGroupDefinitionAttribute(cacheFileSize: 16, tagFileSize: 20, version: 1, groupTag: "MGS2", parentGroupTag: "", name: "light_volume", minimumVersion: EngineVersion.Halo2Xbox, maximumVersion: EngineVersion.Halo2Vista)]
    public class light_volume_block
    {
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField0 = new Explanation(name: "LIGHT VOLUME", explanation: @"Light volumes are rendered as a sequence of glowy sprites, just like in Metal Gear Solid 2. Each instance of the light volume is rendered separately; this allows, for example, a narrow bright white volume to be overlaid on top of a fuzzy wide colored volume, or anything else you want!");
        
        [PaddingAttribute(PaddingType.Useless, 64)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [EditorMarkUpAttribute(displayName: "falloff distance from camera", unitsSpecifier: "world units")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float falloff_distance_from_camera;
        
        [EditorMarkUpAttribute(displayName: "cutoff distance from camera", unitsSpecifier: "world units")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float cutoff_distance_from_camera;
        
        [PaddingAttribute(PaddingType.Useless, 32)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding1;
        
        [EditorMarkUpAttribute(displayName: "volumes")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<light_volume_volume_block> volumes;
    }
    
    #region light_volume_volume_block
    [TagBlockDefinitionAttribute(cacheFileSize: 152, tagFileSize: 152, alignment: 4, maxBlockCount: 16)]
    public class light_volume_volume_block
    {
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField0 = new Explanation(name: "VOLUME", explanation: @"If no bitmap is selected, the default glow bitmap will be used. Sprite count controls how many sprites are used to render this volume. Using more sprites will result in a smoother and brighter effect, at a slight performance penalty. Don't touch the flags unless you know what you're doing (they should be off by default).

Be careful with the 'fuzzy' flag! It should be used on very wide light volumes to make them blend smoothly into solid geometry rather than ""cutting"" into the zbuffer. Using this feature will make light volumes several times slower when they fill a large portion of the screen.");
        
        [EditorMarkUpAttribute(displayName: "flags")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public b_flags flags;
        
        [PaddingAttribute(PaddingType.Useless, 16)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [EditorMarkUpAttribute(displayName: "bitmap")]
        [TagReferenceAttribute("bitm")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference bitmap;
        
        [EditorMarkUpAttribute(displayName: "sprite count", unitsSpecifier: "[4,256]")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public int sprite_count;
        
        [PaddingAttribute(PaddingType.Useless, 32)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding1;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField1 = new Explanation(name: "OFFSET", explanation: @"This function controls the offset along the projected forward axis of the light volume. The output range of this function is the distance in WORLD UNITS from the origin where the first and last sprite are rendered. The input to this function is the fractional value (from 0 to 1) along the projected axis. Using a transition function such as ""late"" will result in more sprites being bunched up towards the origin and spaced further apart near the end.

Note that this and other functions in this tag have a range-input, which is controlled by the output of the FACING function below.");
        
        [EditorMarkUpAttribute(displayName: "offset function")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public scalar_function_struct_block offset_function;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField2 = new Explanation(name: "RADIUS", explanation: "This function controls the radius in WORLD UNITS of each sprite along the project" +
    "ed forward axis. Using a smaller min value and a larger max value results in a l" +
    "ight volume that looks like a cone.");
        
        [EditorMarkUpAttribute(displayName: "radius function")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public scalar_function_struct_block radius_function;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField3 = new Explanation(name: "BRIGHTNESS", explanation: @"This function controls the overall brightness (in [0,1]) of each sprite along the projected forward axis. Note that since the sprites are additive, they will be brighter in areas where they overlap more even if this function is constant, so it may be useful to use the brightness function to compensate for this.");
        
        [EditorMarkUpAttribute(displayName: "brightness function")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public scalar_function_struct_block brightness_function;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField4 = new Explanation(name: "COLOR", explanation: "This function controls the color of each sprite along the projected forward axis." +
    " Color is multiplied by brightness to produce the final color that will be appli" +
    "ed to the sprite.");
        
        [EditorMarkUpAttribute(displayName: "color function")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public color_function_struct_block color_function;
        
        [PaddingAttribute(PaddingType.Useless, 64)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding2;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField5 = new Explanation(name: "FACING", explanation: @"The input to this function is the facing angle between the light volume and the camera. Zero represents facing towards (parallel) or away from the camera and 1.0 represents facing perpendicular to the camera.

The output of this function is fed into the range-input of the functions above.");
        
        [EditorMarkUpAttribute(displayName: "facing function")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public scalar_function_struct_block facing_function;
        
        [PaddingAttribute(PaddingType.Useless, 64)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding3;
        
        [EditorMarkUpAttribute(displayName: "aspect")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<light_volume_aspect_block> aspect;
        
        [PaddingAttribute(PaddingType.Useless, 64)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding4;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField6 = new Explanation(name: "POSTPROCESS CONTROL", explanation: "ADVANCED STUFF!! Don\'t change these values!!");
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "radius frac min", unitsSpecifier: "[0.00390625, 1.0]")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float radius_frac_min;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly | EditorMarkUpFlags.Advanced, displayName: "DEPRECATED x-step exponent", unitsSpecifier: "[0.5, 0.875]")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float deprecated___x_step_exponent;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly | EditorMarkUpFlags.Advanced, displayName: "DEPRECATED x-buffer length", unitsSpecifier: "[32, 512]")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public int deprecated___x_buffer_length;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "x-buffer spacing", unitsSpecifier: "[1, 256]")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public int x_buffer_spacing;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "x-buffer min iterations", unitsSpecifier: "[1, 256]")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public int x_buffer_min_iterations;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "x-buffer max iterations", unitsSpecifier: "[1, 256]")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public int x_buffer_max_iterations;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "x-delta max error", unitsSpecifier: "[0.001, 0.1]")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float x_delta_max_error;
        
        [PaddingAttribute(PaddingType.Useless, 48)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding5;
        
        [PaddingAttribute(PaddingType.Skip, 4)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding6;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<light_volume_runtime_offset_block> _noNameField0;
        
        [PaddingAttribute(PaddingType.Skip, 48)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding7;
        
        [FlagsAttribute()]
        public enum b_flags : uint
        {
            
            [EditorMarkUpAttribute(displayName: "force linear radius function")]
            force_linear_radius_function = 0x1,
            
            [EditorMarkUpAttribute(displayName: "force linear offset")]
            force_linear_offset = 0x2,
            
            [EditorMarkUpAttribute(displayName: "force differential evaluation")]
            force_differential_evaluation = 0x4,
            
            [EditorMarkUpAttribute(displayName: "fuzzy")]
            fuzzy = 0x8,
            
            [EditorMarkUpAttribute(displayName: "not scaled by event duration")]
            not_scaled_by_event_duration = 0x10,
            
            [EditorMarkUpAttribute(displayName: "scaled by marker")]
            scaled_by_marker = 0x20,
        }
    }
    #endregion
    
    #region light_volume_aspect_block
    [TagBlockDefinitionAttribute(cacheFileSize: 28, tagFileSize: 28, alignment: 4, maxBlockCount: 1)]
    public class light_volume_aspect_block
    {
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField0 = new Explanation(name: "SCALE FACTORS", explanation: @"These function control the screenspace aspect ratio of each sprite relative to the projected forward axis. Note that there is no range-input to these functions, because it would not make sense to stretch sprites when the light volume is facing directly towards or away from the camera (which way would we stretch them?)");
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField1 = new Explanation(name: "ALONG-AXIS SCALE", explanation: "Values higher than 1 along the axis will cause sprites to elongate and overlap mo" +
    "re regardless of the orientation of the light volume, whereas values lower than " +
    "1 will cause sprite separation.");
        
        [EditorMarkUpAttribute(displayName: "along axis")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public scalar_function_struct_block along_axis;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField2 = new Explanation(name: "AWAY-FROM-AXIS SCALE", explanation: "Values higher than 1 away from the axis will cause the light volume to appear thi" +
    "cker.");
        
        [EditorMarkUpAttribute(displayName: "away from axis")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public scalar_function_struct_block away_from_axis;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField3 = new Explanation(name: "PARALLEL SCALE", explanation: @"When the light volume is viewed directly towards (parallel) or away from the camera, the scale factors above are interpolated towards this constant value. The threshold angle controls when the light volume is considered to be 100% parallel for these computations. The exponent controls how quickly the transition from using the perpendicular scale factors to using the parallel scale factor happens, e.g.:

* exponent=0.0 -> perpendicular scale factors will always be used unless below threshold angle
* exponent=0.1 -> transition quickly as viewing angle becomes perpendicular
* exponent=1.0 -> transition smoothly between perpendicular and parallel
* exponent=9.0 -> transition quickly as viewing angle becomes parallel");
        
        [EditorMarkUpAttribute(displayName: "parallel scale")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float parallel_scale;
        
        [EditorMarkUpAttribute(displayName: "parallel threshold angle", unitsSpecifier: "degrees")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float parallel_threshold_angle;
        
        [EditorMarkUpAttribute(displayName: "parallel exponent")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float parallel_exponent;
    }
    #endregion
    
    #region light_volume_runtime_offset_block
    [TagBlockDefinitionAttribute(cacheFileSize: 8, tagFileSize: 8, alignment: 4, maxBlockCount: 256)]
    public class light_volume_runtime_offset_block
    {
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealVector2d _noNameField0;
    }
    #endregion
}
