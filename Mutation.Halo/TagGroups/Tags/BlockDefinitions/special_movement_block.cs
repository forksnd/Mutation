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
    
    
    #region special_movement_block
    [TagBlockDefinitionAttribute(cacheFileSize: 4, tagFileSize: 4, alignment: 4, maxBlockCount: 1)]
    public class special_movement_block
    {
        
        [EditorMarkUpAttribute(displayName: "Special movement 1")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public b_special_movement_1 special_movement_1;
        
        [FlagsAttribute()]
        public enum b_special_movement_1 : uint
        {
            
            [EditorMarkUpAttribute(displayName: "jump")]
            jump = 0x1,
            
            [EditorMarkUpAttribute(displayName: "climb")]
            climb = 0x2,
            
            [EditorMarkUpAttribute(displayName: "vault")]
            vault = 0x4,
            
            [EditorMarkUpAttribute(displayName: "mount")]
            mount = 0x8,
            
            [EditorMarkUpAttribute(displayName: "hoist")]
            hoist = 0x10,
            
            [EditorMarkUpAttribute(displayName: "wall jump")]
            wall_jump = 0x20,
            
            [EditorMarkUpAttribute(displayName: "n/a")]
            n_a = 0x40,
        }
    }
    #endregion
}