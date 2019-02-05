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
    
    
    [TagGroupDefinitionAttribute(cacheFileSize: 8, tagFileSize: 12, version: 1, groupTag: "gldf", parentGroupTag: "", name: "chocolate_mountain", minimumVersion: EngineVersion.Halo2Xbox, maximumVersion: EngineVersion.Halo2Vista)]
    public class chocolate_mountain_block
    {
        
        [EditorMarkUpAttribute(displayName: "lighting variables")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<lighting_variables_block> lighting_variables;
    }
    
    #region lighting_variables_block
    [TagBlockDefinitionAttribute(cacheFileSize: 144, tagFileSize: 144, alignment: 4, maxBlockCount: 13)]
    public class lighting_variables_block
    {
        
        [EditorMarkUpAttribute(displayName: "object affected")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public b_object_affected object_affected;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField0 = new Explanation(name: "Global lightmap sample");
        
        [EditorMarkUpAttribute(displayName: "Lightmap brightness offset")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float lightmap_brightness_offset;
        
        [EditorMarkUpAttribute(displayName: "primary light")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public primary_light_struct_block primary_light;
        
        [EditorMarkUpAttribute(displayName: "secondary light")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public secondary_light_struct_block secondary_light;
        
        [EditorMarkUpAttribute(displayName: "ambient light")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public ambient_light_struct_block ambient_light;
        
        [EditorMarkUpAttribute(displayName: "lightmap shadows")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public lightmap_shadows_struct_block lightmap_shadows;
        
        [FlagsAttribute()]
        public enum b_object_affected : uint
        {
            
            [EditorMarkUpAttribute(displayName: "all")]
            all = 0x1,
            
            [EditorMarkUpAttribute(displayName: "biped")]
            biped = 0x2,
            
            [EditorMarkUpAttribute(displayName: "vehicle")]
            vehicle = 0x4,
            
            [EditorMarkUpAttribute(displayName: "weapon")]
            weapon = 0x8,
            
            [EditorMarkUpAttribute(displayName: "equipment")]
            equipment = 0x10,
            
            [EditorMarkUpAttribute(displayName: "garbage")]
            garbage = 0x20,
            
            [EditorMarkUpAttribute(displayName: "projectile")]
            projectile = 0x40,
            
            [EditorMarkUpAttribute(displayName: "scenery")]
            scenery = 0x80,
            
            [EditorMarkUpAttribute(displayName: "machine")]
            machine = 0x100,
            
            [EditorMarkUpAttribute(displayName: "control")]
            control = 0x200,
            
            [EditorMarkUpAttribute(displayName: "light fixture")]
            light_fixture = 0x400,
            
            [EditorMarkUpAttribute(displayName: "sound scenery")]
            sound_scenery = 0x800,
            
            [EditorMarkUpAttribute(displayName: "crate")]
            crate = 0x1000,
            
            [EditorMarkUpAttribute(displayName: "creature")]
            creature = 0x2000,
        }
    }
    #endregion
    
    #region primary_light_struct_block
    [TagBlockDefinitionAttribute(cacheFileSize: 36, tagFileSize: 36, alignment: 4, maxBlockCount: 1)]
    public class primary_light_struct_block
    {
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField0 = new Explanation(name: "Primary light");
        
        [EditorMarkUpAttribute(displayName: "Min lightmap color")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealColorRgb min_lightmap_color;
        
        [EditorMarkUpAttribute(displayName: "Max lightmap color")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealColorRgb max_lightmap_color;
        
        [EditorMarkUpAttribute(displayName: "exclusion angle from up", tooltipText: "degrees from up the direct light cannot be")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float exclusion_angle_from_up;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField1 = new Explanation(name: "Primary light function", explanation: "input: accuracy, output: primary light scale");
        
        [EditorMarkUpAttribute(displayName: "function")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public mapping_function_block function1;
    }
    #endregion
    
    #region secondary_light_struct_block
    [TagBlockDefinitionAttribute(cacheFileSize: 60, tagFileSize: 60, alignment: 4, maxBlockCount: 1)]
    public class secondary_light_struct_block
    {
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField0 = new Explanation(name: "Secondary light");
        
        [EditorMarkUpAttribute(displayName: "Min lightmap color")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealColorRgb min_lightmap_color;
        
        [EditorMarkUpAttribute(displayName: "Max lightmap color")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealColorRgb max_lightmap_color;
        
        [EditorMarkUpAttribute(displayName: "Min diffuse sample")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealColorRgb min_diffuse_sample;
        
        [EditorMarkUpAttribute(displayName: "Max diffuse sample")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealColorRgb max_diffuse_sample;
        
        [EditorMarkUpAttribute(displayName: "z axis rotation", tooltipText: "degrees")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float z_axis_rotation;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField1 = new Explanation(name: "Secondary light function", explanation: "input: accuracy, output: secondary light scale");
        
        [EditorMarkUpAttribute(displayName: "function")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public mapping_function_block function1;
    }
    #endregion
    
    #region ambient_light_struct_block
    [TagBlockDefinitionAttribute(cacheFileSize: 32, tagFileSize: 32, alignment: 4, maxBlockCount: 1)]
    public class ambient_light_struct_block
    {
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField0 = new Explanation(name: "Ambient light");
        
        [EditorMarkUpAttribute(displayName: "Min lightmap sample")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealColorRgb min_lightmap_sample;
        
        [EditorMarkUpAttribute(displayName: "Max lightmap sample")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealColorRgb max_lightmap_sample;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField1 = new Explanation(name: "Ambient light function", explanation: "Ambient light scale. (left side min brightness, right side max brightness). Befor" +
    "e this scale it determines a global ambient scale, which added to either light w" +
    "ill total ~1.0 scale. Then this scale modifies that.");
        
        [EditorMarkUpAttribute(displayName: "function")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public mapping_function_block function1;
    }
    #endregion
    
    #region lightmap_shadows_struct_block
    [TagBlockDefinitionAttribute(cacheFileSize: 8, tagFileSize: 8, alignment: 4, maxBlockCount: 1)]
    public class lightmap_shadows_struct_block
    {
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField0 = new Explanation(name: "Lightmap shadows", explanation: "Shadows generated by the lightmaps get direction from lightmap primary incoming l" +
    "ight direction and darken based on how accurate that light is fed into the funct" +
    "ion below");
        
        [EditorMarkUpAttribute(displayName: "function 1")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public mapping_function_block function_1;
    }
    #endregion
}