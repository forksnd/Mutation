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
    
    
    [TagGroupDefinitionAttribute(cacheFileSize: 160, tagFileSize: 180, version: 1, groupTag: "ant!", parentGroupTag: "", name: "antenna", minimumVersion: EngineVersion.Halo2Xbox, maximumVersion: EngineVersion.Halo2Vista)]
    public class antenna_block
    {
        
        [EditorMarkUpAttribute(displayName: "attachment marker name", tooltipText: "the marker name where the antenna should be attached")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public string_id attachment_marker_name;
        
        [EditorMarkUpAttribute(displayName: "bitmaps")]
        [TagReferenceAttribute("bitm")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference bitmaps;
        
        [EditorMarkUpAttribute(displayName: "physics")]
        [TagReferenceAttribute("pphy")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference physics;
        
        [PaddingAttribute(PaddingType.Padding, 80)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.Unknown1, displayName: "spring strength coefficient", tooltipText: "strength of the spring (larger values make the spring stronger)")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float spring_strength_coefficient;
        
        [EditorMarkUpAttribute(displayName: "falloff pixels")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float falloff_pixels;
        
        [EditorMarkUpAttribute(displayName: "cutoff pixels")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float cutoff_pixels;
        
        [PaddingAttribute(PaddingType.Padding, 40)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding1;
        
        [EditorMarkUpAttribute(displayName: "vertices")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<antenna_vertex_block> vertices;
    }
    
    #region antenna_vertex_block
    [TagBlockDefinitionAttribute(cacheFileSize: 128, tagFileSize: 128, alignment: 4, maxBlockCount: 20)]
    public class antenna_vertex_block
    {
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.Unknown1, displayName: "spring strength coefficient", tooltipText: "strength of the spring (larger values make the spring stronger)")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float spring_strength_coefficient;
        
        [PaddingAttribute(PaddingType.Padding, 24)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [EditorMarkUpAttribute(displayName: "angles", tooltipText: "direction toward next vertex")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealEulerAngle2d angles;
        
        [EditorMarkUpAttribute(displayName: "length", unitsSpecifier: "world units", tooltipText: "distance between this vertex and the next")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float length;
        
        [EditorMarkUpAttribute(displayName: "sequence index", tooltipText: "bitmap group sequence index for this vertex\'s texture")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short sequence_index;
        
        [PaddingAttribute(PaddingType.Padding, 2)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding1;
        
        [EditorMarkUpAttribute(displayName: "color", tooltipText: "color at this vertex")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealColorArgb color;
        
        [EditorMarkUpAttribute(displayName: "LOD color", tooltipText: "color at this vertex for the low-LOD line primitives")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealColorArgb lod_color;
        
        [PaddingAttribute(PaddingType.Padding, 40)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding2;
        
        [PaddingAttribute(PaddingType.Padding, 12)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding3;
    }
    #endregion
}