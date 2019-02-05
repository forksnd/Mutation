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
    
    
    #region sound_response_definition_block
    [TagBlockDefinitionAttribute(cacheFileSize: 80, tagFileSize: 152, alignment: 4, maxBlockCount: 10)]
    public class sound_response_definition_block
    {
        
        [EditorMarkUpAttribute(displayName: "sound flags")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public b_sound_flags sound_flags;
        
        [PaddingAttribute(PaddingType.Padding, 2)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.BlockName, displayName: "english sound")]
        [TagReferenceAttribute("snd!")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference english_sound;
        
        [EditorMarkUpAttribute(displayName: "extra sounds")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public sound_response_extra_sounds_struct_block extra_sounds;
        
        [EditorMarkUpAttribute(displayName: "probability")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float probability;
        
        [FlagsAttribute()]
        public enum b_sound_flags : short
        {
            
            [EditorMarkUpAttribute(displayName: "announcer sound")]
            announcer_sound = 0x1,
        }
    }
    #endregion
}