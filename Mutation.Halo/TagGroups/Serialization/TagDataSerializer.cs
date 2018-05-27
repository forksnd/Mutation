using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Mutation.Halo.TagGroups.FieldTypes;
using Mutation.Halo.TagGroups.Attributes;

namespace Mutation.Halo.TagGroups.Serialization
{
    public enum SerializationFlags : int
    {
        // Underlying file type for the stream:
        FileType_CacheMap = 1,
        FileType_TagFile = 2,
        FileType_TagStream = 4,
        FileType_Raw = 8,

        // Operation that is being performed on the data:
        Operation_ReadInPlace = 0x10,
        Operation_WriteInPlace = 0x20,
        Operation_Compile = 0x40,
        Operation_Decompile = 0x80,
    }

    public class TagDataSerializer
    {
        /// <summary>
        /// Engine version the data should be serialized for.
        /// </summary>
        protected EngineVersion version;

        /// <summary>
        /// Initializes a new TagDataSerializer for the specified engine version.
        /// </summary>
        /// <param name="version">Engine version to serialize data for.</param>
        public void SerializeTag(EngineVersion version)
        {
            // Initialize fields.
            this.version = version;
        }

        public virtual void SerializeTag(ISerializationContext context, SerializationFlags flags, object tag)
        {
            // Begin serialization.
            BinaryWriter writer = context.BeginSerialiation(flags, null);

            // Create the field enumerator using the tag object.
            TagFieldEnumerator enumerator = new TagFieldEnumerator(tag);

            // Check the serialization flags and create the field iterator accordingly.
            TagFieldIterator iter = null;
            if ((flags & SerializationFlags.FileType_CacheMap) != 0)
            {
                // Writing data to a cache map, exclude any tag file only fields.
                iter = enumerator.CreateIterator(this.version, excludesFieldFlags: TagFieldFlags.TagFileOnly);
            }
            else if ((flags & SerializationFlags.FileType_TagFile) != 0)
            {
                // Writing data to a tag file, exclude any cache map only fields.
                iter = enumerator.CreateIterator(this.version, excludesFieldFlags: TagFieldFlags.CacheMapOnly);
            }
            else
            {
                // Iterate all fields.
                iter = enumerator.CreateIterator(this.version);
            }

            // Loop through all of the fields and serialize each one.
            for (; iter.HasNext(); iter++)
            {
                // Serialize the current field.
                SerializeValue(context, writer, flags, iter.CurrentField.GetValue(tag));
            }

            // End serialization.
            context.EndSerialization();
        }

        public virtual void SerializeBlock(ISerializationContext context, SerializationFlags flags, object block)
        {
            // Begin serialization.
            BinaryWriter writer = context.BeginSerialiation(flags, null);

            // Create the field enumerator using the block object.
            TagFieldEnumerator enumerator = new TagFieldEnumerator(block);

            // Check the serialization flags and create the field iterator accordingly.
            TagFieldIterator iter = null;
            if (flags.HasFlag(SerializationFlags.FileType_CacheMap) == true ||
                flags.HasFlag(SerializationFlags.FileType_TagStream) == true)
            {
                // Writing data from a cache map, exclude any tag file only fields.
                if (flags.HasFlag(SerializationFlags.FileType_Raw) == true)
                    iter = enumerator.CreateIterator(excludesFieldFlags: TagFieldFlags.TagFileOnly);
                else
                    iter = enumerator.CreateIterator(this.version, excludesFieldFlags: TagFieldFlags.TagFileOnly);
            }
            else if (flags.HasFlag(SerializationFlags.FileType_TagFile) == true)
            {
                // Writing data from a tag file, exclude any cache map only fields.
                if (flags.HasFlag(SerializationFlags.FileType_Raw) == true)
                    iter = enumerator.CreateIterator(excludesFieldFlags: TagFieldFlags.CacheMapOnly);
                else
                    iter = enumerator.CreateIterator(this.version, excludesFieldFlags: TagFieldFlags.CacheMapOnly);
            }
            else
            {
                // Iterate over all fields.
                if (flags.HasFlag(SerializationFlags.FileType_Raw) == true)
                    iter = enumerator.CreateIterator();
                else
                    iter = enumerator.CreateIterator(this.version);
            }

            // End serialization.
            context.EndSerialization();
        }

        /// <summary>
        /// Serializes a value to the stream.
        /// </summary>
        /// <param name="context">Serialization context</param>
        /// <param name="writer">Stream to write to</param>
        /// <param name="flags">Serialization flags</param>
        /// <param name="value">Value to serialize</param>
        private void SerializeValue(ISerializationContext context, BinaryWriter writer, SerializationFlags flags, object value)
        {
            // Check if the value is complex or primitive.
            if (value.GetType().IsArray == true)
            {
                // Get the padding attribute from the field.
                PaddingAttribute attribute = (PaddingAttribute)value.GetType().GetCustomAttributes(typeof(PaddingAttribute), false)[0];

                // If this is a useless padding field then there is nothing to do.
                if (attribute.Type == PaddingType.Useless)
                    return;

                // Write the padding data.
                writer.Write((byte[])value);
            }
            else if (value.GetType().IsPrimitive == true)
                SerializePrimitiveValue(context, writer, flags, value);
            else if (value.GetType().IsEnum == true)
                SerializePrimitiveValue(context, writer, flags, Enum.GetUnderlyingType(value.GetType()));
            else
                SerializeComplexValue(context, writer, flags, value);
        }

