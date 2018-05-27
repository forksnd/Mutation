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
    
    
    #region shader_template_level_of_detail_block
    [TagBlockDefinitionAttribute(cacheFileSize: 12, tagFileSize: 16, alignment: 4, maxBlockCount: 8)]
    public class shader_template_level_of_detail_block
    {
        
        [EditorMarkUpAttribute(displayName: "Projected Diameter", unitsSpecifier: "pixels")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float projected_diameter;
        
        [EditorMarkUpAttribute(displayName: "Pass")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<shader_template_pass_reference_block> pass;
    }
    #endregion
    
    #region shader_template_pass_reference_block
    [TagBlockDefinitionAttribute(cacheFileSize: 24, tagFileSize: 24, alignment: 4, maxBlockCount: 16)]
    public class shader_template_pass_reference_block
    {
        
        [EditorMarkUpAttribute(displayName: "Layer")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public e_layer layer;
        
        [PaddingAttribute(PaddingType.Padding, 2)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.BlockName, displayName: "Pass")]
        [TagReferenceAttribute("spas")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference pass;
        
        [PaddingAttribute(PaddingType.Padding, 12)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding1;
        
        public enum e_layer : short
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
    #endregion
}
