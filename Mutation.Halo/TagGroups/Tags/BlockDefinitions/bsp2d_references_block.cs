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
    
    
    #region bsp2d_references_block
    [TagBlockDefinitionAttribute(cacheFileSize: 4, tagFileSize: 4, alignment: 4, maxBlockCount: 131072)]
    public class bsp2d_references_block
    {
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "Plane")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short plane;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "BSP 2D Node")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short bsp_2d_node;
    }
    #endregion
}