        /// <summary>
        /// Serializes a primitive value to the stream.
        /// </summary>
        /// <param name="context">Serialization context</param>
        /// <param name="writer">Stream to write to</param>
        /// <param name="flags">Serialization flags</param>
        /// <param name="value">Value to serialize</param>
        private void SerializePrimitiveValue(ISerializationContext context, BinaryWriter writer, SerializationFlags flags, object value)
        {
            // Get the type of object and handle accordingly.
            switch (Type.GetTypeCode(value.GetType()))
            {
                case TypeCode.Byte:     writer.Write((byte)value);      break;
                case TypeCode.SByte:    writer.Write((sbyte)value);     break;
                case TypeCode.Char:     writer.Write((char)value);      break;
                case TypeCode.UInt16:   writer.Write((ushort)value);    break;
                case TypeCode.Int16:    writer.Write((short)value);     break;
                case TypeCode.UInt32:   writer.Write((uint)value);      break;
                case TypeCode.Int32:    writer.Write((int)value);       break;
                case TypeCode.UInt64:   writer.Write((ulong)value);     break;
                case TypeCode.Int64:    writer.Write((long)value);      break;
                case TypeCode.Single:   writer.Write((float)value);     break;
                case TypeCode.Double:   writer.Write((double)value);    break;
                default:
                    {
                        // Unsupported primitive type.
                        throw new ArgumentException("Unsupported object type for serialization!");
                    }
            }
        }

        /// <summary>
        /// Serializes a comlex value to the stream.
        /// </summary>
        /// <param name="context">Serialization context</param>
        /// <param name="writer">Stream to write to</param>
        /// <param name="flags">Serialization flags</param>
        /// <param name="value">Value to serialize</param>
        private void SerializeComplexValue(ISerializationContext context, BinaryWriter writer, SerializationFlags flags, object value)
        {
            // TODO: Check if this field is an inline struct.

            // Get the type of object and handle accordingly.
            GuerillaTypeAttribute typeAtt = (GuerillaTypeAttribute)value.GetType().GetCustomAttributes(typeof(GuerillaTypeAttribute), false)[0];
            switch (typeAtt.FieldType)
            {
                // Bounds:
                case HEK.Common.field_type._field_angle_bounds:             writer.Write((AngleBounds)value); break;
                case HEK.Common.field_type._field_short_bounds:             writer.Write((ShortBounds)value); break;
                case HEK.Common.field_type._field_real_bounds:              writer.Write((RealBounds)value); break;
                case HEK.Common.field_type._field_real_fraction_bounds:     writer.Write((RealFractionBounds)value); break;

                // Colors:
                case HEK.Common.field_type._field_rgb_color:                writer.Write((ColorRgb)value); break;
                case HEK.Common.field_type._field_argb_color:               writer.Write((ColorArgb)value); break;
                case HEK.Common.field_type._field_real_rgb_color:           writer.Write((RealColorRgb)value); break;
                case HEK.Common.field_type._field_real_argb_color:          writer.Write((RealColorArgb)value); break;
                case HEK.Common.field_type._field_real_hsv_color:           writer.Write((RealColorHsv)value); break;
                case HEK.Common.field_type._field_real_ahsv_color:          writer.Write((RealColorAhsv)value); break;

                // Strings:
                case HEK.Common.field_type._field_string:                   writer.Write((String32)value); break;
                case HEK.Common.field_type._field_long_string:              writer.Write((String256)value); break;
                case HEK.Common.field_type._field_tag:                      writer.Write((GroupTag)value); break;

                // Vectors:
                case HEK.Common.field_type._field_point_2d:                 writer.Write((Point2d)value); break;
                case HEK.Common.field_type._field_rectangle_2d:             writer.Write((Rectangle2d)value); break;
                case HEK.Common.field_type._field_real_point_2d:            writer.Write((RealPoint2d)value); break;
                case HEK.Common.field_type._field_real_point_3d:            writer.Write((RealPoint3d)value); break;
                case HEK.Common.field_type._field_real_vector_2d:           writer.Write((RealVector2d)value); break;
                case HEK.Common.field_type._field_real_vector_3d:           writer.Write((RealVector3d)value); break;
                case HEK.Common.field_type._field_real_quaternion:          writer.Write((RealQuaternion)value); break;
                case HEK.Common.field_type._field_real_euler_angles_2d:     writer.Write((RealEulerAngle2d)value); break;
                case HEK.Common.field_type._field_real_euler_angles_3d:     writer.Write((RealEulerAngle3d)value); break;
                case HEK.Common.field_type._field_real_plane_2d:            writer.Write((RealPlane2d)value);   break;
                case HEK.Common.field_type._field_real_plane_3d:            writer.Write((RealPlane3d)value); break;

                // Misc:
                case HEK.Common.field_type._field_data:                     SerializeTagData(context, writer, flags, (TagData)value); break;
                //case HEK.Common.field_type._field_vertex_buffer:

                // references:
                case HEK.Common.field_type._field_datum_index:              writer.Write((datum_index)value); break;
                case HEK.Common.field_type._field_string_id:                SerializeStringId(context, writer, flags, (string_id)value); break;
                case HEK.Common.field_type._field_tag_reference:            SerializeTagReference(context, writer, flags, (TagReference)value); break;
                case HEK.Common.field_type._field_block:
                case HEK.Common.field_type._field_struct:                   SerializeTagBlock(context, writer, flags, (tag_block<object>)value); break;

                default:
                    {
                        // Unsupported complex field type.
                        throw new ArgumentException("Unsupported complex field type!");
                    }
            }
        }

