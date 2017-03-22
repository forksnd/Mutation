using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HaloPlugins.Objects;
using HaloPlugins.Objects.Data;
using HaloPlugins.Objects.Reference;

namespace HaloPlugins.Xbox
{
    public class wigl : TagDefinition
    {
       public wigl() : base("wigl", "user_interface_shared_globals_definition", 452)
       {
           Fields.AddRange(new MetaNode[] {
           new Padding(68),
           new Value("Unknown", typeof(float)),
           new Value("Auto typing text: time", typeof(short)),
           new Value("Auto typing text: words per line", typeof(short)),
           new Value("Auto typing text: size", typeof(float)),
           new Value("Auto typing text: Alpha?", typeof(float)),
           new Value("Red", typeof(float)),
           new Value("Green", typeof(float)),
           new Value("Blue", typeof(float)),
           new Value("Unknown", typeof(float)),
           new Value("Blur blending speedUnknown", typeof(float)),
           new Value("Blur blending speedUnknown", typeof(float)),
           new Value("Blur color opacity", typeof(float)),
           new Value("Blur Red", typeof(float)),
           new Value("Blur Green", typeof(float)),
           new Value("Blur Blue", typeof(float)),
           new Value("Unused", typeof(float)),
           new Value("Unused", typeof(float)),
           new Value("Unused", typeof(float)),
           new TagBlock("Dialogs", 40, 100, new MetaNode[] { 
               new StringId("Dialog Group"),
               new Value("Unused", typeof(short)),
               new Value("Window type? (wgit palette)", typeof(short)),
               new TagReference("Unic_Text", "unic"),
               new StringId("Default Header"),
               new StringId("Default Content"),
               new StringId("Option 1"),
               new StringId("Option 2"),
               new TagBlock("Variations", 24, 100, new MetaNode[] { 
                   new Value("", typeof(short)),
                   new Value("", typeof(short)),
                   new Value("", typeof(short)),
                   new Value("", typeof(short)),
                   new StringId("Header"),
                   new StringId("Content"),
                   new StringId("Option 1"),
                   new StringId("Option 2"),
               }),
           }),
           new TagReference("Selection_Change_Sound_1", "snd!"),
           new TagReference("Forward_Sound_1", "snd!"),
           new TagReference("Unknown", "snd!"),
           new TagReference("Advance_Sound", "snd!"),
           new TagReference("Back_Sound", "snd!"),
           new TagReference("Shortcut_Sound", "snd!"),
           new TagReference("Selection_Change_Sound_2", "snd!"),
           new TagReference("Keyboard_Click_Sound", "snd!"),
           new TagReference("Message_Recieved_Sound", "snd!"),
           new TagReference("Forward_Sound_2", "snd!"),
           new TagReference("Countdown_Sound", "snd!"),
           new TagReference("Unused", "snd!"),
           new TagReference("Pickup_Health_Sound", "snd!"),
           new TagReference("Unused", "snd!"),
           new TagReference("Unused", "snd!"),
           new TagReference("Unused", "snd!"),
           new TagReference("Global_Bitmaps", "bitm"),
           new TagReference("Global_Unic", "unic"),
           new TagBlock("Virtual Keyboard Buttons settings", 44, 64, new MetaNode[] { 
               new Value("Unused", typeof(short)),
               new Value("Unused", typeof(short)),
               new Value("Selected button Brightness", typeof(short)),
               new Value("Unused", typeof(short)),
               new TagBlock("Button switching effects", 20, 64, new MetaNode[] { 
                   new Value("Unused", typeof(float)),
                   new Value("Unknown", typeof(float)),
                   new Value("Unknown", typeof(float)),
                   new Value("Unknown", typeof(float)),
                   new Value("Unknown", typeof(float)),
               }),
               new Value("Selected button Brightness", typeof(short)),
               new Value("Unused", typeof(short)),
               new TagBlock("Button switching effects", 20, 64, new MetaNode[] { 
                   new Value("Unused", typeof(float)),
                   new Value("Unknown", typeof(float)),
                   new Value("Unknown", typeof(float)),
                   new Value("Unknown", typeof(float)),
                   new Value("Unknown", typeof(float)),
               }),
               new Value("Unknown", typeof(short)),
               new Value("Unused", typeof(short)),
               new Value("Unknown", typeof(short)),
               new Value("Unused", typeof(short)),
               new TagBlock("Unused", 20, 64, new MetaNode[] { 
                   new Value("Unused", typeof(float)),
                   new Value("Unused", typeof(float)),
                   new Value("Unused", typeof(float)),
                   new Value("Unused", typeof(float)),
                   new Value("Unused", typeof(float)),
               }),
           }),
           new Padding(8),
           new TagBlock("Button effects?", 16, 100, new MetaNode[] { 
               new Value("Unused", typeof(short)),
               new Value("Unused", typeof(short)),
               new Value("Brightness", typeof(short)),
               new Value("Unused", typeof(short)),
               new TagBlock("Button switching effects?", 20, 64, new MetaNode[] { 
                   new Value("Unknown", typeof(short)),
                   new Value("Unused", typeof(short)),
                   new Value("Unknown", typeof(float)),
                   new Value("Unused", typeof(float)),
                   new Value("Unused", typeof(float)),
                   new Value("Unknown", typeof(float)),
               }),
           }),
           new TagBlock("Buttons Palette", 8, 32, new MetaNode[] { 
               new TagReference("Skin", "skin"),
           }),
           new TagReference("Keyboard_strings", "unic"),
           new TagReference("Built-in_Gametype_Names", "unic"),
           new TagReference("Unused", "****"),
           new TagBlock("Unknown", 4, 65535, new MetaNode[] { 
               new Value("Unknown", typeof(short)),
               new Value("Unknown", typeof(short)),
           }),
           new Value("Main window Header text #Font type#", typeof(short)),
           new Value("Pop up window Header text #Font type#", typeof(short)),
           new Value("Pop up window Confirmation dialog Header text #Font type#", typeof(short)),
           new Value("Unknown Header Fontype", typeof(short)),
           new Value("Unknown Header Fontype", typeof(float)),
           new Value("Red Header Tittle", typeof(float)),
           new Value("Green Header Tittle", typeof(float)),
           new Value("Blue Header Tittle", typeof(float)),
           new Value("Main Window Header text Coord Y", typeof(short)),
           new Value("Main window Header text Coord X", typeof(short)),
           new Value("Pop up window Confirmation dialog Header text Coord X", typeof(short)),
           new Value("Pop up window Confirmation dialog Header text Coord X", typeof(short)),
           new Value("Main window Buttons Coord Y", typeof(short)),
           new Value("Main window Buttons Coord x", typeof(short)),
           new Value("Main window Buttons Coord Y", typeof(short)),
           new Value("Main window Buttons Coord X", typeof(short)),
           new Value("Game setup Header text Coord Y", typeof(short)),
           new Value("Game setup Header text Coord X", typeof(short)),
           new Value("Pop up Confirmation dialog Header text Coord Y", typeof(short)),
           new Value("Pop up Confirmation dialog Header text Coord X", typeof(short)),
           new Value("Game setup Buttons Coord Y", typeof(short)),
           new Value("Game setup Buttons Coord X", typeof(short)),
           new Value("Keyboard window Buttons Coord Y", typeof(short)),
           new Value("Keyboard window Buttons Coord X", typeof(short)),
           new Value("Unknown Header text coords Y", typeof(short)),
           new Value("Unknown Header text coords X", typeof(short)),
           new Value("Unknown Header text coords Y", typeof(short)),
           new Value("Unknown Header text coords X", typeof(short)),
           new Value("Unknown Button coords Y", typeof(short)),
           new Value("Unknown Button coords X", typeof(short)),
           new Value("Campaign/gametype settings Pop Up dialog Button Y", typeof(short)),
           new Value("Campaign/gametype settings Pop Up dialog Button X", typeof(short)),
           new Value("Pop Up confirmation dialog Header Text Y", typeof(short)),
           new Value("Pop Up confirmation dialog Header Text X", typeof(short)),
           new Value("Unknown Header text coords Y", typeof(short)),
           new Value("Unknown Header text coords X", typeof(short)),
           new Value("Unknown Button coords Y", typeof(short)),
           new Value("Unknown Button coords X", typeof(short)),
           new Value("Pop up Confirmation dialog Button Coord Y", typeof(short)),
           new Value("Pop up Confirmation dialog Button Coord X", typeof(short)),
           new TagReference("Music", "lsnd"),
           new Value("Music duration time?", typeof(uint)),
           });
       }
    }
}
