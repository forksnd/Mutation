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
    
    
    [TagGroupDefinitionAttribute(cacheFileSize: 8, tagFileSize: 12, version: 1, groupTag: "sslt", parentGroupTag: "", name: "scenario_structure_lighting_resource", minimumVersion: EngineVersion.Halo2Xbox, maximumVersion: EngineVersion.Halo2Vista)]
    public class scenario_structure_lighting_resource_block
    {
        
        [EditorMarkUpAttribute(displayName: "Structure Lighting")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<scenario_structure_bsp_spherical_harmonic_lighting_block> structure_lighting;
    }
}
