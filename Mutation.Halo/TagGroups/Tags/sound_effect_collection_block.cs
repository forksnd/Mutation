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
    
    
    [TagGroupDefinitionAttribute(cacheFileSize: 8, tagFileSize: 12, version: 1, groupTag: "sfx+", parentGroupTag: "", name: "sound_effect_collection", minimumVersion: EngineVersion.Halo2Xbox, maximumVersion: EngineVersion.Halo2Vista)]
    public class sound_effect_collection_block
    {
        
        [EditorMarkUpAttribute(displayName: "sound effects")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<platform_sound_playback_block> sound_effects;
    }
    
    #region platform_sound_playback_block
    [TagBlockDefinitionAttribute(cacheFileSize: 56, tagFileSize: 56, alignment: 4, maxBlockCount: 128)]
    public class platform_sound_playback_block
    {
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.BlockName, displayName: "name")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public string_id name;
        
        [EditorMarkUpAttribute(displayName: "playback")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public platform_sound_playback_struct_block playback;
    }
    #endregion
    
    #region platform_sound_playback_struct_block
    [TagBlockDefinitionAttribute(cacheFileSize: 52, tagFileSize: 52, alignment: 4, maxBlockCount: 1)]
    public class platform_sound_playback_struct_block
    {
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<platform_sound_override_mixbins_block> _noNameField0;
        
        [EditorMarkUpAttribute(displayName: "flags")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public b_flags flags;
        
        [PaddingAttribute(PaddingType.Padding, 8)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [EditorMarkUpAttribute(displayName: "filter")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<platform_sound_filter_block> filter;
        
        [EditorMarkUpAttribute(displayName: "pitch lfo")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<platform_sound_pitch_lfo_block> pitch_lfo;
        
        [EditorMarkUpAttribute(displayName: "filter lfo")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<platform_sound_filter_lfo_block> filter_lfo;
        
        [EditorMarkUpAttribute(displayName: "sound effect")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<sound_effect_playback_block> sound_effect;
        
        [FlagsAttribute()]
        public enum b_flags : uint
        {
            
            [EditorMarkUpAttribute(displayName: "use 3d radio hack")]
            use_3d_radio_hack = 0x1,
        }
    }
    #endregion
}