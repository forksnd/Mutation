using Mutation.Halo.TagGroups.Attributes;
using Mutation.Halo.TagGroups.FieldTypes;
using Mutation.Halo.TagGroups.IO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mutation.Halo.TagGroups.Serialization
{
    public class TagDataDeserializer
    {
        /// <summary>
        /// Engine version the data we be deserialized for.
        /// </summary>
        protected EngineVersion version;

        /// <summary>
        /// Initializes a new TagDataDeserializer for the specified engine version.
        /// </summary>
        /// <param name="version"></param>
        public TagDataDeserializer(EngineVersion version)
        {
            // Initialize fields.
            this.version = version;
        }

        /// <summary>
        /// Deserializes the specified tag type from the stream.
        /// </summary>
        /// <typeparam name="T">Type of tag to deserialize</typeparam>
        /// <param name="context">Deserialization context</param>
        /// <param name="flags">Serialization flags</param>
        /// <returns>The deserialized tag</returns>
        public virtual T DeserializeTag<T>(ISerializationContext context, SerializationFlags flags)
        {
            // Begin deserialization.
            BinaryReader reader = context.BeginDeserialization(flags, null);

            // Deserialize the tag from the stream.
            T tag = (T)DeserializeTag(context, reader, flags, typeof(T));

            // End deserialization and return the tag.
            context.EndDeserialization();
            return tag;
        }

        /// <summary>
        /// Deserializes the specified tag type from the stream.
        /// </summary>
        /// <param name="context">Deserialization context</param>
        /// <param name="reader">Stream to read from</param>
        /// <param name="flags">Serialation flags</param>
        /// <param name="type">Type of tag to deserialize</param>
        /// <returns>The deserialized tag</returns>
        public virtual object DeserializeTag(ISerializationContext context, BinaryReader reader, SerializationFlags flags, Type type)
        {
            // Create a new instance of the object using the specified type.
            object tagInstance = Activator.CreateInstance(type);

            // Create a field enumerator that we can use to enumerate through the tag fields.
            TagFieldEnumerator enumerator = new TagFieldEnumerator(tagInstance);

            // Check the serialization flags and create the iterator accordingly.
            TagFieldIterator iter = null;
            if (flags.HasFlag(SerializationFlags.FileType_CacheMap) == true)
            {
                // Reading data from a cache map, exclude any tag file only fields.
                iter = enumerator.CreateIterator(this.version, excludesFieldFlags: TagFieldFlags.TagFileOnly);
            }
            else if (flags.HasFlag(SerializationFlags.FileType_TagFile) == true)
            {
                // Reading data from a tag file, exclude any cache map only fields.
                iter = enumerator.CreateIterator(this.version, excludesFieldFlags: TagFieldFlags.CacheMapOnly);
            }
            else
            {
                // Iterate over all fields.
                iter = enumerator.CreateIterator(this.version);
            }

            // Loop through all the fields and deserialize each one.
            for (; iter.HasNext(); iter++)
            {
                // Deserialize the current field.
                iter.CurrentField.SetValue(tagInstance, DeserializeValue(context, reader, flags, iter.CurrentField));

                // Check if the field is a reference type and if so validate it.
                if (iter.CurrentField.GetType() == typeof(TagReference) || iter.CurrentField.GetType() == typeof(datum_index))
                {
                    // Validate the tag reference.
                    if (context.ValidateReference(ReferenceType.DatumIndex, iter.CurrentField.GetValue(tagInstance)) == false)
                    {
                        // Tag reference or datum_index is invalid.
                        throw new InvalidDataException("TagReference or datum_index object is invalid");
                    }
                }
                else if (iter.CurrentField.GetType() == typeof(string_id))
                {
                    // Validate the string handle.
                    if (context.ValidateReference(ReferenceType.StringId, iter.CurrentField.GetValue(tagInstance)) == false)
                    {
                        // String id handle is invalid.
                        throw new InvalidDataException("String id handle is invalid");
                    }
                }
                else if (iter.CurrentField.GetType() == typeof(TagData))
                {
                    // Get the tag data object from the iterator.
                    dynamic tagData = iter.CurrentField.GetValue(tagInstance);

                    // Make sure the block count is not greater than the maximum allowed.
                    if (tagData.Size > tagData.MaxSize)
                    {
                        // Tag data size is greater than the maximum allowed.
                        throw new InvalidDataException("Tag data size is greater than the maximum allowed");
                    }
                }
            }

            // Return the tag instance that was deserialized.
            return tagInstance;
        }

        /// <summary>
        /// Deserializes a block of the specified type from the stream.
        /// </summary>
        /// <typeparam name="T">Type of object to deserialize</typeparam>
        /// <param name="context">Deserialization context</param>
        /// <param name="flags">Serialization flags</param>
        /// <returns>The derserialized object</returns>
        public virtual T DeserializeBlock<T>(ISerializationContext context, SerializationFlags flags)
        {
            // Begin serialization.
            BinaryReader reader = context.BeginDeserialization(flags, null);

            // Deserialize the block.
            T block = (T)DeserializeBlock(context, reader, flags, typeof(T));

            // End serialization and return the block instance.
            context.EndDeserialization();
            return block;
        }

        /// <summary>
        /// Deserializes a block of the specified type from the stream.
        /// </summary>
        /// <param name="context">Deserialization context</param>
        /// <param name="reader">Stream to read from</param>
        /// <param name="flags">Serialization flags</param>
        /// <param name="type">Type of object to deserialize</param>
        /// <returns>The deserialized object</returns>
        public virtual object DeserializeBlock(ISerializationContext context, BinaryReader reader, SerializationFlags flags, Type type)
        {
            // Create a new tag block object using the type specified.
            object tagBlock = Activator.CreateInstance(type);

            // Create a field enumerator that we can use to enumerate through the tag fields.
            TagFieldEnumerator enumerator = new TagFieldEnumerator(tagBlock);

            // Check the serialization flags and create the iterator accordingly.
            TagFieldIterator iter = null;
            if (flags.HasFlag(SerializationFlags.FileType_CacheMap) == true ||
                flags.HasFlag(SerializationFlags.FileType_TagStream) == true)
            {
                // Reading data from a cache map, exclude any tag file only fields.
                if (flags.HasFlag(SerializationFlags.FileType_Raw) == true)
                    iter = enumerator.CreateIterator(excludesFieldFlags: TagFieldFlags.TagFileOnly);
                else
                    iter = enumerator.CreateIterator(this.version, excludesFieldFlags: TagFieldFlags.TagFileOnly);
            }
            else if (flags.HasFlag(SerializationFlags.FileType_TagFile) == true)
            {
                // Reading data from a tag file, exclude any cache map only fields.
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

            // Loop through all the fields and deserialize each one.
            for (; iter.HasNext(); iter++)
            {
                // Deserialize the current field.
                iter.CurrentField.SetValue(tagBlock, DeserializeValue(context, reader, flags, iter.CurrentField));

                // Check if the field is a reference type and if so validate it.
                if (iter.CurrentField.GetType() == typeof(TagReference) || iter.CurrentField.GetType() == typeof(datum_index))
                {
                    // Validate the tag reference.
                    if (context.ValidateReference(ReferenceType.DatumIndex, iter.CurrentField.GetValue(tagBlock)) == false)
                    {
                        // Tag reference or datum_index is invalid.
                        throw new InvalidDataException("TagReference or datum_index object is invalid");
                    }
                }
                else if (iter.CurrentField.GetType() == typeof(string_id))
                {
                    // Validate the string handle.
                    if (context.ValidateReference(ReferenceType.StringId, iter.CurrentField.GetValue(tagBlock)) == false)
                    {
                        // String id handle is invalid.
                        throw new InvalidDataException("String id handle is invalid");
                    }
                }
                else if (iter.CurrentField.GetType() == typeof(TagData))
                {
                    // Get the tag data object from the iterator.
                    dynamic tagData = iter.CurrentField.GetValue(tagBlock);

                    // Make sure the block count is not greater than the maximum allowed.
                    if (tagData.Size > tagData.MaxSize)
                    {
                        // Tag data size is greater than the maximum allowed.
                        throw new InvalidDataException("Tag data size is greater than the maximum allowed");
                    }
                }
            }

            // Return the new tag block object that was deserialized.
            return tagBlock;
        }

        /// <summary>
        /// Deserializes an object of the specified type from the stream.
        /// </summary>
        /// <typeparam name="T">Type of object to deserialize</typeparam>
        /// <param name="context">Deserialization context</param>
        /// <param name="flags">Serialization flags</param>
        /// <returns>The deserialized object</returns>
        public virtual T DeserializeValue<T>(ISerializationContext context, SerializationFlags flags)
        {
            // Begin deserialization.
            BinaryReader reader = context.BeginDeserialization(flags, null);

            // Deserialize the object.
            T data = (T)DeserializeValue(context, reader, flags, typeof(T));

            // End deserialization and return the object.
            context.EndDeserialization();
            return data;
        }

        /// <summary>
        /// Deserializes the object from the stream.
        /// </summary>
        /// <param name="context">Deserialization context</param>
        /// <param name="reader">Stream to read from</param>
        /// <param name="flags">Serialization flags</param>
        /// <param name="Type">Type of field to deserialize</param>
        /// <returns></returns>
        public virtual object DeserializeValue(ISerializationContext context, BinaryReader reader, SerializationFlags flags, Type type)
        {
            // Check if the value is complex or primitive.
            if (type.IsPrimitive == true)
                return DeserializePrimitiveValue(context, reader, flags, type);
            else if (type.IsEnum == true)
                return DeserializePrimitiveValue(context, reader, flags, Enum.GetUnderlyingType(type));
            else
                return DeserializeComplexValue(context, reader, flags, type);
        }

        /// <summary>
        /// Deserializes the object from the stream.
        /// </summary>
        /// <param name="context">Deserialization context</param>
        /// <param name="reader">Stream to read from</param>
        /// <param name="flags">Serialization flags</param>
        /// <param name="field">Field to deserialize</param>
        /// <returns></returns>
        public virtual object DeserializeValue(ISerializationContext context, BinaryReader reader, SerializationFlags flags, FieldInfo field)
        {
            // Check if the value is complex or primitive.
            if (field.FieldType.IsArray == true)
            {
                // Get the padding attribute from the field.
                PaddingAttribute attribute = (PaddingAttribute)field.GetCustomAttributes(typeof(PaddingAttribute), false)[0];

                // If this is a useless padding field then return null.
                if (attribute.Type == PaddingType.Useless)
                    return null;

                // Read and return the padding data.
                return reader.ReadBytes(attribute.Length);
            }
            else if (field.FieldType.IsPrimitive == true)
                return DeserializePrimitiveValue(context, reader, flags, field.FieldType);
            else if (field.FieldType.IsEnum == true)
                return DeserializePrimitiveValue(context, reader, flags, Enum.GetUnderlyingType(field.FieldType));
            else
                return DeserializeComplexValue(context, reader, flags, field.FieldType);
        }

        /// <summary>
        /// Deserializes a primitive value from the stream.
        /// </summary>
        /// <param name="context">Deserialization context</param>
        /// <param name="reader">Stream to read from</param>
        /// <param name="flags">Serialization flags</param>
        /// <param name="type">Type of primitive to deserialize</param>
        /// <returns>The deserialized primitive</returns>
        protected virtual object DeserializePrimitiveValue(ISerializationContext context, BinaryReader reader, SerializationFlags flags, Type type)
        {
            // Get the type of object and handle accordingly.
            switch (Type.GetTypeCode(type))
            {
                case TypeCode.Byte:     return reader.ReadByte();
                case TypeCode.SByte:    return reader.ReadSByte();
                case TypeCode.Char:     return reader.ReadChar();
                case TypeCode.UInt16:   return reader.ReadUInt16();
                case TypeCode.Int16:    return reader.ReadInt16();
                case TypeCode.UInt32:   return reader.ReadUInt32();
                case TypeCode.Int32:    return reader.ReadInt32();
                case TypeCode.UInt64:   return reader.ReadUInt64();
                case TypeCode.Int64:    return reader.ReadInt64();
                case TypeCode.Single:   return reader.ReadSingle();
                case TypeCode.Double:   return reader.ReadDouble();
                default:
                    {
                        // Unsupported primitive type.
                        throw new ArgumentException("Unsupported object type for serialization!");
                    }
            }
        }

        /// <summary>
        /// Deserializes a complex value from the stream.
        /// </summary>
        /// <param name="context">Deserialization context</param>
        /// <param name="reader">Stream to read from</param>
        /// <param name="flags">Serialization flags</param>
        /// <param name="type">Object type to deserialize</param>
        /// <returns>The deserialized object</returns>
        protected virtual object DeserializeComplexValue(ISerializationContext context, BinaryReader reader, SerializationFlags flags, Type type)
        {
            // Check if this is a class and also has a TagBlockDefinition attribute.
            if (type.IsClass == true && type.GetCustomAttributes(typeof(TagBlockDefinitionAttribute), false).Count() > 0)
            {
                // Field is an inline struct.
                return DeserializeBlock(context, reader, flags, type);
            }

            // Get the GuerillaTypeAttribute for the type and handle accordingly.
            GuerillaTypeAttribute typeAtt = (GuerillaTypeAttribute)type.GetCustomAttributes(typeof(GuerillaTypeAttribute), false)[0];
            switch (typeAtt.FieldType)
            {
                // Bounds:
                case HEK.Common.field_type._field_angle_bounds:             return reader.ReadAngleBounds();
                case HEK.Common.field_type._field_short_bounds:             return reader.ReadShortBounds();
                case HEK.Common.field_type._field_real_bounds:              return reader.ReadRealBounds();
                case HEK.Common.field_type._field_real_fraction_bounds:     return reader.ReadRealFractionBounds();

                // Colors:
                case HEK.Common.field_type._field_rgb_color:                return reader.ReadColorRgb();
                case HEK.Common.field_type._field_argb_color:               return reader.ReadColorArgb();
                case HEK.Common.field_type._field_real_rgb_color:           return reader.ReadRealColorRgb();
                case HEK.Common.field_type._field_real_argb_color:          return reader.ReadRealColorArgb();
                case HEK.Common.field_type._field_real_hsv_color:           return reader.ReadRealColorHsv();
                case HEK.Common.field_type._field_real_ahsv_color:          return reader.ReadRealColorAhsv();

                // Strings:
                case HEK.Common.field_type._field_string:                   return reader.ReadString32();
                case HEK.Common.field_type._field_long_string:              return reader.ReadString256();
                case HEK.Common.field_type._field_tag:                      return reader.ReadGroupTag();

                // Vectors:
                case HEK.Common.field_type._field_point_2d:                 return reader.ReadPoint2d();
                case HEK.Common.field_type._field_rectangle_2d:             return reader.ReadRectangle2d();
                case HEK.Common.field_type._field_real_point_2d:            return reader.ReadRealPoint2d();
                case HEK.Common.field_type._field_real_point_3d:            return reader.ReadRealPoint3d();
                case HEK.Common.field_type._field_real_vector_2d:           return reader.ReadRealVector2d();
                case HEK.Common.field_type._field_real_vector_3d:           return reader.ReadRealVector3d();
                case HEK.Common.field_type._field_real_quaternion:          return reader.ReadRealQuaternion();
                case HEK.Common.field_type._field_real_euler_angles_2d:     return reader.ReadRealEulerAngle2d();
                case HEK.Common.field_type._field_real_euler_angles_3d:     return reader.ReadRealEulerAngle3d();
                case HEK.Common.field_type._field_real_plane_2d:            return reader.ReadRealPlane2d();
                case HEK.Common.field_type._field_real_plane_3d:            return reader.ReadRealPlane3d();

                // Misc:
                case HEK.Common.field_type._field_data:                     return DeserializeTagData(context, reader, flags, type);
                //case HEK.Common.field_type._field_vertex_buffer:

                // References:
                case HEK.Common.field_type._field_datum_index:              return reader.ReadDatumIndex();
                case HEK.Common.field_type._field_string_id:                return DeserializeStringId(context, reader, flags);
                case HEK.Common.field_type._field_tag_reference:            return DeserializeTagReference(context, reader, flags);
                case HEK.Common.field_type._field_block:
                case HEK.Common.field_type._field_struct:                   return DeserializeTagBlock(context, reader, flags, type);

                // Non-tag data:
                case HEK.Common.field_type._field_explanation:              return null;

                default:
                    {
                        // Unsupported complex field type.
                        throw new ArgumentException("Unsupported complex field type!");
                    }
            }
        }

        /// <summary>
        /// Deserializes a string_id from the stream.
        /// </summary>
        /// <param name="context">Deserialization context</param>
        /// <param name="reader">Stream to read from</param>
        /// <param name="flags">Serialization flags</param>
        /// <returns>A string_id that was read from the stream</returns>
        protected virtual string_id DeserializeStringId(ISerializationContext context, BinaryReader reader, SerializationFlags flags)
        {
            // Check the flags to determine if we are reading a tag or map.
            if (flags.HasFlag(SerializationFlags.FileType_CacheMap) == true ||
                flags.HasFlag(SerializationFlags.FileType_TagStream) == true)
            {
                // Read a normal string_id from the stream.
                return reader.ReadInt32();
            }
            else if (flags.HasFlag(SerializationFlags.FileType_TagFile) == true)
            {
                // Read the string constant from the stream.
                string constant = new string(reader.ReadChars(string_id.kSizeOfStringIdConstant)).TrimEnd(new char[] { '\0' });

                // Resolve the reference.
                return (string_id)context.ResolveReference(ReferenceType.StringId, constant);
            }
            else
            {
                // Unsupported serialization flags.
                throw new ArgumentException("Unsupported serialization flags!");
            }
        }

        /// <summary>
        /// Reads a TagReference object from the stream.
        /// </summary>
        /// <param name="context">Deserialization context</param>
        /// <param name="reader">Stream to read from</param>
        /// <param name="flags">Serialization flags</param>
        /// <returns>A TagReference object that was read from the stream</returns>
        protected virtual TagReference DeserializeTagReference(ISerializationContext context, BinaryReader reader, SerializationFlags flags)
        {
            // Create a new TagReference object.
            TagReference tagRef = new TagReference();

            // Read the tag reference from the stream.
            tagRef.GroupTag = reader.ReadGroupTag();
            tagRef.Datum = reader.ReadDatumIndex();

            // Return the tag reference object.
            return tagRef;
        }

        /// <summary>
        /// Deserializes a tag_block from the stream.
        /// </summary>
        /// <param name="context">Deserialization context</param>
        /// <param name="reader">Stream to read from</param>
        /// <param name="flags">Serialization flags</param>
        /// <param name="type">Underlying block type</param>
        /// <returns>The deserialized tag_block<></returns>
        protected virtual object DeserializeTagBlock(ISerializationContext context, BinaryReader reader, SerializationFlags flags, Type type)
        {
            // Create a new tag_block<T> instance using the type established.
            dynamic tagBlock = Activator.CreateInstance(type);

            // Read the tag_block header.
            int count = reader.ReadInt32();
            tagBlock.Address = reader.ReadUInt32();

            // Make sure the block count is within the max allowed.
            if (count > tagBlock.MaxBlockCount)
            {
                // Block count is greater than the max allowed.
                throw new InvalidDataException("Block count for tag_block is greater than the max allowed!");
            }

            // If we are reading this from a cache map then verify the tag block address is valid.
            if (flags.HasFlag(SerializationFlags.FileType_CacheMap) == true)
            {
                // Make sure the tag block address and size are within the bounds of the map stream.
                if (tagBlock.Address != 0 && (tagBlock.Address < (reader.BaseStream as VirtualMemoryStream).BaseAddress ||
                    tagBlock.Address + (count * tagBlock.CacheFileSize) > (reader.BaseStream as VirtualMemoryStream).BaseAddress + reader.BaseStream.Length))
                {
                    // Tag block address and size are out of the bounds of the map stream.
                    throw new InvalidDataException("Tag block address and size are out of bounds");
                }
            }

            // Check if there are any elements in the tag_block and if so read them.
            if (count > 0)
            {
                // Save the current position in the stream and seek to the tag_block data.
                long position = reader.BaseStream.Position;
                reader.BaseStream.Position = tagBlock.Address;

                // Loop and read all the elements in the tag_block.
                for (int i = 0; i < count; i++)
                {
                    // Read the current element from the stream.
                    tagBlock.Add(DeserializeBlock(context, reader, flags, tagBlock.Definition));
                }

                // Restore the previous position in the stream.
                reader.BaseStream.Position = position;
            }

            // Return the tag_block<T> instance.
            return tagBlock;
        }

        /// <summary>
        /// Deserializes tag data from the stream.
        /// </summary>
        /// <param name="context">Deserialization context</param>
        /// <param name="reader">Stream to read from</param>
        /// <param name="flags">Serialization flags</param>
        /// <param name="type">Underlying field type</param>
        /// <returns>The deserialized TagData object</returns>
        protected virtual TagData DeserializeTagData(ISerializationContext context, BinaryReader reader, SerializationFlags flags, Type type)
        {
            // Create a new TagData object using the field type provided.
            TagData data = (TagData)Activator.CreateInstance(type);

            // Read the tag data header.
            data.Size = reader.ReadInt32();
            data.Address = reader.ReadUInt32();

            // Check if there is any tag data to read.
            if (data.Size > 0)
            {
                // Save the current position in the stream and seek to the tag data.
                long position = reader.BaseStream.Position;
                reader.BaseStream.Position = data.Address;

                // Read the tag data buffer.
                data.Data = reader.ReadBytes(data.Size);

                // Seek to the previous position in the stream.
                reader.BaseStream.Position = position;
            }

            // Return the tag data object.
            return data;
        }
    }
}