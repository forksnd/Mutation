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
    
    
    #region shader_gpu_state_reference_struct_block
    [TagBlockDefinitionAttribute(cacheFileSize: 14, tagFileSize: 14, alignment: 4, maxBlockCount: 1)]
    public class shader_gpu_state_reference_struct_block
    {
        
        [EditorMarkUpAttribute(displayName: "render states")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block_index_struct_block render_states;
        
        [EditorMarkUpAttribute(displayName: "texture stage states")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block_index_struct_block texture_stage_states;
        
        [EditorMarkUpAttribute(displayName: "render state parameters")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block_index_struct_block render_state_parameters;
        
        [EditorMarkUpAttribute(displayName: "texture stage parameters")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block_index_struct_block texture_stage_parameters;
        
        [EditorMarkUpAttribute(displayName: "textures")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block_index_struct_block textures;
        
        [EditorMarkUpAttribute(displayName: "Vn Constants")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block_index_struct_block vn_constants;
        
        [EditorMarkUpAttribute(displayName: "Cn Constants")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block_index_struct_block cn_constants;
    }
    #endregion
}
