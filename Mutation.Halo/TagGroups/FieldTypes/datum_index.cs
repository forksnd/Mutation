using Mutation.Halo.TagGroups.Attributes;
using Mutation.HEK.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Mutation.Halo.TagGroups.FieldTypes
{
    [GuerillaType(field_type._field_datum_index)]
    [StructLayout(LayoutKind.Explicit, Size = kSizeOf)]
    public struct datum_index
    {
        public const uint NONE = 0xFFFFFFFF;

        public const uint _k_starting_datum_index = 0xE1740000;

        /// <summary>
        /// Size of the datum_index struct.
        /// </summary>
        public const int kSizeOf = 4;

        /// <summary>
        /// The 32bit datum_index handle value.
        /// </summary>
        [FieldOffset(0)]
        public uint datum;

        /// <summary>
        /// Absolute index of the datum_index handle.
        /// </summary>
        [FieldOffset(0)]
        public ushort index;

        /// <summary>
        /// Salt value of the datum_index handle.
        /// </summary>
        [FieldOffset(2)]
        public short salt;

        /// <summary>
        /// Creates a new datum_index object using the specfied index and salt.
        /// </summary>
        /// <param name="index">Absolute index of the datum_index.</param>
        /// <param name="salt">Identifier of the datum_index.</param>
        public datum_index(ushort index, short salt)
        {
            // Satisfy the compiler.
            this.datum = 0;

            // Assign the index and salt.
            this.index = index;
            this.salt = salt;
        }

        /// <summary>
        /// Creates a new datum_index object using the specified handle value.
        /// </summary>
        /// <param name="datum">Handle value of the datum_index.</param>
        public datum_index(uint datum)
        {
            // Satisfy the compiler.
            this.index = 0;
            this.salt = 0;

            // Assign the handle.
            this.datum = datum;
        }

        /// <summary>
        /// Gets the index field of the datum_index handle.
        /// </summary>
        /// <returns>Absolute index of the datum_index handle.</returns>
        public ushort ToIndex()
        {
            return index;
        }

        /// <summary>
        /// Gets the identifier field of the datum_index handle.
        /// </summary>
        /// <returns>Unique identifier of the datum_index handle.</returns>
        public short ToIdentifier()
        {
            return salt;
        }

        /// <summary>
        /// Compares two datum_index objects for equality.
        /// </summary>
        /// <param name="lhs">Left hand datum_index for comparison.</param>
        /// <param name="rhs">Right hand datum_index for comparison.</param>
        /// <returns>True if the DatumIndexes are equal, false otherwise.</returns>
        public static bool operator ==(datum_index lhs, datum_index rhs)
        {
            return lhs.datum == rhs.datum;
        }

        /// <summary>
        /// Compares two datum_index objects for inequality.
        /// </summary>
        /// <param name="lhs">Left hand datum_index for comparison.</param>
        /// <param name="rhs">Right hand datum_index for comparison.</param>
        /// <returns>True if the DatumIndexes are not equal, false otherwise.</returns>
        public static bool operator !=(datum_index lhs, datum_index rhs)
        {
            return lhs.datum != rhs.datum;
        }

        /// <summary>
        /// Increments the datum index and salt by 1.
        /// </summary>
        /// <param name="datum"></param>
        /// <returns></returns>
        public static datum_index operator ++(datum_index datum)
        {
            // Copy datum value.
            datum_index newDatum = new datum_index((ushort)(datum.index + 1), (short)(datum.salt + 1));
            return newDatum;
        }

        /// <summary>
        /// Implicit cast to a signed integer.
        /// </summary>
        /// <param name="datum">datum_index to cast.</param>
        /// <returns>Value of the datum_index as a signed integer.</returns>
        public static implicit operator int(datum_index datum)
        {
            return (int)((datum.salt << 24) & 0xff000000) | ((datum.salt << 8) & 0x00ff0000) |
                        ((datum.index >> 8) & 0x0000ff00) | ((datum.index >> 24) & 0x000000ff);
        }

        /// <summary>
        /// Explicit cast to an unsigned integer.
        /// </summary>
        /// <param name="datum">datum_index to cast.</param>
        /// <returns>Value of the datum_index as an unsigned integer.</returns>
        public static explicit operator uint(datum_index datum)
        {
            return datum.datum;
        }

        /// <summary>
        /// Implicit cast from a unsigned integer to a datum_index object.
        /// </summary>
        /// <param name="handle">Handle value of the datum_index.</param>
        /// <returns>A datum_index object initialized with the handle value provided.</returns>
        public static implicit operator datum_index(uint handle)
        {
            return new datum_index(handle);
        }

        /// <summary>
        /// Compares this datum_index to another object for equality.
        /// </summary>
        /// <param name="obj">Other object to compare to.</param>
        /// <returns>A boolean indicating that both objects are equal.</returns>
        public override bool Equals(object obj)
        {
            // Check that the other object is of the same type and is not null.
            if (obj == null || obj.GetType() != typeof(datum_index))
                return false;

            // Cast it to a datum_index and compare.
            datum_index other = (datum_index)obj;
            return this.datum == other.datum;
        }

        /// <summary>
        /// Gets a hashcode for this datum_index object.
        /// </summary>
        /// <returns>Hashcode of this datum_index.</returns>
        public override int GetHashCode()
        {
            return this;
        }

        public override string ToString()
        {
            return string.Format("Datum=0x{0}", this.datum.ToString("X"));
        }
    }
}