        /// <summary>
        /// Serializes a string_id to the stream.
        /// </summary>
        /// <param name="context">Serialization context</param>
        /// <param name="writer">Stream to write to</param>
        /// <param name="flags">Serialization flags</param>
        /// <param name="value">string_id object to serialize</param>
        protected virtual void SerializeStringId(ISerializationContext context, BinaryWriter writer, SerializationFlags flags, string_id value)
        {
            // Check the flags to determine if we are reading a tag or map.
            if ((flags & SerializationFlags.FileType_CacheMap) != 0)
            {
                // Write a string_id handle to the map.
                writer.Write(value);
            }
            else if ((flags & SerializationFlags.FileType_TagFile) != 0)
            {
                // Resolve the string_id handle into a string constant.
                string constant = (string)context.ResolveReference(ReferenceType.StringId, value);

                // Write the string constant to the tag file.
                writer.WriteNullTerminatedString(constant, string_id.kSizeOfStringIdConstant);
            }
            else
            {
                // Unsupported serialization flags.
                throw new Exception("Unsupported serialization flags!");
            }
        }

        /// <summary>
        /// Serializes a tag_block to the stream.
        /// </summary>
        /// <param name="context">Serialization context</param>
        /// <param name="writer">Stream to write to</param>
        /// <param name="flags">Serialization flags</param>
        /// <param name="block">tag_block to be serialized</param>
        protected virtual void SerializeTagBlock(ISerializationContext context, BinaryWriter writer, SerializationFlags flags, tag_block<object> block)
        {
            // Check if there are any block to be written.
            if (block.Count > 0)
            {
                // Save the current position in the stream.
                long position = writer.BaseStream.Position;

                // Seek to the end of the stream.
                writer.BaseStream.Position = writer.BaseStream.Length;

                // Align the tag block as needed.
                writer.AlignTo(block.Alignment);
                block.Address = (uint)writer.BaseStream.Position;

                // Reserve the needed space for the tag block.
                int definitionSize = (flags.HasFlag(SerializationFlags.FileType_CacheMap) == true ? block.CacheFileSize : block.TagFileSize);
                writer.Write(new byte[block.Count * definitionSize]);

                // Seek to the start of the block data.
                writer.BaseStream.Position = block.Address;

                // Loop and write all the blocks to stream.
                for (int i = 0; i < block.Count; i++)
                {
                    // Write the current block to stream.
                    SerializeBlock(context, flags, block[i]);
                }

                // Restore the stream position to the block header.
                writer.BaseStream.Position = position;
            }

            // Write the block header.
            writer.Write(block.Count);
            writer.Write(block.Address);
        }

        /// <summary>
        /// Serializes a tag reference to the stream.
        /// </summary>
        /// <param name="context">Serialization stream</param>
        /// <param name="writer">Stream to write to</param>
        /// <param name="flags">Serialization flags</param>
        /// <param name="reference">TagReference to write</param>
        protected virtual void SerializeTagReference(ISerializationContext context, BinaryWriter writer, SerializationFlags flags, TagReference reference)
        {
            // Write the tag reference to the stream.
            writer.Write(reference.GroupTag);
            writer.Write(reference.Datum);
        }

        /// <summary>
        /// Serializes tag data to the stream.
        /// </summary>
        /// <param name="context">Serialization context</param>
        /// <param name="writer">Stream to write to</param>
        /// <param name="flags">Serialization flags</param>
        /// <param name="data">Tag data to write</param>
        protected virtual void SerializeTagData(ISerializationContext context, BinaryWriter writer, SerializationFlags flags, TagData data)
        {
            // Check if there is a data buffer that needs to be serialized.
            if (data.Size > 0)
            {
                // Save the current position in the stream.
                long position = writer.BaseStream.Position;

                // Seek to the end of stream.
                writer.BaseStream.Position = writer.BaseStream.Length;

                // Align the tag data as needed.
                writer.AlignTo(4);
                data.Address = (uint)writer.BaseStream.Position;

                // Write the tag data buffer.
                writer.Write(data.Data);

                // Restore the previous position in the file.
                writer.BaseStream.Position = position;
            }

            // Write the tag data header to the stream.
            writer.Write(data.Size);
            writer.Write(data.Address);
        }
    }
}
