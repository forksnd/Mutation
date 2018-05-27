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
    
    
    #region structure_bsp_sound_environment_palette_block
    [TagBlockDefinitionAttribute(cacheFileSize: 72, tagFileSize: 80, alignment: 4, maxBlockCount: 64)]
    public class structure_bsp_sound_environment_palette_block
    {
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.BlockName, displayName: "Name")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public String32 name;
        
        [EditorMarkUpAttribute(displayName: "Sound Environment")]
        [TagReferenceAttribute("snde")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference sound_environment;
        
        [EditorMarkUpAttribute(displayName: "Cutoff Distance")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float cutoff_distance;
        
        [EditorMarkUpAttribute(displayName: "Interpolation Speed", unitsSpecifier: "1/sec")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float interpolation_speed;
        
        [PaddingAttribute(PaddingType.Padding, 24)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
    }
    #endregion
}
