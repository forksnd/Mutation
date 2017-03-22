using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HaloPlugins.Objects;
using HaloPlugins.Objects.Data;
using HaloPlugins.Objects.Reference;

namespace HaloPlugins.Xbox
{
    public class vehi : TagDefinition
    {
       public vehi() : base("vehi", "vehicle", 768)
       {
           // Unit
           Fields.AddRange(new unit().Fields.ToArray());

           // Vehi
           Fields.AddRange(new MetaNode[] {
           new Flags("Flags", new string[] { "Speed_Wakes_Physics", "Turn_Wakes_Physics", "Driver_Power_Wakes_Physics", "Gunner_Power_Wakes_Physics", "Control_Opposite_Speed_Sets_Brake", "Slide_Wakes_Physics", "Kills_Riders_at_Terminal_Velocity", "Causes_Collision_Damage", "AI_Weapon_Cannot_Rotate", "AI_Does_Not_Require_Driver", "AI_Unused", "AI_Driver_Enable", "AI_Driver_Flying", "AI_Driver_Can-Sidestep", "AI_Driver_Hovering", "Vehicle_Steers_Directly", "Unused", "Has_E-Brake", "Noncombat_Vehicle", "No_Friction_W/Driver", "Can_Trigger_Automatic_Opening_doors", "Autoaim_When_Teamless" }, 32),
           new HaloPlugins.Objects.Data.Enum("Type", new string[] { "Human_Tank", "Human_Jeep", "Human_Boat", "Human_Plane", "Covie_Scout", "Covie_Fighter", "Turret" }, 16),
           new HaloPlugins.Objects.Data.Enum("Control", new string[] { "Vehicle_Control_Normal", "Vehicle_Control_Unused", "Vehicle_Control_Tank" }, 16),
           new Value("Maximum Forward Speed", typeof(float)),
           new Value("Max Reverse Speed", typeof(float)),
           new Value("Speed Accel", typeof(float)),
           new Value("Speed Decel", typeof(float)),
           new Value("Max Left Turn", typeof(float)),
           new Value("Max Right Turn (negative)", typeof(float)),
           new Value("Wheel Circumference", typeof(float)),
           new Value("Turn Rate", typeof(float)),
           new Value("Blur Speed", typeof(float)),
           new HaloPlugins.Objects.Data.Enum("Specific Type", new string[] { "None", "Ghost", "Wraith", "Spectre", "Sentinal_Enforcer" }, 16),
           new HaloPlugins.Objects.Data.Enum("Player Training Vehicle Type", new string[] { "None", "Warthog", "Warthog_Turret", "Ghost", "Banshee", "Tank", "Wraith" }, 16),
           new StringId("Flip message"),
           new Value("Turn Scale", typeof(float)),
           new Value("Speed Turn Penalty Power (0.5 .. 2)", typeof(float)),
           new Value("Speed Turn Penalty (0 = none, 1 = can't turn at top speed)", typeof(float)),
           new Value("Maximum Left Slide", typeof(float)),
           new Value("Maximum Right Slide", typeof(float)),
           new Value("Slide Acceleration", typeof(float)),
           new Value("Slide Deceleration", typeof(float)),
           new Value("Minimum Flipping Angular Velocity", typeof(float)),
           new Value("Maximum Flipping Angular Velocity", typeof(float)),
           new HaloPlugins.Objects.Data.Enum("Vehicle Size", new string[] { "Small", "Large" }, 32),
           new Value("Fixed Gun Yaw", typeof(float)),
           new Value("Fixed Gun Pitch", typeof(float)),
           new Value("Steering Overdampening Cusp Angle (degrees)", typeof(float)),
           new Value("Steering Overdampening Exponent", typeof(float)),
           new Value("Crouch Transition Time (seconds)", typeof(float)),
           new Padding(4),
           new Value("Engine", typeof(float)),
           new Value("Engine Max Angular Velocity", typeof(float)),
           new TagBlock("Gears (0=Reverse, 1=1st Gear etc)", 68, 16, new MetaNode[] { 
               new Value("Loaded Torque - Min Torque", typeof(float)),
               new Value("Loaded Torque - Max Torque", typeof(float)),
               new Value("Loaded Torque - Peak Torque Scale", typeof(float)),
               new Value("Loaded Torque - Past Peak Torque Exponent", typeof(float)),
               new Value("Loaded Torque - Torque At Max Angular Velocity", typeof(float)),
               new Value("Loaded Torque - Torque At 2X Max Angular Velocity", typeof(float)),
               new Value("Cruising Torque - Min Torque", typeof(float)),
               new Value("Cruising Torque - Max Torque", typeof(float)),
               new Value("Cruising Torque - Peak Torque Scale", typeof(float)),
               new Value("Cruising Torque - Past Peak Torque Exponent", typeof(float)),
               new Value("Cruising Torque - Torque At Max Angular Velocity", typeof(float)),
               new Value("Cruising Torque - Torque At 2X Max Angular Velocity", typeof(float)),
               new Value("Min Time To Upshift", typeof(float)),
               new Value("Engine Up-Shift Scale", typeof(float)),
               new Value("Gear Ratio", typeof(float)),
               new Value("Min Time To Downshift", typeof(float)),
               new Value("Engine Down-Shift Scale", typeof(float)),
           }),
           new Value("Flying Torque Scale", typeof(float)),
           new Value("Seat Enterance Acceleration Scale", typeof(float)),
           new Value("Seat Exit Accelersation Scale", typeof(float)),
           new Value("Air Friction Deceleration", typeof(float)),
           new Value("Thrust Scale", typeof(float)),
           new TagReference("Suspension_Sound", "snd!"),
           new TagReference("Crash_Sound", "snd!"),
           new TagReference("unused", "foot"),
           new TagReference("Special_Effect", "effe"),
           new TagReference("Unused_Effect", "effe"),
           new Flags("Flags", new string[] { "Invaild" }, 32),
           new Value("Ground Friction", typeof(float)),
           new Value("Ground Depth", typeof(float)),
           new Value("Ground Damp Factor", typeof(float)),
           new Value("Ground Moving Friction", typeof(float)),
           new Value("Ground Maximum Slope 0", typeof(float)),
           new Value("Ground Maximum Slope 1", typeof(float)),
           new Padding(16),
           new Value("Anti Gravity Bank Lift", typeof(float)),
           new Value("Steering Bank Reaction Scale", typeof(float)),
           new Value("Gravity Scale", typeof(float)),
           new Value("Radius", typeof(float)),
           new TagBlock("Antigrav Points", 76, -1, new MetaNode[] { 
               new StringId("Marker Name"),
               new Flags("Flags", new string[] { "Gets_Damage_From_Region" }, 32),
               new Value("Antigrav Strength", typeof(float)),
               new Value("Antigrav Offset", typeof(float)),
               new Value("Antigrav Height", typeof(float)),
               new Value("Antigrav Damp Factor", typeof(float)),
               new Value("Antigrav Normal K1", typeof(float)),
               new Value("Antigrav Normal K0", typeof(float)),
               new Value("Radius", typeof(float)),
               new Padding(16),
               new StringId("Damage Source Region Name"),
               new Value("Default State Error", typeof(float)),
               new Value("Minor Damage Error", typeof(float)),
               new Value("Medium Damage Error", typeof(float)),
               new Value("Major Damage Error", typeof(float)),
               new Value("Destoryed State Error", typeof(float)),
           }),
           new TagBlock("Friction Points", 76, -1, new MetaNode[] { 
               new StringId("Marker Name"),
               new Flags("Flags", new string[] { "Gets_Damage_From_Region", "Powered", "Front_Turning", "Rear_Turning", "Attached_To_E-Brake", "Can_Be_Destroyed" }, 32),
               new Value("Fraction Of Total Mass", typeof(float)),
               new Value("Radius", typeof(float)),
               new Value("Damaged Radius", typeof(float)),
               new HaloPlugins.Objects.Data.Enum("Friction Type", new string[] { "Point", "Forward" }, 32),
               new Value("Moving Friction Velocity Diff", typeof(float)),
               new Value("E-Brake Moving Friction", typeof(float)),
               new Value("E-Brake Friction", typeof(float)),
               new Value("E-Brake Moving Friction Vel Diff", typeof(float)),
               new Padding(20),
               new StringId("Collision Global Material Name"),
               new HaloPlugins.Objects.Data.Enum("Model State Destroyed", new string[] { "Default", "Minor_Damage", "Medium_Damage", "Major_Damage", "Destroyed" }, 32),
               new StringId("Region"),
               new Padding(4),
           }),
           new TagBlock("Havok Vehicle Physics", 672, -1, 16, new MetaNode[] { 
               new Value("Size", typeof(short)),
               new Value("Count", typeof(short)),
               new Value("Child Shapes Size", typeof(int)),
               new Value("Child Shapes Capacity", typeof(int)),
               new HaloPlugins.Objects.Data.Enum("Shape Type", new string[] {  }, 32),
               new HaloPlugins.Objects.Data.Enum("Shape", new string[] {  }, 32),
               new Value("Collision Filter", typeof(int)),
               new HaloPlugins.Objects.Data.Enum("Shape Type", new string[] {  }, 32),
               new HaloPlugins.Objects.Data.Enum("Shape", new string[] {  }, 32),
               new Value("Collision Filter", typeof(int)),
               new HaloPlugins.Objects.Data.Enum("Shape Type", new string[] {  }, 32),
               new HaloPlugins.Objects.Data.Enum("Shape", new string[] {  }, 32),
               new Value("Collision Filter", typeof(int)),
               new HaloPlugins.Objects.Data.Enum("Shape Type", new string[] {  }, 32),
               new HaloPlugins.Objects.Data.Enum("Shape", new string[] {  }, 32),
               new Value("Collision Filter", typeof(float)),
               new Value("Multisphere Count", typeof(int)),
               new Flags("Flags", new string[] { "Has_AABB_Phantom", "BORK_BORK_BORK!" }, 32),
               new Padding(4),
               new Value("X0", typeof(float)),
               new Value("X1", typeof(float)),
               new Value("Y0", typeof(float)),
               new Value("Y1", typeof(float)),
               new Value("Z0", typeof(float)),
               new Value("Z1", typeof(float)),
               new Value("Initialized at RunTime", typeof(int)),
               new Value("Initialized at RunTime", typeof(int)),
               new Value("Size", typeof(short)),
               new Value("Count", typeof(short)),
               new Value("Num Of Spheres", typeof(int)),
               new Value("Sphere 0 i", typeof(float)),
               new Value("Sphere 0 j", typeof(float)),
               new Value("Sphere 0 k", typeof(float)),
               new Value("Sphere 1 i", typeof(float)),
               new Value("Sphere 1 j", typeof(float)),
               new Value("Sphere 1 k", typeof(float)),
               new Value("Sphere 2 i", typeof(float)),
               new Value("Sphere 2 j", typeof(float)),
               new Value("Sphere 2 k", typeof(float)),
               new Value("Sphere 3 i", typeof(float)),
               new Value("Sphere 3 j", typeof(float)),
               new Value("Sphere 3 k", typeof(float)),
               new Value("Sphere 4 i", typeof(float)),
               new Value("Sphere 4 j", typeof(float)),
               new Value("Sphere 4 k", typeof(float)),
               new Value("Sphere 5 i", typeof(float)),
               new Value("Sphere 5 j", typeof(float)),
               new Value("Sphere 5 k", typeof(float)),
               new Value("Sphere 6 i", typeof(float)),
               new Value("Sphere 6 j", typeof(float)),
               new Value("Sphere 6 k", typeof(float)),
               new Value("Sphere 7 i", typeof(float)),
               new Value("Sphere 7 j", typeof(float)),
               new Value("Sphere 7 k", typeof(float)),
               new Value("Sphere 8 i", typeof(float)),
               new Value("Sphere 8 j", typeof(float)),
               new Value("Sphere 8 k", typeof(float)),
               new Value("Sphere 9 i", typeof(float)),
               new Value("Sphere 9 j", typeof(float)),
               new Value("Sphere 9 k", typeof(float)),
               new Value("Sphere 10 i", typeof(float)),
               new Value("Sphere 10 j", typeof(float)),
               new Value("Sphere 10 k", typeof(float)),
               new Value("Size", typeof(short)),
               new Value("Count", typeof(short)),
               new Value("Num Of Spheres", typeof(int)),
               new Value("Sphere 1 i", typeof(float)),
               new Value("Sphere 1 j", typeof(float)),
               new Value("Sphere 1 k", typeof(float)),
               new Value("Sphere 2 i", typeof(float)),
               new Value("Sphere 2 j", typeof(float)),
               new Value("Sphere 2 k", typeof(float)),
               new Value("Sphere 3 i", typeof(float)),
               new Value("Sphere 3 j", typeof(float)),
               new Value("Sphere 3 k", typeof(float)),
               new Value("Sphere 4 i", typeof(float)),
               new Value("Sphere 4 j", typeof(float)),
               new Value("Sphere 4 k", typeof(float)),
               new Value("Sphere 5 i", typeof(float)),
               new Value("Sphere 5 j", typeof(float)),
               new Value("Sphere 5 k", typeof(float)),
               new Value("Sphere 6 i", typeof(float)),
               new Value("Sphere 6 j", typeof(float)),
               new Value("Sphere 6 k", typeof(float)),
               new Value("Sphere 7 i", typeof(float)),
               new Value("Sphere 7 j", typeof(float)),
               new Value("Sphere 7 k", typeof(float)),
               new Value("Sphere 8 i", typeof(float)),
               new Value("Sphere 8 j", typeof(float)),
               new Value("Sphere 8 k", typeof(float)),
               new Value("Sphere 9 i", typeof(float)),
               new Value("Sphere 9 j", typeof(float)),
               new Value("Sphere 9 k", typeof(float)),
               new Value("Sphere 10 i", typeof(float)),
               new Value("Sphere 10 j", typeof(float)),
               new Value("Sphere 10 k", typeof(float)),
               new Value("Size", typeof(short)),
               new Value("Count", typeof(short)),
               new Value("Num Of Spheres", typeof(int)),
               new Value("Sphere 1 i", typeof(float)),
               new Value("Sphere 1 j", typeof(float)),
               new Value("Sphere 1 k", typeof(float)),
               new Value("Sphere 2 i", typeof(float)),
               new Value("Sphere 2 j", typeof(float)),
               new Value("Sphere 2 k", typeof(float)),
               new Value("Sphere 3 i", typeof(float)),
               new Value("Sphere 3 j", typeof(float)),
               new Value("Sphere 3 k", typeof(float)),
               new Value("Sphere 4 i", typeof(float)),
               new Value("Sphere 4 j", typeof(float)),
               new Value("Sphere 4 k", typeof(float)),
               new Value("Sphere 5 i", typeof(float)),
               new Value("Sphere 5 j", typeof(float)),
               new Value("Sphere 5 k", typeof(float)),
               new Value("Sphere 6 i", typeof(float)),
               new Value("Sphere 6 j", typeof(float)),
               new Value("Sphere 6 k", typeof(float)),
               new Value("Sphere 7 i", typeof(float)),
               new Value("Sphere 7 j", typeof(float)),
               new Value("Sphere 7 k", typeof(float)),
               new Value("Sphere 8 i", typeof(float)),
               new Value("Sphere 8 j", typeof(float)),
               new Value("Sphere 8 k", typeof(float)),
               new Value("Sphere 9 i", typeof(float)),
               new Value("Sphere 9 j", typeof(float)),
               new Value("Sphere 9 k", typeof(float)),
               new Value("Sphere 10 i", typeof(float)),
               new Value("Sphere 10 j", typeof(float)),
               new Value("Sphere 10 k", typeof(float)),
               new Value("Size", typeof(short)),
               new Value("Count", typeof(short)),
               new Value("Num Of Spheres", typeof(int)),
               new Value("For", typeof(float)),
               new Value("Any", typeof(float)),
               new Value("One", typeof(float)),
               new Value("Who", typeof(float)),
               new Value("Cares", typeof(float)),
               new Value("This Reflexive Isn't 100% Accurate", typeof(float)),
               new Value("Size", typeof(short)),
               new Value("Count", typeof(short)),
               new Value("Num Of Spheres", typeof(int)),
               new Value("Sphere 0 ", typeof(float)),
               new Value("Sphere 0 ", typeof(float)),
               new Value("Sphere 0 ", typeof(float)),
               new Value("Sphere 1 ", typeof(float)),
               new Value("Sphere 1 ", typeof(float)),
               new Value("Sphere 1 ", typeof(float)),
               new Value("Sphere 2 ", typeof(float)),
               new Value("Sphere 2 ", typeof(float)),
               new Value("Sphere 2 ", typeof(float)),
               new Value("Sphere 3 ", typeof(float)),
               new Value("Sphere 3 ", typeof(float)),
               new Value("Sphere 3 ", typeof(float)),
               new Value("Sphere 4 ", typeof(float)),
               new Value("Sphere 4 ", typeof(float)),
               new Value("Sphere 4 ", typeof(float)),
               new Value("Sphere 5 ", typeof(float)),
               new Value("Sphere 5 ", typeof(float)),
               new Value("Sphere 5 ", typeof(float)),
               new Value("Sphere 6 ", typeof(float)),
               new Value("Sphere 6 ", typeof(float)),
               new Value("Sphere 6 ", typeof(float)),
               new Value("Sphere 7 ", typeof(float)),
               new Value("Sphere 7 ", typeof(float)),
               new Value("Sphere 7 ", typeof(float)),
               new Value("Sphere 8 ", typeof(float)),
               new Value("Sphere 8 ", typeof(float)),
               new Value("Sphere 8 ", typeof(float)),
               new Value("Sphere 9 ", typeof(float)),
               new Value("Sphere 9 ", typeof(float)),
               new Value("Sphere 9 ", typeof(float)),
               new Value("Sphere 10 ", typeof(float)),
               new Value("Sphere 10 ", typeof(float)),
               new Value("Sphere 10 ", typeof(float)),
           }),
           });
       }
    }
}
