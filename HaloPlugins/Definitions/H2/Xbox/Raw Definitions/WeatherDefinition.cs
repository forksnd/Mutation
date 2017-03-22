﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IO;
using HaloPlugins.Objects.Reference;

namespace HaloPlugins.H2.Xbox.Raw_Definitions
{
    public class WeatherDefinition : RawDefinition
    {
        public WeatherDefinition() : base() { }
        public WeatherDefinition(TagDefinition TagDef, EndianReader br) : base(TagDef) 
        {
            // Add New Stream
            base.AddStream("WeatherRaw");

            // Weather
            for (int i = 0; i < ((TagBlock)base.Owner[0]).BlockCount; i++)
            {
                // Get Values
                int Offset = (int)((TagBlock)base.Owner[0])[i][15].GetValue();
                int Size = (int)((TagBlock)base.Owner[0])[i][16].GetValue();

                // Double Check
                if ((Offset & 0xC0000000) == 0 && (Offset & 0x3FFFFFFF) > 0 && Size > 0)
                {
                    // Write new Offset
                    Offset &= 0x3FFFFFFF;
                    ((TagBlock)base.Owner[0])[i][15].SetValue((int)base["WeatherRaw"].Length);

                    // Write Raw
                    br.BaseStream.Position = Offset;
                    byte[] Buffer = br.ReadBytes(Size);
                    base["WeatherRaw"].Write(Buffer, 0, Buffer.Length);

                    // Write Padding
                    int Padding = 512 - ((int)base["WeatherRaw"].Length % 512);
                    if (Padding != 512) base["WeatherRaw"].Write(new byte[Padding], 0, Padding);
                }
            }
        }

        public override void FlushStream(string StreamName, int Ptr)
        {
            // Weather
            for (int i = 0; i < ((TagBlock)base.Owner[0]).BlockCount; i++)
            {
                // Get Values
                int Offset = (int)((TagBlock)base.Owner[0])[i][15].GetValue();
                int Size = (int)((TagBlock)base.Owner[0])[i][16].GetValue();

                // Double Check
                if ((Offset & 0xC0000000) == 0 && (Offset & 0x3FFFFFFF) > -1 && Size > 0)
                {
                    // Write new Offset
                    ((TagBlock)base.Owner[0])[i][15].SetValue(Offset + Ptr);
                }
            }
        }
    }
}
