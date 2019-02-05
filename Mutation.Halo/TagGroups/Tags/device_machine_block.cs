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
    
    
    [TagGroupDefinitionAttribute(cacheFileSize: 24, tagFileSize: 24, version: 1, groupTag: "mach", parentGroupTag: "devi", name: "device_machine", minimumVersion: EngineVersion.Halo2Xbox, maximumVersion: EngineVersion.Halo2Vista)]
    public class device_machine_block : device_block
    {
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField0 = new Explanation(name: "$$$ MACHINE $$$");
        
        [EditorMarkUpAttribute(displayName: "type")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public e_type type;
        
        [EditorMarkUpAttribute(displayName: "flags")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public b_flags flags;
        
        [EditorMarkUpAttribute(displayName: "door open time", unitsSpecifier: "seconds")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float door_open_time;
        
        [EditorMarkUpAttribute(displayName: "door occlusion bounds", tooltipText: "maps position [0,1] to occlusion")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealFractionBounds door_occlusion_bounds;
        
        [PaddingAttribute(PaddingType.Useless, 72)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [EditorMarkUpAttribute(displayName: "collision response")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public e_collision_response collision_response;
        
        [EditorMarkUpAttribute(displayName: "elevator node")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short elevator_node;
        
        [PaddingAttribute(PaddingType.Useless, 68)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding1;
        
        [EditorMarkUpAttribute(displayName: "pathfinding policy")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public e_pathfinding_policy pathfinding_policy;
        
        [PaddingAttribute(PaddingType.Padding, 2)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding2;
        
        public enum e_type : short
        {
            
            [EditorMarkUpAttribute(displayName: "door")]
            door = 0x0,
            
            [EditorMarkUpAttribute(displayName: "platform")]
            platform = 0x1,
            
            [EditorMarkUpAttribute(displayName: "gear")]
            gear = 0x2,
        }
        
        [FlagsAttribute()]
        public enum b_flags : short
        {
            
            [EditorMarkUpAttribute(displayName: "pathfinding obstacle")]
            pathfinding_obstacle = 0x1,
            
            [EditorMarkUpAttribute(displayName: "...but not when open")]
            ___but_not_when_open = 0x2,
            
            [EditorMarkUpAttribute(displayName: "elevator", tooltipText: "lighting based on what\'s around, rather than what\'s below")]
            elevator = 0x4,
        }
        
        public enum e_collision_response : short
        {
            
            [EditorMarkUpAttribute(displayName: "pause until crushed")]
            pause_until_crushed = 0x0,
            
            [EditorMarkUpAttribute(displayName: "reverse directions")]
            reverse_directions = 0x1,
        }
        
        public enum e_pathfinding_policy : short
        {
            
            [EditorMarkUpAttribute(displayName: "discs")]
            discs = 0x0,
            
            [EditorMarkUpAttribute(displayName: "sectors")]
            sectors = 0x1,
            
            [EditorMarkUpAttribute(displayName: "cut_out")]
            cut_out = 0x2,
            
            [EditorMarkUpAttribute(displayName: "none")]
            none = 0x3,
        }
    }
}