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
    
    
    [TagGroupDefinitionAttribute(cacheFileSize: 544, tagFileSize: 556, version: 1, groupTag: "whip", parentGroupTag: "", name: "cellular_automata2d", minimumVersion: EngineVersion.Halo2Xbox, maximumVersion: EngineVersion.Halo2Vista)]
    public class cellular_automata2d_block
    {
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField0 = new Explanation(name: "properties");
        
        [EditorMarkUpAttribute(displayName: "updates per second", unitsSpecifier: "Hz")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short updates_per_second;
        
        [PaddingAttribute(PaddingType.Padding, 2)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [EditorMarkUpAttribute(displayName: "dead cell penalty")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float dead_cell_penalty;
        
        [EditorMarkUpAttribute(displayName: "live cell bonus")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float live_cell_bonus;
        
        [PaddingAttribute(PaddingType.Padding, 80)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding1;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField1 = new Explanation(name: "height map");
        
        [EditorMarkUpAttribute(displayName: "width", unitsSpecifier: "cells")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short width;
        
        [EditorMarkUpAttribute(displayName: "height", unitsSpecifier: "cells")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short height;
        
        [EditorMarkUpAttribute(displayName: "cell width", unitsSpecifier: "world units")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float cell_width;
        
        [EditorMarkUpAttribute(displayName: "height", unitsSpecifier: "world units")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float height1;
        
        [EditorMarkUpAttribute(displayName: "velocity", unitsSpecifier: "cells/update")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealVector2d velocity;
        
        [PaddingAttribute(PaddingType.Padding, 28)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding2;
        
        [EditorMarkUpAttribute(displayName: "marker")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public string_id marker;
        
        [EditorMarkUpAttribute(displayName: "interpolation flags")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public b_interpolation_flags interpolation_flags;
        
        [EditorMarkUpAttribute(displayName: "base color")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealColorRgb base_color;
        
        [EditorMarkUpAttribute(displayName: "peak color")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealColorRgb peak_color;
        
        [PaddingAttribute(PaddingType.Padding, 76)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding3;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField2 = new Explanation(name: "detail map");
        
        [EditorMarkUpAttribute(displayName: "width", unitsSpecifier: "cells")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short width1;
        
        [EditorMarkUpAttribute(displayName: "height", unitsSpecifier: "cells")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short height2;
        
        [EditorMarkUpAttribute(displayName: "cell width", unitsSpecifier: "world units")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float cell_width1;
        
        [EditorMarkUpAttribute(displayName: "velocity", unitsSpecifier: "cells/update")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealVector2d velocity1;
        
        [PaddingAttribute(PaddingType.Padding, 48)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding4;
        
        [EditorMarkUpAttribute(displayName: "marker")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public string_id marker1;
        
        [EditorMarkUpAttribute(displayName: "texture width", unitsSpecifier: "cells")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short texture_width;
        
        [PaddingAttribute(PaddingType.Padding, 2)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding5;
        
        [PaddingAttribute(PaddingType.Padding, 48)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding6;
        
        [EditorMarkUpAttribute(displayName: "texture")]
        [TagReferenceAttribute("bitm")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference texture;
        
        [PaddingAttribute(PaddingType.Padding, 160)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding7;
        
        [EditorMarkUpAttribute(displayName: "rules")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<rules_block> rules;
        
        [FlagsAttribute()]
        public enum b_interpolation_flags : uint
        {
            
            [EditorMarkUpAttribute(displayName: "blend in hsv", tooltipText: "blends colors in hsv rather than rgb space")]
            blend_in_hsv = 0x1,
            
            [EditorMarkUpAttribute(flags: EditorMarkUpFlags.Unknown1, displayName: "...more colors", tooltipText: "blends colors through more hues (goes the long way around the color wheel)")]
            ___more_colors = 0x2,
        }
    }
    
    #region rules_block
    [TagBlockDefinitionAttribute(cacheFileSize: 84, tagFileSize: 84, alignment: 4, maxBlockCount: 16)]
    public class rules_block
    {
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.BlockName, displayName: "name")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public String32 name;
        
        [EditorMarkUpAttribute(displayName: "tint color")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealColorRgb tint_color;
        
        [PaddingAttribute(PaddingType.Padding, 32)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [EditorMarkUpAttribute(displayName: "states")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<states_block> states;
    }
    #endregion
    
    #region states_block
    [TagBlockDefinitionAttribute(cacheFileSize: 96, tagFileSize: 96, alignment: 4, maxBlockCount: 16)]
    public class states_block
    {
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.BlockName, displayName: "name")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public String32 name;
        
        [EditorMarkUpAttribute(displayName: "color")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealColorRgb color;
        
        [EditorMarkUpAttribute(displayName: "counts as", unitsSpecifier: "neighbors")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short counts_as;
        
        [PaddingAttribute(PaddingType.Padding, 2)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [EditorMarkUpAttribute(displayName: "initial placement weight")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float initial_placement_weight;
        
        [PaddingAttribute(PaddingType.Padding, 24)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding1;
        
        [EditorMarkUpAttribute(displayName: "zero")]
        [BlockIndexAttribute(blockName: "states_block")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short zero;
        
        [EditorMarkUpAttribute(displayName: "one")]
        [BlockIndexAttribute(blockName: "states_block")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short one;
        
        [EditorMarkUpAttribute(displayName: "two")]
        [BlockIndexAttribute(blockName: "states_block")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short two;
        
        [EditorMarkUpAttribute(displayName: "three")]
        [BlockIndexAttribute(blockName: "states_block")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short three;
        
        [EditorMarkUpAttribute(displayName: "four")]
        [BlockIndexAttribute(blockName: "states_block")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short four;
        
        [EditorMarkUpAttribute(displayName: "five")]
        [BlockIndexAttribute(blockName: "states_block")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short five;
        
        [EditorMarkUpAttribute(displayName: "six")]
        [BlockIndexAttribute(blockName: "states_block")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short six;
        
        [EditorMarkUpAttribute(displayName: "seven")]
        [BlockIndexAttribute(blockName: "states_block")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short seven;
        
        [EditorMarkUpAttribute(displayName: "eight")]
        [BlockIndexAttribute(blockName: "states_block")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short eight;
        
        [PaddingAttribute(PaddingType.Padding, 2)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding2;
    }
    #endregion
}