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
    
    
    #region scenario_crate_block
    [TagBlockDefinitionAttribute(cacheFileSize: 76, tagFileSize: 76, alignment: 4, maxBlockCount: 1024)]
    public class scenario_crate_block
    {
        
        [EditorMarkUpAttribute(displayName: "Type")]
        [BlockIndexAttribute(blockName: "scenario_crate_palette_block")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short type;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.BlockName, displayName: "Name")]
        [BlockIndexAttribute(blockName: "scenario_object_names_block")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short name;
        
        [EditorMarkUpAttribute(displayName: "Object Data")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public scenario_object_datum_struct_block object_data;
        
        [EditorMarkUpAttribute(displayName: "Permutation Data")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public scenario_object_permutation_struct_block permutation_data;
    }
    #endregion
}
