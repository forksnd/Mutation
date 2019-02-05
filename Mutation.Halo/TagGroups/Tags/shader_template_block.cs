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
    
    
    [TagGroupDefinitionAttribute(cacheFileSize: 96, tagFileSize: 156, version: 1, groupTag: "stem", parentGroupTag: "", name: "shader_template", minimumVersion: EngineVersion.Halo2Xbox, maximumVersion: EngineVersion.Halo2Vista)]
    public class shader_template_block
    {
        
        [EditorMarkUpAttribute(displayName: "Documentation")]
        [TagDataAttribute(maxSize: 65535, alignment: 4, maxSizeString: "UNSIGNED_SHORT_MAX")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagData documentation;
        
        [EditorMarkUpAttribute(displayName: "Default Material Name")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public string_id default_material_name;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField0 = new Explanation(name: "FLAGS", explanation: "* Force Active Camo: Should be used with cautuion, as this causes a backbuffer co" +
    "py when this shader is rendered.\n* Water: ???.\n* Foliage: Used with lightmapped " +
    "foliage (two-sided lighting) shaders. It affects importing but not rendering.");
        
        [PaddingAttribute(PaddingType.Padding, 2)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [EditorMarkUpAttribute(displayName: "Flags")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public b_flags flags;
        
        [EditorMarkUpAttribute(displayName: "Properties")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<shader_template_property_block> properties;
        
        [EditorMarkUpAttribute(displayName: "Categories")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<shader_template_category_block> categories;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField1 = new Explanation(name: "LIGHT RESPONSE", explanation: "Not used anymore.");
        
        [EditorMarkUpAttribute(displayName: "Light Response")]
        [TagReferenceAttribute("slit")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference light_response;
        
        [EditorMarkUpAttribute(displayName: "LODs")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<shader_template_level_of_detail_block> lods;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<shader_template_runtime_external_light_response_index_block> _noNameField0;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<shader_template_runtime_external_light_response_index_block> _noNameField1;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField2 = new Explanation(name: "RECURSIVE RENDERING", explanation: "Really cool stuff.");
        
        [EditorMarkUpAttribute(displayName: "Aux 1 Shader")]
        [TagReferenceAttribute("shad")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference aux_1_shader;
        
        [EditorMarkUpAttribute(displayName: "Aux 1 Layer")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public e_aux_1_layer aux_1_layer;
        
        [PaddingAttribute(PaddingType.Padding, 2)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding1;
        
        [EditorMarkUpAttribute(displayName: "Aux 2 Shader")]
        [TagReferenceAttribute("shad")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference aux_2_shader;
        
        [EditorMarkUpAttribute(displayName: "Aux 2 Layer")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public e_aux_1_layer aux_2_layer;
        
        [PaddingAttribute(PaddingType.Padding, 2)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding2;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "Postprocess Definition")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<shader_template_postprocess_definition_new_block> postprocess_definition;
        
        [FlagsAttribute()]
        public enum b_flags : short
        {
            
            [EditorMarkUpAttribute(displayName: "Force Active Camo")]
            force_active_camo = 0x1,
            
            [EditorMarkUpAttribute(displayName: "Water")]
            water = 0x2,
            
            [EditorMarkUpAttribute(displayName: "Foliage")]
            foliage = 0x4,
            
            [EditorMarkUpAttribute(displayName: "Hide Standard Parameters")]
            hide_standard_parameters = 0x8,
        }
        
        public enum e_aux_1_layer : short
        {
            
            [EditorMarkUpAttribute(displayName: "texaccum")]
            texaccum = 0x0,
            
            [EditorMarkUpAttribute(displayName: "Environment Map")]
            environment_map = 0x1,
            
            [EditorMarkUpAttribute(displayName: "Self-Illumination")]
            self_illumination = 0x2,
            
            [EditorMarkUpAttribute(displayName: "Overlay")]
            overlay = 0x3,
            
            [EditorMarkUpAttribute(displayName: "Transparent")]
            transparent = 0x4,
            
            [EditorMarkUpAttribute(flags: EditorMarkUpFlags.Unknown1, displayName: "Lightmap (Indirect")]
            lightmap__indirect = 0x5,
            
            [EditorMarkUpAttribute(displayName: "Diffuse")]
            diffuse = 0x6,
            
            [EditorMarkUpAttribute(displayName: "Specular")]
            specular = 0x7,
            
            [EditorMarkUpAttribute(displayName: "Shadow Generate")]
            shadow_generate = 0x8,
            
            [EditorMarkUpAttribute(displayName: "Shadow Apply")]
            shadow_apply = 0x9,
            
            [EditorMarkUpAttribute(displayName: "Boom")]
            boom = 0xa,
            
            [EditorMarkUpAttribute(displayName: "Fog")]
            fog = 0xb,
            
            [EditorMarkUpAttribute(displayName: "Sh Prt")]
            sh_prt = 0xc,
            
            [EditorMarkUpAttribute(displayName: "Active Camo")]
            active_camo = 0xd,
            
            [EditorMarkUpAttribute(displayName: "Water Edge Blend")]
            water_edge_blend = 0xe,
            
            [EditorMarkUpAttribute(displayName: "Decal")]
            decal = 0xf,
            
            [EditorMarkUpAttribute(displayName: "Active Camo Stencil Modulate")]
            active_camo_stencil_modulate = 0x10,
            
            [EditorMarkUpAttribute(displayName: "Hologram")]
            hologram = 0x11,
            
            [EditorMarkUpAttribute(displayName: "Light Albedo")]
            light_albedo = 0x12,
        }
    }
    
    #region shader_template_property_block
    [TagBlockDefinitionAttribute(cacheFileSize: 8, tagFileSize: 8, alignment: 4, maxBlockCount: 14)]
    public class shader_template_property_block
    {
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.BlockName, displayName: "Property")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public e_property property;
        
        [PaddingAttribute(PaddingType.Padding, 2)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [EditorMarkUpAttribute(displayName: "Parameter Name")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public string_id parameter_name;
        
        public enum e_property : short
        {
            
            [EditorMarkUpAttribute(displayName: "Unused")]
            unused = 0x0,
            
            [EditorMarkUpAttribute(displayName: "Diffuse Map")]
            diffuse_map = 0x1,
            
            [EditorMarkUpAttribute(displayName: "Lightmap Emissive Map")]
            lightmap_emissive_map = 0x2,
            
            [EditorMarkUpAttribute(displayName: "Lightmap Emissive Color")]
            lightmap_emissive_color = 0x3,
            
            [EditorMarkUpAttribute(displayName: "Lightmap Emissive Power")]
            lightmap_emissive_power = 0x4,
            
            [EditorMarkUpAttribute(displayName: "Lightmap Resolution Scale")]
            lightmap_resolution_scale = 0x5,
            
            [EditorMarkUpAttribute(displayName: "Lightmap Half Life")]
            lightmap_half_life = 0x6,
            
            [EditorMarkUpAttribute(displayName: "Lightmap Diffuse Scale")]
            lightmap_diffuse_scale = 0x7,
            
            [EditorMarkUpAttribute(displayName: "Lightmap Alpha Test Map")]
            lightmap_alpha_test_map = 0x8,
            
            [EditorMarkUpAttribute(displayName: "Lightmap Translucent Map")]
            lightmap_translucent_map = 0x9,
            
            [EditorMarkUpAttribute(displayName: "Lightmap Translucent Color")]
            lightmap_translucent_color = 0xa,
            
            [EditorMarkUpAttribute(displayName: "Lightmap Translucent Alpha")]
            lightmap_translucent_alpha = 0xb,
            
            [EditorMarkUpAttribute(displayName: "Active Camo Map")]
            active_camo_map = 0xc,
            
            [EditorMarkUpAttribute(displayName: "Lightmap Foliage Scale")]
            lightmap_foliage_scale = 0xd,
        }
    }
    #endregion
    
    #region shader_template_runtime_external_light_response_index_block
    [TagBlockDefinitionAttribute(cacheFileSize: 4, tagFileSize: 4, alignment: 4, maxBlockCount: 65535)]
    public class shader_template_runtime_external_light_response_index_block
    {
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public int _noNameField0;
    }
    #endregion
    
    #region shader_template_postprocess_definition_new_block
    [TagBlockDefinitionAttribute(cacheFileSize: 40, tagFileSize: 40, alignment: 4, maxBlockCount: 1)]
    public class shader_template_postprocess_definition_new_block
    {
        
        [EditorMarkUpAttribute(displayName: "levels of detail")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<shader_template_postprocess_level_of_detail_new_block> levels_of_detail;
        
        [EditorMarkUpAttribute(displayName: "layers")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<tag_block_index_block> layers;
        
        [EditorMarkUpAttribute(displayName: "passes")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<shader_template_postprocess_pass_new_block> passes;
        
        [EditorMarkUpAttribute(displayName: "implementations")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<shader_template_postprocess_implementation_new_block> implementations;
        
        [EditorMarkUpAttribute(displayName: "remappings")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<shader_template_postprocess_remapping_new_block> remappings;
    }
    #endregion
    
    #region shader_template_postprocess_level_of_detail_new_block
    [TagBlockDefinitionAttribute(cacheFileSize: 10, tagFileSize: 10, alignment: 4, maxBlockCount: 1024)]
    public class shader_template_postprocess_level_of_detail_new_block
    {
        
        [EditorMarkUpAttribute(displayName: "layers")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block_index_struct_block layers;
        
        [EditorMarkUpAttribute(displayName: "available layers")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public int available_layers;
        
        [EditorMarkUpAttribute(displayName: "projected height percentage")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float projected_height_percentage;
    }
    #endregion
    
    #region shader_template_postprocess_pass_new_block
    [TagBlockDefinitionAttribute(cacheFileSize: 10, tagFileSize: 10, alignment: 4, maxBlockCount: 1024)]
    public class shader_template_postprocess_pass_new_block
    {
        
        [EditorMarkUpAttribute(displayName: "pass")]
        [TagReferenceAttribute("spas")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference pass;
        
        [EditorMarkUpAttribute(displayName: "implementations")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block_index_struct_block implementations;
    }
    #endregion
    
    #region shader_template_postprocess_implementation_new_block
    [TagBlockDefinitionAttribute(cacheFileSize: 6, tagFileSize: 6, alignment: 4, maxBlockCount: 1024)]
    public class shader_template_postprocess_implementation_new_block
    {
        
        [EditorMarkUpAttribute(displayName: "bitmaps")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block_index_struct_block bitmaps;
        
        [EditorMarkUpAttribute(displayName: "pixel constants")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block_index_struct_block pixel_constants;
        
        [EditorMarkUpAttribute(displayName: "vertex constants")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block_index_struct_block vertex_constants;
    }
    #endregion
    
    #region shader_template_postprocess_remapping_new_block
    [TagBlockDefinitionAttribute(cacheFileSize: 4, tagFileSize: 4, alignment: 4, maxBlockCount: 1024)]
    public class shader_template_postprocess_remapping_new_block
    {
        
        [PaddingAttribute(PaddingType.Skip, 3)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [EditorMarkUpAttribute(displayName: "source index")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte source_index;
    }
    #endregion
}