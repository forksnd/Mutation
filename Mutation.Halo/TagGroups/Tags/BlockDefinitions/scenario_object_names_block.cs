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
    
    
    #region scenario_object_names_block
    [TagBlockDefinitionAttribute(cacheFileSize: 36, tagFileSize: 36, alignment: 4, maxBlockCount: 640)]
    public class scenario_object_names_block
    {
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.BlockName, displayName: "Name")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public String32 name;
        
        // get_block_proc=0x0040d250, is_valid_source_block_proc=0x004955f0
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short _noNameField0;
        
        // get_block_proc=0x004af8e0, is_valid_source_block_proc=0x004af960
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short _noNameField1;
    }
    #endregion
}
