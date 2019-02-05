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
    
    
    [TagGroupDefinitionAttribute(cacheFileSize: 548, tagFileSize: 564, version: 2, groupTag: "devo", parentGroupTag: "", name: "cellular_automata", minimumVersion: EngineVersion.Halo2Xbox, maximumVersion: EngineVersion.Halo2Vista)]
    public class cellular_automata_block
    {
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField0 = new Explanation(name: "parameters");
        
        [EditorMarkUpAttribute(displayName: "updates per second", unitsSpecifier: "Hz")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short updates_per_second;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.Unknown1, displayName: "x (width", unitsSpecifier: "cells")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short x__width;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.Unknown1, displayName: "y (depth", unitsSpecifier: "cells")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short y__depth;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.Unknown1, displayName: "z (height", unitsSpecifier: "cells")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short z__height;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.Unknown1, displayName: "x (width", unitsSpecifier: "world units")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float x__width1;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.Unknown1, displayName: "y (depth", unitsSpecifier: "world units")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float y__depth1;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.Unknown1, displayName: "z (height", unitsSpecifier: "world units")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float z__height1;
        
        [PaddingAttribute(PaddingType.Padding, 32)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [EditorMarkUpAttribute(displayName: "marker")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public string_id marker;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField1 = new Explanation(name: "cell birth");
        
        [EditorMarkUpAttribute(displayName: "cell birth chance", unitsSpecifier: "[0,1]")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float cell_birth_chance;
        
        [PaddingAttribute(PaddingType.Padding, 32)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding1;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField2 = new Explanation(name: "gene mutation");
        
        [EditorMarkUpAttribute(displayName: "cell gene mutates 1 in", unitsSpecifier: "times")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public int cell_gene_mutates_1_in;
        
        [EditorMarkUpAttribute(displayName: "virus gene mutations 1 in", unitsSpecifier: "times")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public int virus_gene_mutations_1_in;
        
        [PaddingAttribute(PaddingType.Padding, 32)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding2;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField3 = new Explanation(name: "cell infection");
        
        [EditorMarkUpAttribute(displayName: "infected cell lifespan", unitsSpecifier: "updates", tooltipText: "the lifespan of a cell once infected")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public ShortBounds infected_cell_lifespan;
        
        [EditorMarkUpAttribute(displayName: "minimum infection age", unitsSpecifier: "updates", tooltipText: "no cell can be infected before it has been alive this number of updates")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short minimum_infection_age;
        
        [PaddingAttribute(PaddingType.Padding, 2)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding3;
        
        [EditorMarkUpAttribute(displayName: "cell infection chance", unitsSpecifier: "[0,1]")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float cell_infection_chance;
        
        [EditorMarkUpAttribute(displayName: "infection threshold", unitsSpecifier: "[0,1]", tooltipText: "0.0 is most difficult for the virus, 1.0 means any virus can infect any cell")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float infection_threshold;
        
        [PaddingAttribute(PaddingType.Padding, 32)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding4;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField4 = new Explanation(name: "initial state");
        
        [EditorMarkUpAttribute(displayName: "new cell filled chance", unitsSpecifier: "[0,1]")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float new_cell_filled_chance;
        
        [EditorMarkUpAttribute(displayName: "new cell infected chance", unitsSpecifier: "[0,1]")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float new_cell_infected_chance;
        
        [PaddingAttribute(PaddingType.Padding, 32)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding5;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField5 = new Explanation(name: "detail texture");
        
        [EditorMarkUpAttribute(displayName: "detail texture change chance", unitsSpecifier: "[0,1]")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float detail_texture_change_chance;
        
        [PaddingAttribute(PaddingType.Padding, 32)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding6;
        
        [EditorMarkUpAttribute(displayName: "detail texture width", unitsSpecifier: "cells", tooltipText: "the number of cells repeating across the detail texture in both dimensions")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short detail_texture_width;
        
        [PaddingAttribute(PaddingType.Padding, 2)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding7;
        
        [EditorMarkUpAttribute(displayName: "detail texture")]
        [TagReferenceAttribute("bitm")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference detail_texture;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField6 = new Explanation(name: "mask texture");
        
        [PaddingAttribute(PaddingType.Padding, 32)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding8;
        
        [EditorMarkUpAttribute(displayName: "mask bitmap")]
        [TagReferenceAttribute("bitm")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference mask_bitmap;
        
        [PaddingAttribute(PaddingType.Padding, 240)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding9;
    }
}