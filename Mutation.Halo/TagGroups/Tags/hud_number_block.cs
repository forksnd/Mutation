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
    
    
    [TagGroupDefinitionAttribute(cacheFileSize: 92, tagFileSize: 100, version: 1, groupTag: "hud#", parentGroupTag: "", name: "hud_number", minimumVersion: EngineVersion.Halo2Xbox, maximumVersion: EngineVersion.Halo2Vista)]
    public class hud_number_block
    {
        
        [EditorMarkUpAttribute(displayName: "digits bitmap")]
        [TagReferenceAttribute("bitm")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference digits_bitmap;
        
        [EditorMarkUpAttribute(displayName: "bitmap digit width")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte bitmap_digit_width;
        
        [EditorMarkUpAttribute(displayName: "screen digit width")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte screen_digit_width;
        
        [EditorMarkUpAttribute(displayName: "x offset")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte x_offset;
        
        [EditorMarkUpAttribute(displayName: "y offset")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte y_offset;
        
        [EditorMarkUpAttribute(displayName: "decimal point width")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte decimal_point_width;
        
        [EditorMarkUpAttribute(displayName: "colon width")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte colon_width;
        
        [PaddingAttribute(PaddingType.Padding, 2)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [PaddingAttribute(PaddingType.Padding, 76)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding1;
    }
}
