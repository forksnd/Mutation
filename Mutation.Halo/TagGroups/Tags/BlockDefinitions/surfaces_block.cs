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
    
    
    #region surfaces_block
    [TagBlockDefinitionAttribute(cacheFileSize: 8, tagFileSize: 8, alignment: 8, maxBlockCount: 131072)]
    public class surfaces_block
    {
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "Plane")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short plane;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "First Edge")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short first_edge;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "Flags")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public b_flags flags;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "Breakable Surface")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte breakable_surface;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "Material")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short material;
        
        [FlagsAttribute()]
        public enum b_flags : byte
        {
            
            [EditorMarkUpAttribute(displayName: "Two-Sided")]
            two_sided = 0x1,
            
            [EditorMarkUpAttribute(displayName: "Invisible")]
            invisible = 0x2,
            
            [EditorMarkUpAttribute(displayName: "Climbable")]
            climbable = 0x4,
            
            [EditorMarkUpAttribute(displayName: "Breakable")]
            breakable = 0x8,
            
            [EditorMarkUpAttribute(displayName: "Invalid")]
            invalid = 0x10,
            
            [EditorMarkUpAttribute(displayName: "Conveyor")]
            conveyor = 0x20,
        }
    }
    #endregion
}