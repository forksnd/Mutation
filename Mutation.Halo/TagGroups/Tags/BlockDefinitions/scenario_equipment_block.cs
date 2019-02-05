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
    
    
    #region scenario_equipment_block
    [TagBlockDefinitionAttribute(cacheFileSize: 56, tagFileSize: 56, alignment: 4, maxBlockCount: 256)]
    public class scenario_equipment_block
    {
        
        [EditorMarkUpAttribute(displayName: "Type")]
        [BlockIndexAttribute(blockName: "scenario_equipment_palette_block")]
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
        
        [EditorMarkUpAttribute(displayName: "Equipment Data")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public scenario_equipment_datum_struct_block equipment_data;
    }
    #endregion
    
    #region scenario_equipment_datum_struct_block
    [TagBlockDefinitionAttribute(cacheFileSize: 4, tagFileSize: 4, alignment: 4, maxBlockCount: 1)]
    public class scenario_equipment_datum_struct_block
    {
        
        [EditorMarkUpAttribute(displayName: "Equipment Flags")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public b_equipment_flags equipment_flags;
        
        [FlagsAttribute()]
        public enum b_equipment_flags : uint
        {
            
            [EditorMarkUpAttribute(flags: EditorMarkUpFlags.Unknown1, displayName: "Initially at Rest (Does Not Fall")]
            initially_at_rest__does_not_fall = 0x1,
            
            [EditorMarkUpAttribute(displayName: "Obsolete")]
            obsolete = 0x2,
            
            [EditorMarkUpAttribute(flags: EditorMarkUpFlags.Unknown1, displayName: "Does Accelerate (Moves Due to Explosions")]
            does_accelerate__moves_due_to_explosions = 0x4,
        }
    }
    #endregion
}