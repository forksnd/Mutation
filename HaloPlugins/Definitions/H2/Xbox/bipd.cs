using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HaloPlugins.Objects;
using HaloPlugins.Objects.Data;
using HaloPlugins.Objects.Reference;
using HaloPlugins.Objects.Vector;

namespace HaloPlugins.Xbox
{
    public class bipd : TagDefinition
    {
       public bipd() : base("bipd", "biped", 788)
       {
           // Unit
           Fields.AddRange(new unit().Fields.ToArray());

           // Bipd
           Fields.AddRange(new MetaNode[] {
           new InfoBlock("<--- Biped --->"),
           new Value("Moving Turning Speed (Degrees Per Second)", typeof(float)),
           new Flags("Flags", new string[] { "Turns_Without_Animating", "Passes_Through_Other_Bipeds", "Immune_To_Falling_Damage", "Rotate_While_Airborne", "Use_Limp_Body_Physics", "unused", "Random_Speed_Increase", "unused", "Spawn_Death_Children_On_Destroy", "Stunned_by_emp_damage(RD1)", "Dead_Physics_When_Stunned(RD2)", "Always_Ragdoll_When_Dead(RD3)" }, 32),
           new Value("Stationary Turning Threshold", typeof(float)),
           new Value("Jump Velocity", typeof(float)),
           new Value("Max Soft Landing Time", typeof(float)),
           new Value("Max Hard Landing Time", typeof(float)),
           new Value("Min Soft Landing Velocity", typeof(float)),
           new Value("Min Hard Landing Velocity", typeof(float)),
           new Value("Max Hard Landing Velocity", typeof(float)),
           new Value("Death Hard Landing Velocity", typeof(float)),
           new Value("Stun Duration", typeof(float)),
           new Value("Standing Camera Height", typeof(float)),
           new Value("Crouching Camera Height", typeof(float)),
           new Value("Crouch Trasition Time", typeof(float)),
           new Value("Camera Interpolation Start", typeof(float)),
           new Value("Camera Interpolation End", typeof(float)),
           new Value("Camera Forward Movement Scale", typeof(float)),
           new Value("Camera Side Movement Scale", typeof(float)),
           new Value("Camera Vertical Movement Scale", typeof(float)),
           new Value("Camera Exclusion Distance", typeof(float)),
           new Value("Autoaim Width", typeof(float)),
           new Flags("Flags", new string[] { "Locked_By_Human_Targeting", "Locked_By_Plasma_Targeting", "Always_Locked_By_Human_Targeting" }, 32),
           new Value("Lock On Distance", typeof(float)),
           new Padding(16),
           new Value("Head Shot Acc Scale", typeof(float)),
           new TagReference("Area_Damage_Effect", "effe"),
           new Flags("Flags", new string[] { "Centered_At_Origin", "Shape_Sperical", "Use_Player_Physics", "Climb_Any_Surface", "Flying", "Not_Physical", "Dead_Character_Collision_Group" }, 32),
           new Value("Height Standing", typeof(float)),
           new Value("Height Crouching", typeof(float)),
           new Value("Radius", typeof(float)),
           new Value("Mass", typeof(float)),
           new StringId("Living Material Name"),
           new StringId("Dead Material Name"),
           new Padding(4),
           new TagBlock("Contact Points", 128, 3, 16, new MetaNode[] {
               new StringId("Name"),
               new Value("Material #", typeof(short)),
               new HaloPlugins.Objects.Data.Enum("Flags", new string[] { "unused" }, 16),
               new Value("Relative Mass Scale", typeof(float)),
               new Value("Friction", typeof(float)),
               new Value("Restitution", typeof(float)),
               new Value("Volume", typeof(float)),
               new Value("Mass", typeof(float)),
               new Value("Phantom", typeof(short)),
               new Value("Size", typeof(short)),
               new Value("Count", typeof(short)),
               new Value("Radius", typeof(float)),
               new Value("Size", typeof(short)),
               new Value("Count", typeof(short)),
               new Value("Rotation i i", typeof(float)),
               new Value("Rotation i j", typeof(float)),
               new Value("Rotation i k", typeof(float)),
               new Value("Rotation j i", typeof(float)),
               new Value("Rotation j j", typeof(float)),
               new Value("Rotation j k", typeof(float)),
               new Value("Rotation k i", typeof(float)),
               new Value("Rotation k j", typeof(float)),
               new Value("Rotation k k", typeof(float)),
               new Value("Translation i", typeof(float)),
               new Value("Translation j", typeof(float)),
               new Value("Translation k", typeof(float)),
               new Padding(38),
           }),
           new TagBlock("Pill Shapes", 80, 1024, new MetaNode[] { //16
               new StringId("Name"),
               new Value("Material #", typeof(short)),
               new HaloPlugins.Objects.Data.Enum("Flags", new string[] { "unused" }, 16),
               new Value("Relative Mass Scale", typeof(float)),
               new Value("Friction", typeof(float)),
               new Value("Restitution", typeof(float)),
               new Value("Volume", typeof(float)),
               new Value("Mass", typeof(float)),
               new Value("Phantom", typeof(short)),
               new Value("Size", typeof(short)),
               new Value("Count", typeof(short)),
               new Value("Radius", typeof(float)),
               new Value("Size", typeof(short)),
               new Value("Count", typeof(short)),
               new RealVector3d("Bottom"),
               new RealVector3d("Top"),
               new Padding(14),
           }),
           new TagBlock("Sphere Shapes", 128, -1, new MetaNode[] { //16
               new StringId("Name"),
               new Value("Material #", typeof(short)),
               new HaloPlugins.Objects.Data.Enum("Flags", new string[] { "unused" }, 16),
               new Value("Relative Mass Scale", typeof(float)),
               new Value("Friction", typeof(float)),
               new Value("Restitution", typeof(float)),
               new Value("Volume", typeof(float)),
               new Value("Mass", typeof(float)),
               new Value("Phantom", typeof(short)),
               new Value("Size", typeof(short)),
               new Value("Count", typeof(short)),
               new Value("Radius", typeof(float)),
               new Value("Size", typeof(short)),
               new Value("Count", typeof(short)),
               new Value("Rotation i i", typeof(float)),
               new Value("Rotation i j", typeof(float)),
               new Value("Rotation i k", typeof(float)),
               new Value("Rotation j i", typeof(float)),
               new Value("Rotation j j", typeof(float)),
               new Value("Rotation j k", typeof(float)),
               new Value("Rotation k i", typeof(float)),
               new Value("Rotation k j", typeof(float)),
               new Value("Rotation k k", typeof(float)),
               new Value("Translation i", typeof(float)),
               new Value("Translation j", typeof(float)),
               new Value("Translation  k", typeof(float)),
               new Padding(38),
           }),
           new Value("Max Slope Angle", typeof(float)),
           new Value("Downhill Falloff Angle", typeof(float)),
           new Value("Downhill Cutoff Angle", typeof(float)),
           new Value("Uphill Falloff Angle", typeof(float)),
           new Value("Uphill Cutoff Angle", typeof(float)),
           new Value("Downhill Velocity Angle", typeof(float)),
           new Value("Uphill Velocity Scale", typeof(float)),
           new Value("Flying Bank Angle", typeof(float)),
           new Value("Flying Bank Apply Time", typeof(float)),
           new Value("Flying Pitch Ratio", typeof(float)),
           new Value("Flying Max Velocity", typeof(float)),
           new Value("Flying Max Sidestep Velocity", typeof(float)),
           new Value("Flying Acceleration", typeof(float)),
           new Value("Flying Deceleration", typeof(float)),
           new Value("Flying Angular Velocity Max", typeof(float)),
           new Value("Flying Angular Acceleration Max", typeof(float)),
           new Value("Flying Crouch Velocity Modifier", typeof(float)),
           new Padding(24),
           new TagBlock("Contact Points", 4, 3, new MetaNode[] { 
               new StringId("Marker"),
           }),
           new TagReference("Reanimation_Character", "char"),
           new TagReference("Death_Spawn_Character", "char"),
           new Value("Spawn Count", typeof(short)),
           new Padding(2),
           });
       }
    }
}
