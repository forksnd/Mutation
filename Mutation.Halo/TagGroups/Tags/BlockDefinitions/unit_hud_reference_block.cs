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
    
    
    #region unit_hud_reference_block
    [TagBlockDefinitionAttribute(cacheFileSize: 8, tagFileSize: 16, alignment: 4, maxBlockCount: 2)]
    public class unit_hud_reference_block
    {
        
        [PaddingAttribute(PaddingType.Useless, 16)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [EditorMarkUpAttribute(displayName: "new unit hud interface")]
        [TagReferenceAttribute("nhdt")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference new_unit_hud_interface;
        
        [PaddingAttribute(PaddingType.Useless, 16)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding1;
    }
    #endregion
}