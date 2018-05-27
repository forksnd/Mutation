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
    
    
    [TagGroupDefinitionAttribute(cacheFileSize: 232, tagFileSize: 348, version: 5, groupTag: "proj", parentGroupTag: "obje", name: "projectile", minimumVersion: EngineVersion.Halo2Xbox, maximumVersion: EngineVersion.Halo2Vista)]
    public class projectile_block : object_block
    {
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField0 = new Explanation(name: "$$$ PROJECTILE $$$");
        
        [EditorMarkUpAttribute(displayName: "flags")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public b_flags flags;
        
        [EditorMarkUpAttribute(displayName: "detonation timer starts")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public e_detonation_timer_starts detonation_timer_starts;
        
        [EditorMarkUpAttribute(displayName: "impact noise")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public e_impact_noise impact_noise;
        
        [PaddingAttribute(PaddingType.Useless, 8)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [EditorMarkUpAttribute(displayName: "AI perception radius", unitsSpecifier: "world units")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float ai_perception_radius;
        
        [EditorMarkUpAttribute(displayName: "collision radius", unitsSpecifier: "world units")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float collision_radius;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField1 = new Explanation(name: "detonation");
        
        [EditorMarkUpAttribute(displayName: "arming time", unitsSpecifier: "seconds", tooltipText: "won\'t detonate before this time elapses")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float arming_time;
        
        [EditorMarkUpAttribute(displayName: "danger radius", unitsSpecifier: "world units")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float danger_radius;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.Unknown1, displayName: "timer", unitsSpecifier: "seconds", tooltipText: "detonation countdown (zero is untimed)")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealBounds timer;
        
        [EditorMarkUpAttribute(displayName: "minimum velocity", unitsSpecifier: "world units per second", tooltipText: "detonates when slowed below this velocity")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float minimum_velocity;
        
        [EditorMarkUpAttribute(displayName: "maximum range", unitsSpecifier: "world units", tooltipText: "detonates after travelling this distance")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float maximum_range;
        
        [EditorMarkUpAttribute(displayName: "detonation noise")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public e_impact_noise detonation_noise;
        
        [EditorMarkUpAttribute(displayName: "super det. projectile count")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public short super_det__projectile_count;
        
        [EditorMarkUpAttribute(displayName: "detonation started")]
        [TagReferenceAttribute("effe")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference detonation_started;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.Unknown1, displayName: "detonation effect (airborne")]
        [TagReferenceAttribute("effe")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference detonation_effect__airborne;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.Unknown1, displayName: "detonation effect (ground")]
        [TagReferenceAttribute("effe")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference detonation_effect__ground;
        
        [EditorMarkUpAttribute(displayName: "detonation damage")]
        [TagReferenceAttribute("jpt!")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference detonation_damage;
        
        [EditorMarkUpAttribute(displayName: "attached detonation damage")]
        [TagReferenceAttribute("jpt!")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference attached_detonation_damage;
        
        [EditorMarkUpAttribute(displayName: "super detonation")]
        [TagReferenceAttribute("effe")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference super_detonation;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.Advanced, displayName: "your momma")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public super_detonation_damage_struct_block your_momma;
        
        [EditorMarkUpAttribute(displayName: "detonation sound")]
        [TagReferenceAttribute("snd!")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference detonation_sound;
        
        [EditorMarkUpAttribute(displayName: "damage reporting type")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public e_damage_reporting_type damage_reporting_type;
        
        [PaddingAttribute(PaddingType.Padding, 3)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding1;
        
        [EditorMarkUpAttribute(displayName: "super attached detonation damage")]
        [TagReferenceAttribute("jpt!")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference super_attached_detonation_damage;
        
        [PaddingAttribute(PaddingType.Useless, 40)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding2;
        
        [EditorMarkUpAttribute(displayName: "material effect radius", tooltipText: "radius within we will generate material effects")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float material_effect_radius;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField2 = new Explanation(name: "flyby/impact");
        
        [EditorMarkUpAttribute(displayName: "flyby sound")]
        [TagReferenceAttribute("snd!")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference flyby_sound;
        
        [EditorMarkUpAttribute(displayName: "impact effect")]
        [TagReferenceAttribute("effe")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference impact_effect;
        
        [EditorMarkUpAttribute(displayName: "impact damage")]
        [TagReferenceAttribute("jpt!")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference impact_damage;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField3 = new Explanation(name: "boarding fields");
        
        [EditorMarkUpAttribute(displayName: "boarding detonation time")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float boarding_detonation_time;
        
        [EditorMarkUpAttribute(displayName: "boarding detonation damage")]
        [TagReferenceAttribute("jpt!")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference boarding_detonation_damage;
        
        [EditorMarkUpAttribute(displayName: "boarding attached detonation damage")]
        [TagReferenceAttribute("jpt!")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference boarding_attached_detonation_damage;
        
        [PaddingAttribute(PaddingType.Useless, 28)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding3;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField4 = new Explanation(name: "physics");
        
        [EditorMarkUpAttribute(displayName: "air gravity scale", tooltipText: "the proportion of normal gravity applied to the projectile when in air.")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float air_gravity_scale;
        
        [EditorMarkUpAttribute(displayName: "air damage range", unitsSpecifier: "world units", tooltipText: "the range over which damage is scaled when the projectile is in air.")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealBounds air_damage_range;
        
        [EditorMarkUpAttribute(displayName: "water gravity scale", tooltipText: "the proportion of normal gravity applied to the projectile when in water.")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float water_gravity_scale;
        
        [EditorMarkUpAttribute(displayName: "water damage range", unitsSpecifier: "world units", tooltipText: "the range over which damage is scaled when the projectile is in water.")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealBounds water_damage_range;
        
        [EditorMarkUpAttribute(displayName: "initial velocity", unitsSpecifier: "world units per second", tooltipText: "bullet\'s velocity when inflicting maximum damage")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float initial_velocity;
        
        [EditorMarkUpAttribute(displayName: "final velocity", unitsSpecifier: "world units per second", tooltipText: "bullet\'s velocity when inflicting minimum damage")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float final_velocity;
        
        [EditorMarkUpAttribute(displayName: "blah")]
        [TagStructAttribute()]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public angular_velocity_lower_bound_struct_block blah;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.Unknown1, displayName: "guided angular velocity (upper", unitsSpecifier: "degrees per second")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float guided_angular_velocity__upper;
        
        [EditorMarkUpAttribute(displayName: "acceleration range", unitsSpecifier: "world units", tooltipText: "what distance range the projectile goes from initial velocity to final velocity")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealBounds acceleration_range;
        
        [PaddingAttribute(PaddingType.Padding, 4)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding4;
        
        [EditorMarkUpAttribute(displayName: "targeted leading fraction")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float targeted_leading_fraction;
        
        [PaddingAttribute(PaddingType.Useless, 48)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding5;
        
        [EditorMarkUpAttribute(displayName: "material responses")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public tag_block<projectile_material_response_block> material_responses;
        
        [FlagsAttribute()]
        public enum b_flags : uint
        {
            
            [EditorMarkUpAttribute(displayName: "oriented along velocity")]
            oriented_along_velocity = 0x1,
            
            [EditorMarkUpAttribute(displayName: "AI must use ballistic aiming")]
            ai_must_use_ballistic_aiming = 0x2,
            
            [EditorMarkUpAttribute(displayName: "detonation max time if attached")]
            detonation_max_time_if_attached = 0x4,
            
            [EditorMarkUpAttribute(displayName: "has super combining explosion")]
            has_super_combining_explosion = 0x8,
            
            [EditorMarkUpAttribute(displayName: "damage scales based on distance")]
            damage_scales_based_on_distance = 0x10,
            
            [EditorMarkUpAttribute(displayName: "travels instantaneously")]
            travels_instantaneously = 0x20,
            
            [EditorMarkUpAttribute(displayName: "steering adjusts orientation")]
            steering_adjusts_orientation = 0x40,
            
            [EditorMarkUpAttribute(displayName: "don\'t noise up steering")]
            don_t_noise_up_steering = 0x80,
            
            [EditorMarkUpAttribute(displayName: "can track behind itself")]
            can_track_behind_itself = 0x100,
            
            [EditorMarkUpAttribute(flags: EditorMarkUpFlags.Advanced, displayName: "ROBOTRON STEERING")]
            robotron_steering = 0x200,
            
            [EditorMarkUpAttribute(displayName: "faster when owned by player")]
            faster_when_owned_by_player = 0x400,
        }
        
        public enum e_detonation_timer_starts : short
        {
            
            [EditorMarkUpAttribute(displayName: "immediately")]
            immediately = 0x0,
            
            [EditorMarkUpAttribute(displayName: "after first bounce")]
            after_first_bounce = 0x1,
            
            [EditorMarkUpAttribute(displayName: "when at rest")]
            when_at_rest = 0x2,
            
            [EditorMarkUpAttribute(displayName: "after first bounce off any surface")]
            after_first_bounce_off_any_surface = 0x3,
        }
        
        public enum e_impact_noise : short
        {
            
            [EditorMarkUpAttribute(displayName: "silent")]
            silent = 0x0,
            
            [EditorMarkUpAttribute(displayName: "medium")]
            medium = 0x1,
            
            [EditorMarkUpAttribute(displayName: "loud")]
            loud = 0x2,
            
            [EditorMarkUpAttribute(displayName: "shout")]
            shout = 0x3,
            
            [EditorMarkUpAttribute(displayName: "quiet")]
            quiet = 0x4,
        }
        
        public enum e_damage_reporting_type : byte
        {
            
            [EditorMarkUpAttribute(flags: EditorMarkUpFlags.Advanced, displayName: "teh guardians11")]
            teh_guardians__1__1 = 0x0,
            
            [EditorMarkUpAttribute(displayName: "falling damage")]
            falling_damage = 0x1,
            
            [EditorMarkUpAttribute(displayName: "generic collision damage")]
            generic_collision_damage = 0x2,
            
            [EditorMarkUpAttribute(displayName: "generic melee damage")]
            generic_melee_damage = 0x3,
            
            [EditorMarkUpAttribute(displayName: "generic explosion")]
            generic_explosion = 0x4,
            
            [EditorMarkUpAttribute(displayName: "magnum pistol")]
            magnum_pistol = 0x5,
            
            [EditorMarkUpAttribute(displayName: "plasma pistol")]
            plasma_pistol = 0x6,
            
            [EditorMarkUpAttribute(displayName: "needler")]
            needler = 0x7,
            
            [EditorMarkUpAttribute(displayName: "smg")]
            smg = 0x8,
            
            [EditorMarkUpAttribute(displayName: "plasma rifle")]
            plasma_rifle = 0x9,
            
            [EditorMarkUpAttribute(displayName: "battle rifle")]
            battle_rifle = 0xa,
            
            [EditorMarkUpAttribute(displayName: "carbine")]
            carbine = 0xb,
            
            [EditorMarkUpAttribute(displayName: "shotgun")]
            shotgun = 0xc,
            
            [EditorMarkUpAttribute(displayName: "sniper rifle")]
            sniper_rifle = 0xd,
            
            [EditorMarkUpAttribute(displayName: "beam rifle")]
            beam_rifle = 0xe,
            
            [EditorMarkUpAttribute(displayName: "rocket launcher")]
            rocket_launcher = 0xf,
            
            [EditorMarkUpAttribute(displayName: "flak cannon")]
            flak_cannon = 0x10,
            
            [EditorMarkUpAttribute(displayName: "brute shot")]
            brute_shot = 0x11,
            
            [EditorMarkUpAttribute(displayName: "disintegrator")]
            disintegrator = 0x12,
            
            [EditorMarkUpAttribute(displayName: "brute plasma rifle")]
            brute_plasma_rifle = 0x13,
            
            [EditorMarkUpAttribute(displayName: "energy sword")]
            energy_sword = 0x14,
            
            [EditorMarkUpAttribute(displayName: "frag grenade")]
            frag_grenade = 0x15,
            
            [EditorMarkUpAttribute(displayName: "plasma grenade")]
            plasma_grenade = 0x16,
            
            [EditorMarkUpAttribute(displayName: "flag melee damage")]
            flag_melee_damage = 0x17,
            
            [EditorMarkUpAttribute(displayName: "bomb melee damage")]
            bomb_melee_damage = 0x18,
            
            [EditorMarkUpAttribute(displayName: "bomb explosion damage")]
            bomb_explosion_damage = 0x19,
            
            [EditorMarkUpAttribute(displayName: "ball melee damage")]
            ball_melee_damage = 0x1a,
            
            [EditorMarkUpAttribute(displayName: "human turret")]
            human_turret = 0x1b,
            
            [EditorMarkUpAttribute(displayName: "plasma turret")]
            plasma_turret = 0x1c,
            
            [EditorMarkUpAttribute(displayName: "banshee")]
            banshee = 0x1d,
            
            [EditorMarkUpAttribute(displayName: "ghost")]
            ghost = 0x1e,
            
            [EditorMarkUpAttribute(displayName: "mongoose")]
            mongoose = 0x1f,
            
            [EditorMarkUpAttribute(displayName: "scorpion")]
            scorpion = 0x20,
            
            [EditorMarkUpAttribute(displayName: "spectre driver")]
            spectre_driver = 0x21,
            
            [EditorMarkUpAttribute(displayName: "spectre gunner")]
            spectre_gunner = 0x22,
            
            [EditorMarkUpAttribute(displayName: "warthog driver")]
            warthog_driver = 0x23,
            
            [EditorMarkUpAttribute(displayName: "warthog gunner")]
            warthog_gunner = 0x24,
            
            [EditorMarkUpAttribute(displayName: "wraith")]
            wraith = 0x25,
            
            [EditorMarkUpAttribute(displayName: "tank")]
            tank = 0x26,
            
            [EditorMarkUpAttribute(displayName: "sentinel beam")]
            sentinel_beam = 0x27,
            
            [EditorMarkUpAttribute(displayName: "sentinel rpg")]
            sentinel_rpg = 0x28,
            
            [EditorMarkUpAttribute(displayName: "teleporter")]
            teleporter = 0x29,
        }
    }
    
    #region super_detonation_damage_struct_block
    [TagBlockDefinitionAttribute(cacheFileSize: 8, tagFileSize: 8, alignment: 4, maxBlockCount: 1)]
    public class super_detonation_damage_struct_block
    {
        
        [EditorMarkUpAttribute(displayName: "super detonation damage")]
        [TagReferenceAttribute("jpt!")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference super_detonation_damage;
    }
    #endregion
    
    #region angular_velocity_lower_bound_struct_block
    [TagBlockDefinitionAttribute(cacheFileSize: 4, tagFileSize: 4, alignment: 4, maxBlockCount: 1)]
    public class angular_velocity_lower_bound_struct_block
    {
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.Unknown1, displayName: "guided angular velocity (lower", unitsSpecifier: "degrees per second")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float guided_angular_velocity__lower;
    }
    #endregion
    
    #region projectile_material_response_block
    [TagBlockDefinitionAttribute(cacheFileSize: 88, tagFileSize: 88, alignment: 4, maxBlockCount: 200)]
    public class projectile_material_response_block
    {
        
        [EditorMarkUpAttribute(displayName: "flags")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public b_flags flags;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField0 = new Explanation(name: "default result", explanation: "(if the potential result, below, fails to happen)");
        
        [EditorMarkUpAttribute(displayName: "response")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public e_response response;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.Unknown1, displayName: "DO NOT USE (OLD effect")]
        [TagReferenceAttribute("effe")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference do_not_use__old_effect;
        
        [EditorMarkUpAttribute(displayName: "material name")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public string_id material_name;
        
        [PaddingAttribute(PaddingType.Skip, 4)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding0;
        
        [PaddingAttribute(PaddingType.Useless, 8)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding1;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField1 = new Explanation(name: "potential result");
        
        [EditorMarkUpAttribute(displayName: "response")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public e_response response1;
        
        [EditorMarkUpAttribute(displayName: "flags")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public b_flags1 flags1;
        
        [EditorMarkUpAttribute(displayName: "chance fraction", unitsSpecifier: "[0,1]")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float chance_fraction;
        
        [EditorMarkUpAttribute(displayName: "between", unitsSpecifier: "degrees")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public AngleBounds between;
        
        [EditorMarkUpAttribute(displayName: "and", unitsSpecifier: "world units per second")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public RealBounds and;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.Unknown1, displayName: "DO NOT USE (OLD effect")]
        [TagReferenceAttribute("effe")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference do_not_use__old_effect1;
        
        [PaddingAttribute(PaddingType.Useless, 16)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding2;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField2 = new Explanation(name: "misc");
        
        [EditorMarkUpAttribute(displayName: "scale effects by")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public e_scale_effects_by scale_effects_by;
        
        [PaddingAttribute(PaddingType.Padding, 2)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding3;
        
        [EditorMarkUpAttribute(displayName: "angular noise", unitsSpecifier: "degrees", tooltipText: "the angle of incidence is randomly perturbed by at most this amount to simulate i" +
    "rregularity.")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float angular_noise;
        
        [EditorMarkUpAttribute(displayName: "velocity noise", unitsSpecifier: "world units per second", tooltipText: "the velocity is randomly perturbed by at most this amount to simulate irregularit" +
    "y.")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float velocity_noise;
        
        [EditorMarkUpAttribute(flags: EditorMarkUpFlags.Unknown1, displayName: "DO NOT USE (OLD detonation effect")]
        [TagReferenceAttribute("effe")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public TagReference do_not_use__old_detonation_effect;
        
        [PaddingAttribute(PaddingType.Useless, 24)]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public byte[] _padding4;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField3 = new Explanation(name: "penetration");
        
        [EditorMarkUpAttribute(displayName: "initial friction", tooltipText: "the fraction of the projectile\'s velocity lost on penetration")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float initial_friction;
        
        [EditorMarkUpAttribute(displayName: "maximum distance", tooltipText: "the maximum distance the projectile can travel through on object of this material" +
    "")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float maximum_distance;
        
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public Explanation _explanationField4 = new Explanation(name: "reflection");
        
        [EditorMarkUpAttribute(displayName: "parallel friction", tooltipText: "the fraction of the projectile\'s velocity parallel to the surface lost on impact")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float parallel_friction;
        
        [EditorMarkUpAttribute(displayName: "perpendicular friction", tooltipText: "the fraction of the projectile\'s velocity perpendicular to the surface lost on im" +
    "pact")]
        [EngineVersionAttribute(min: EngineVersion.Halo2Xbox, max: EngineVersion.Halo2Vista)]
        public float perpendicular_friction;
        
        [FlagsAttribute()]
        public enum b_flags : short
        {
            
            [EditorMarkUpAttribute(displayName: "cannot be overpenetrated")]
            cannot_be_overpenetrated = 0x1,
        }
        
        public enum e_response : short
        {
            
            [EditorMarkUpAttribute(flags: EditorMarkUpFlags.Unknown1, displayName: "impact (detonate")]
            impact__detonate = 0x0,
            
            [EditorMarkUpAttribute(displayName: "fizzle")]
            fizzle = 0x1,
            
            [EditorMarkUpAttribute(displayName: "overpenetrate")]
            overpenetrate = 0x2,
            
            [EditorMarkUpAttribute(displayName: "attach")]
            attach = 0x3,
            
            [EditorMarkUpAttribute(displayName: "bounce")]
            bounce = 0x4,
            
            [EditorMarkUpAttribute(flags: EditorMarkUpFlags.Unknown1, displayName: "bounce (dud")]
            bounce__dud = 0x5,
            
            [EditorMarkUpAttribute(flags: EditorMarkUpFlags.Unknown1, displayName: "fizzle (ricochet")]
            fizzle__ricochet = 0x6,
        }
        
        [FlagsAttribute()]
        public enum b_flags1 : short
        {
            
            [EditorMarkUpAttribute(displayName: "only against units")]
            only_against_units = 0x1,
            
            [EditorMarkUpAttribute(displayName: "never against units")]
            never_against_units = 0x2,
        }
        
        public enum e_scale_effects_by : short
        {
            
            [EditorMarkUpAttribute(displayName: "damage")]
            damage = 0x0,
            
            [EditorMarkUpAttribute(displayName: "angle")]
            angle = 0x1,
        }
    }
    #endregion
}
