﻿using Mutation.HEK.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mutation.Halo.TagGroups.Attributes
{
    public enum PaddingType
    {
        /// <summary>
        /// Represents padding of a certain length.
        /// </summary>
        Padding,
        /// <summary>
        /// Represents debug fields that are skipped by the engine during cache builds.
        /// </summary>
        Useless,
        /// <summary>
        /// Represents fields that are skipped for the gui interface.
        /// </summary>
        Skip
    }

    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class PaddingAttribute : Attribute
    {
        /// <summary>
        /// Gets the type of padding this field represents.
        /// </summary>
        public PaddingType Type { get; private set; }

        /// <summary>
        /// Gets the length of the padding field.
        /// </summary>
        public int Length { get; private set; }

        /// <summary>
        /// Specifies the padding properties for a padding field.
        /// </summary>
        /// <param name="type">Type of padding the field represents.</param>
        /// <param name="length">Length of the padding field.</param>
        public PaddingAttribute(PaddingType type, int length)
        {
            // Initialize fields.
            this.Type = type;
            this.Length = length;
        }

        public static int GetPaddingFieldSize(FieldInfo field)
        {
            // Get the custom attributes associated with this field.
            object[] attributes = field.GetCustomAttributes(typeof(PaddingAttribute), false);
            PaddingAttribute padding = (PaddingAttribute)attributes.First(x => x.GetType() == typeof(PaddingAttribute));

            // Return the padding size of the field.
            if (padding != null)
                return padding.Length;
            else
            {
                // There is no PaddingAttribute associated with this field.
                Console.WriteLine("[PaddingAttribute::GetPaddingFieldSize()] Tried to retrieve padding attribute from field '{0}' and failed!", field.Name);
                return 0;
            }
        }

        public static int GetPaddingFieldSize(Type type, string fieldName)
        {
            return GetPaddingFieldSize(type.GetField(fieldName));
        }

        public static PaddingType PaddingTypeFromFieldType(field_type fieldType)
        {
            // Return the corresponding PaddingType value for the field type.
            if (fieldType == field_type._field_pad)
                return PaddingType.Padding;
            else if (fieldType == field_type._field_skip)
                return PaddingType.Skip;
            else
                return PaddingType.Useless;
        }
    }
}
