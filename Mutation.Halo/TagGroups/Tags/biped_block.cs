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
    
    
    [TagGroupDefinitionAttribute(cacheFileSize: 296, tagFileSize: 336, version: 3, groupTag: "bipd", parentGroupTag: "unit", name: "biped", minimumVersion: EngineVersion.Halo2Xbox, maximumVersion: EngineVersion.Halo2Vista)]
    public class biped_block : unit_block
    {
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField0 = new Explanation(name: "$$$ BIPED $$$");
        
        [EditorMarkUpAttribute(displayName: "moving turning speed", unitsSpecifier: "degrees per second")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float moving_turning_speed;
        
        [EditorMarkUpAttribute(displayName: "flags")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public b_flags flags;
        
        [EditorMarkUpAttribute(displayName: "stationary turning threshold")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float stationary_turning_threshold;
        
        [PaddingAttribute(PaddingType.Useless, 16)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [PaddingAttribute(PaddingType.Useless, 32)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding1;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField1 = new Explanation(name: "jumping and landing");
        
        [EditorMarkUpAttribute(displayName: "jump velocity", unitsSpecifier: "world units per second")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float jump_velocity;
        
        [PaddingAttribute(PaddingType.Useless, 28)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding2;
        
        [EditorMarkUpAttribute(displayName: "maximum soft landing time", unitsSpecifier: "seconds", tooltipText: "the longest amount of time the biped can take to recover from a soft landing")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float maximum_soft_landing_time;
        
        [EditorMarkUpAttribute(displayName: "maximum hard landing time", unitsSpecifier: "seconds", tooltipText: "the longest amount of time the biped can take to recover from a hard landing")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float maximum_hard_landing_time;
        
        [EditorMarkUpAttribute(displayName: "minimum soft landing velocity", unitsSpecifier: "world units per second", tooltipText: "below this velocity the biped does not react when landing")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float minimum_soft_landing_velocity;
        
        [EditorMarkUpAttribute(displayName: "minimum hard landing velocity", unitsSpecifier: "world units per second", tooltipText: "below this velocity the biped will not do a soft landing when returning to the gr" +
    "ound")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float minimum_hard_landing_velocity;
        
        [EditorMarkUpAttribute(displayName: "maximum hard landing velocity", unitsSpecifier: "world units per second", tooltipText: "the velocity corresponding to the maximum landing time")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float maximum_hard_landing_velocity;
        
        [EditorMarkUpAttribute(displayName: "death hard landing velocity", unitsSpecifier: "world units per second", tooltipText: "the maximum velocity with which a character can strike the ground and live")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float death_hard_landing_velocity;
        
        [PaddingAttribute(PaddingType.Useless, 16)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding3;
        
        [EditorMarkUpAttribute(displayName: "stun duration", tooltipText: "0 is the default.  Bipeds are stuned when damaged by vehicle collisions, also som" +
    "e are when they take emp damage")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float stun_duration;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField2 = new Explanation(name: "camera, collision, and autoaim");
        
        [EditorMarkUpAttribute(displayName: "standing camera height", unitsSpecifier: "world units")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float standing_camera_height;
        
        [EditorMarkUpAttribute(displayName: "crouching camera height", unitsSpecifier: "world units")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float crouching_camera_height;
        
        [EditorMarkUpAttribute(displayName: "crouch transition time", unitsSpecifier: "seconds")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float crouch_transition_time;
        
        [EditorMarkUpAttribute(displayName: "camera interpolation start", unitsSpecifier: "degrees", tooltipText: "looking-downward angle that starts camera interpolation to fp position")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float camera_interpolation_start;
        
        [EditorMarkUpAttribute(displayName: "camera interpolation end", unitsSpecifier: "degrees", tooltipText: "looking-downward angle at which camera interpolation to fp position is complete")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float camera_interpolation_end;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.Unknown1, displayName: "camera forward movement scale", tooltipText: "amount of fp camera movement forward and back (1.0 is full)")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float camera_forward_movement_scale;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.Unknown1, displayName: "camera side movement scale", tooltipText: "amount of fp camera movement side-to-side (1.0 is full)")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float camera_side_movement_scale;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.Unknown1, displayName: "camera vertical movement scale", tooltipText: "amount of fp camera movement vertically (1.0 is full)")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float camera_vertical_movement_scale;
        
        [EditorMarkUpAttribute(displayName: "camera exclusion distance", unitsSpecifier: "world units", tooltipText: "fp camera must always be at least this far out from root node")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float camera_exclusion_distance;
        
        [EditorMarkUpAttribute(displayName: "autoaim width", unitsSpecifier: "world units")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float autoaim_width;
        
        [EditorMarkUpAttribute(displayName: "lock-on data")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public biped_lock_on_data_struct_block lock_on_data;
        
        [PaddingAttribute(PaddingType.Padding, 16)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding4;
        
        [PaddingAttribute(PaddingType.Useless, 12)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding5;
        
        [EditorMarkUpAttribute(displayName: "head shot acc scale", tooltipText: "when the biped ragdolls from a head shot it acceleartes based on this value.  0 d" +
    "efaults to the standard acceleration scale")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float head_shot_acc_scale;
        
        [EditorMarkUpAttribute(displayName: "area damage effect")]
        [TagReferenceAttribute("effe")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference area_damage_effect;
        
        [EditorMarkUpAttribute(displayName: "physics")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public character_physics_struct_block physics;
        
        [EditorMarkUpAttribute(displayName: "contact points", tooltipText: "these are the points where the biped touches the ground")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<contact_point_block> contact_points;
        
        [EditorMarkUpAttribute(displayName: "reanimation character", tooltipText: "when the flood reanimate this guy, he turns into a ...")]
        [TagReferenceAttribute("char")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference reanimation_character;
        
        [EditorMarkUpAttribute(displayName: "death spawn character", tooltipText: "when I die, out of the ashes of my death crawls a ...")]
        [TagReferenceAttribute("char")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference death_spawn_character;
        
        [EditorMarkUpAttribute(displayName: "death spawn count")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short death_spawn_count;
        
        [PaddingAttribute(PaddingType.Padding, 2)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding6;
        
        [FlagsAttribute()]
        public enum b_flags : uint
        {
            
            [EditorMarkUpAttribute(displayName: "turns without animating")]
            turns_without_animating = 0x1,
            
            [EditorMarkUpAttribute(displayName: "passes through other bipeds")]
            passes_through_other_bipeds = 0x2,
            
            [EditorMarkUpAttribute(displayName: "immune to falling damage")]
            immune_to_falling_damage = 0x4,
            
            [EditorMarkUpAttribute(displayName: "rotate while airborne")]
            rotate_while_airborne = 0x8,
            
            [EditorMarkUpAttribute(displayName: "uses limp body physics")]
            uses_limp_body_physics = 0x10,
            
            [EditorMarkUpAttribute(displayName: "unused")]
            unused = 0x20,
            
            [EditorMarkUpAttribute(displayName: "random speed increase")]
            random_speed_increase = 0x40,
            
            [EditorMarkUpAttribute(displayName: "unused")]
            unused1 = 0x80,
            
            [EditorMarkUpAttribute(displayName: "spawn death children on destroy")]
            spawn_death_children_on_destroy = 0x100,
            
            [EditorMarkUpAttribute(displayName: "stunned by emp damage")]
            stunned_by_emp_damage = 0x200,
            
            [EditorMarkUpAttribute(displayName: "dead physics when stunned")]
            dead_physics_when_stunned = 0x400,
            
            [EditorMarkUpAttribute(displayName: "always ragdoll when dead")]
            always_ragdoll_when_dead = 0x800,
        }
    }
    
    #region biped_lock_on_data_struct_block
    [TagBlockDefinitionAttribute(cacheFileSize: 8, tagFileSize: 8, alignment: 4, maxBlockCount: 1)]
    public class biped_lock_on_data_struct_block
    {
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField0 = new Explanation(name: "lock-on fields");
        
        [EditorMarkUpAttribute(displayName: "flags")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public b_flags flags;
        
        [EditorMarkUpAttribute(displayName: "lock on distance")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float lock_on_distance;
        
        [FlagsAttribute()]
        public enum b_flags : uint
        {
            
            [EditorMarkUpAttribute(displayName: "locked by human targeting")]
            locked_by_human_targeting = 0x1,
            
            [EditorMarkUpAttribute(displayName: "locked by plasma targeting")]
            locked_by_plasma_targeting = 0x2,
            
            [EditorMarkUpAttribute(displayName: "always locked by plasma targeting")]
            always_locked_by_plasma_targeting = 0x4,
        }
    }
    #endregion
    
    #region contact_point_block
    [TagBlockDefinitionAttribute(cacheFileSize: 4, tagFileSize: 4, alignment: 4, maxBlockCount: 3)]
    public class contact_point_block
    {
        
        [PaddingAttribute(PaddingType.Useless, 32)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.BlockName, displayName: "marker name")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public string_id marker_name;
    }
    #endregion
}
