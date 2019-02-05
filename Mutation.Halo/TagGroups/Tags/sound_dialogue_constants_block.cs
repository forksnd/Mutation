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
    
    
    [TagGroupDefinitionAttribute(cacheFileSize: 40, tagFileSize: 40, version: 1, groupTag: "spk!", parentGroupTag: "", name: "sound_dialogue_constants", minimumVersion: EngineVersion.Halo2Xbox, maximumVersion: EngineVersion.Halo2Vista)]
    public class sound_dialogue_constants_block
    {
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField0 = new Explanation(name: "named playing fractions", explanation: "these values correspond to the named play fractions in the dialogue editor (It\'s " +
    "really skip fractions, but who cares?)");
        
        [EditorMarkUpAttribute(displayName: "almost never")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float almost_never;
        
        [EditorMarkUpAttribute(displayName: "rarely")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float rarely;
        
        [EditorMarkUpAttribute(displayName: "somewhat")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float somewhat;
        
        [EditorMarkUpAttribute(displayName: "often")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float often;
        
        [PaddingAttribute(PaddingType.Padding, 24)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
    }
}