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
    
    
    [TagGroupDefinitionAttribute(cacheFileSize: 52, tagFileSize: 76, version: 1, groupTag: "*sce", parentGroupTag: "", name: "scenario_sound_scenery_resource", minimumVersion: EngineVersion.Halo2Xbox, maximumVersion: EngineVersion.Halo2Vista)]
    public class scenario_sound_scenery_resource_block
    {
        
        [EditorMarkUpAttribute(displayName: "Names")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<scenario_object_names_block> names;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<dont_use_me_scenario_environment_object_block> _noNameField0;
        
        [EditorMarkUpAttribute(displayName: "Structure References")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<scenario_structure_bsp_reference_block> structure_references;
        
        [EditorMarkUpAttribute(displayName: "Palette")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<scenario_sound_scenery_palette_block> palette;
        
        [EditorMarkUpAttribute(displayName: "Objects")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<scenario_sound_scenery_block> objects;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "Next Object ID Salt")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public int next_object_id_salt;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "Editor Folders")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<g_scenario_editor_folder_block> editor_folders;
    }
}