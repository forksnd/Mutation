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
    
    
    #region global_ui_multiplayer_level_block
    [TagBlockDefinitionAttribute(cacheFileSize: 3172, tagFileSize: 3180, alignment: 4, maxBlockCount: 50)]
    public class global_ui_multiplayer_level_block
    {
        
        [EditorMarkUpAttribute(displayName: "Map ID")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public int map_id;
        
        [EditorMarkUpAttribute(displayName: "Bitmap")]
        [TagReferenceAttribute("bitm")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference bitmap;
        
        [PaddingAttribute(PaddingType.Skip, 576)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [PaddingAttribute(PaddingType.Skip, 2304)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding1;
        
        [EditorMarkUpAttribute(displayName: "Path")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public String256 path;
        
        [EditorMarkUpAttribute(displayName: "Sort Order")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public int sort_order;
        
        [EditorMarkUpAttribute(displayName: "Flags")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public b_flags flags;
        
        [PaddingAttribute(PaddingType.Padding, 3)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding2;
        
        [EditorMarkUpAttribute(displayName: "Max Teams None")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte max_teams_none;
        
        [EditorMarkUpAttribute(displayName: "Max Teams CTF")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte max_teams_ctf;
        
        [EditorMarkUpAttribute(displayName: "Max Teams Slayer")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte max_teams_slayer;
        
        [EditorMarkUpAttribute(displayName: "Max Teams Oddball")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte max_teams_oddball;
        
        [EditorMarkUpAttribute(displayName: "Max Teams KOTH")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte max_teams_koth;
        
        [EditorMarkUpAttribute(displayName: "Max Teams Race")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte max_teams_race;
        
        [EditorMarkUpAttribute(displayName: "Max Teams Headhunter")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte max_teams_headhunter;
        
        [EditorMarkUpAttribute(displayName: "Max Teams Juggernaut")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte max_teams_juggernaut;
        
        [EditorMarkUpAttribute(displayName: "Max Teams Territories")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte max_teams_territories;
        
        [EditorMarkUpAttribute(displayName: "Max Teams Assault")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte max_teams_assault;
        
        [EditorMarkUpAttribute(displayName: "Max Teams Stub 10")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte max_teams_stub_10;
        
        [EditorMarkUpAttribute(displayName: "Max Teams Stub 11")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte max_teams_stub_11;
        
        [EditorMarkUpAttribute(displayName: "Max Teams Stub 12")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte max_teams_stub_12;
        
        [EditorMarkUpAttribute(displayName: "Max Teams Stub 13")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte max_teams_stub_13;
        
        [EditorMarkUpAttribute(displayName: "Max Teams Stub 14")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte max_teams_stub_14;
        
        [EditorMarkUpAttribute(displayName: "Max Teams Stub 15")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte max_teams_stub_15;
        
        [FlagsAttribute()]
        public enum b_flags : byte
        {
            
            [EditorMarkUpAttribute(displayName: "Unlockable")]
            unlockable = 0x1,
        }
    }
    #endregion
}
