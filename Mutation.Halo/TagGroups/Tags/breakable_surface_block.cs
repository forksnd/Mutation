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
    
    
    [TagGroupDefinitionAttribute(cacheFileSize: 32, tagFileSize: 52, version: 0, groupTag: "bsdt", parentGroupTag: "", name: "breakable_surface", minimumVersion: EngineVersion.Halo2Xbox, maximumVersion: EngineVersion.Halo2Vista)]
    public class breakable_surface_block
    {
        
        [EditorMarkUpAttribute(displayName: "maximum vitality")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float maximum_vitality;
        
        [EditorMarkUpAttribute(displayName: "effect")]
        [TagReferenceAttribute("effe")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference effect;
        
        [EditorMarkUpAttribute(displayName: "sound")]
        [TagReferenceAttribute("snd!")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference sound;
        
        [EditorMarkUpAttribute(displayName: "particle effects")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<particle_system_definition_block_new> particle_effects;
        
        [EditorMarkUpAttribute(displayName: "particle density")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float particle_density;
    }
}
