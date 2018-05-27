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
    
    
    #region global_geometry_section_info_struct_block
    [TagBlockDefinitionAttribute(cacheFileSize: 40, tagFileSize: 40, alignment: 4, maxBlockCount: 1)]
    public class global_geometry_section_info_struct_block
    {
        
        // CacheOffset: 0, TagOffset: 0
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField0 = new Explanation(name: "SECTION INFO");
        
        // CacheOffset: 0, TagOffset: 0
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "Total Vertex Count")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short total_vertex_count;
        
        // CacheOffset: 2, TagOffset: 2
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "Total Triangle Count")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short total_triangle_count;
        
        // CacheOffset: 4, TagOffset: 4
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "Total Part Count")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short total_part_count;
        
        // CacheOffset: 6, TagOffset: 6
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "Shadow-Casting Triangle Count")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short shadow_casting_triangle_count;
        
        // CacheOffset: 8, TagOffset: 8
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "Shadow-Casting Part Count")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short shadow_casting_part_count;
        
        // CacheOffset: 10, TagOffset: 10
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "Opaque Point Count")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short opaque_point_count;
        
        // CacheOffset: 12, TagOffset: 12
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "Opaque Vertex Count")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short opaque_vertex_count;
        
        // CacheOffset: 14, TagOffset: 14
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "Opaque Part Count")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short opaque_part_count;
        
        // CacheOffset: 16, TagOffset: 16
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "Opaque Max Nodes/Vertex")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte opaque_max_nodes_vertex;
        
        // CacheOffset: 17, TagOffset: 17
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "Transparent Max Nodes/Vertex")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte transparent_max_nodes_vertex;
        
        // CacheOffset: 18, TagOffset: 18
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "Shadow-Casting Rigid Triangle Count")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short shadow_casting_rigid_triangle_count;
        
        // CacheOffset: 20, TagOffset: 20
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "Geometry Classification")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public e_geometry_classification geometry_classification;
        
        // CacheOffset: 22, TagOffset: 22
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "Geometry Compression Flags")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public b_geometry_compression_flags geometry_compression_flags;
        
        // CacheOffset: 24, TagOffset: 24
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<global_geometry_compression_info_block> _noNameField0;
        
        // CacheOffset: 32, TagOffset: 32
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "Hardware Node Count")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte hardware_node_count;
        
        // CacheOffset: 33, TagOffset: 33
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "Node Map Size")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte node_map_size;
        
        // CacheOffset: 34, TagOffset: 34
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "Software Plane Count")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short software_plane_count;
        
        // CacheOffset: 36, TagOffset: 36
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "total subpart_cont")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short total_subpart_cont;
        
        // CacheOffset: 38, TagOffset: 38
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.ReadOnly, displayName: "Section Lighting Flags")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public b_section_lighting_flags section_lighting_flags;
        
        public enum e_geometry_classification : short
        {
            
            [EditorMarkUpAttribute(displayName: "Worldspace")]
            worldspace = 0x0,
            
            [EditorMarkUpAttribute(displayName: "Rigid")]
            rigid = 0x1,
            
            [EditorMarkUpAttribute(displayName: "Rigid Boned")]
            rigid_boned = 0x2,
            
            [EditorMarkUpAttribute(displayName: "Skinned")]
            skinned = 0x3,
            
            [EditorMarkUpAttribute(flags: EditorMarkUpFlags.Unknown1, displayName: "Unsupported (Reimport")]
            unsupported__reimport = 0x4,
        }
        
        [FlagsAttribute()]
        public enum b_geometry_compression_flags : short
        {
            
            [EditorMarkUpAttribute(displayName: "Compressed Position")]
            compressed_position = 0x1,
            
            [EditorMarkUpAttribute(displayName: "Compressed Texcoord")]
            compressed_texcoord = 0x2,
            
            [EditorMarkUpAttribute(displayName: "Compressed Secondary Texcoord")]
            compressed_secondary_texcoord = 0x4,
        }
        
        [FlagsAttribute()]
        public enum b_section_lighting_flags : short
        {
            
            [EditorMarkUpAttribute(displayName: "has lm texcoords")]
            has_lm_texcoords = 0x1,
            
            [EditorMarkUpAttribute(displayName: "has lm inc. rad.")]
            has_lm_inc__rad = 0x2,
            
            [EditorMarkUpAttribute(displayName: "Has lm Colors")]
            has_lm_colors = 0x4,
            
            [EditorMarkUpAttribute(displayName: "has lm prt")]
            has_lm_prt = 0x8,
        }
    }
    #endregion
}
