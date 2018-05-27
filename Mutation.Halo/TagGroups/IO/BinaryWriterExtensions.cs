using Mutation.Halo.TagGroups.FieldTypes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutation.Halo
{
    public static class BinaryWriterExtensions
    {
        /// <summary>
        /// Writes the specified string to the stream followed by a null terminator.
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="value">String value to write</param>
        public static void WriteNullTerminatedString(this BinaryWriter writer, string value)
        {
            // Write the string followed by a null character.
            writer.Write(value.ToCharArray());
            writer.Write((byte)0);
        }

        public static void Write(this BinaryWriter writer, ShortBounds bounds)
        {
            // Write a ShortBounds object to the stream.
            writer.Write(bounds.lower);
            writer.Write(bounds.upper);
        }

        public static void Write(this BinaryWriter writer, AngleBounds bounds)
        {
            // Write an AngleBounds object to the stream.
            writer.Write(bounds.lower);
            writer.Write(bounds.upper);
        }

        public static void Write(this BinaryWriter writer, RealBounds bounds)
        {
            // Write a RealBounds object to the stream.
            writer.Write(bounds.lower);
            writer.Write(bounds.upper);
        }

        public static void Write(this BinaryWriter writer, RealFractionBounds bounds)
        {
            // Write a RealFractionBounds object to the stream.
            writer.Write(bounds.lower);
            writer.Write(bounds.upper);
        }

        public static void Write(this BinaryWriter writer, ColorRgb color)
        {
            // Write a ColorRgb object to the stream.
            writer.Write((byte)0);
            writer.Write(color.r);
            writer.Write(color.g);
            writer.Write(color.b);
        }

        public static void Write(this BinaryWriter writer, ColorArgb color)
        {
            // Write a ColorArgb object to the stream.
            writer.Write(color.a);
            writer.Write(color.r);
            writer.Write(color.g);
            writer.Write(color.b);
        }

        public static void Write(this BinaryWriter writer, RealColorRgb color)
        {
            // Write a RealColorRgb object to the stream.
            writer.Write(color.r);
            writer.Write(color.g);
            writer.Write(color.b);
        }

        public static void Write(this BinaryWriter writer, RealColorArgb color)
        {
            // Write a RealColorArgb object to the stream.
            writer.Write(color.a);
            writer.Write(color.r);
            writer.Write(color.g);
            writer.Write(color.b);
        }

        public static void Write(this BinaryWriter writer, RealColorHsv color)
        {
            // Write a RealColorHsv object to the stream.
            writer.Write(color.hue);
            writer.Write(color.saturation);
            writer.Write(color.value);
        }

        public static void Write(this BinaryWriter writer, RealColorAhsv color)
        {
            // Write a RealColorAhsv object to the stream.
            writer.Write(color.alpha);
            writer.Write(color.hue);
            writer.Write(color.saturation);
            writer.Write(color.value);
        }

        public static void Write(this BinaryWriter writer, datum_index datum)
        {
            // Write a datum_index object to the stream.
            writer.Write(datum.datum);
        }

        public static void Write(this BinaryWriter writer, string_id sid)
        {
            // Write a string_id object to the stream.
            writer.Write(sid.handle);
        }

        public static void Write(this BinaryWriter writer, String32 @string)
        {
            // Write a String32 object to the stream.
            writer.Write(@string.value);
        }

        public static void Write(this BinaryWriter writer, String256 @string)
        {
            // Write a String256 object to the stream.
            writer.Write(@string.value);
        }

        public static void Write(this BinaryWriter writer, GroupTag tag)
        {
            // Write a GroupTag object to the stream.
            writer.Write(tag.value);
        }

        public static void Write(this BinaryWriter writer, TagReference tag)
        {
            // Write a TagReference object to the stream.
            writer.Write((byte[])tag.GroupTag);
            writer.Write(tag.Datum);
        }

        public static void Write(this BinaryWriter writer, Point2d point)
        {
            // Write a Point2d object to the stream.
            writer.Write(point.x);
            writer.Write(point.y);
        }

        public static void Write(this BinaryWriter writer, Rectangle2d rect)
        {
            // Write a Rectangle2d object to the stream.
            writer.Write(rect.top);
            writer.Write(rect.left);
            writer.Write(rect.bottom);
            writer.Write(rect.right);
        }

        public static void Write(this BinaryWriter writer, RealPoint2d point)
        {
            // Write a RealPoint2d object to the stream.
            writer.Write(point.x);
            writer.Write(point.y);
        }

        public static void Write(this BinaryWriter writer, RealPoint3d point)
        {
            // Write a RealPoint3d object to the stream.
            writer.Write(point.x);
            writer.Write(point.y);
            writer.Write(point.z);
        }

        public static void Write(this BinaryWriter writer, RealVector2d vect)
        {
            // Write a RealVector2d object to the stream.
            writer.Write(vect.i);
            writer.Write(vect.j);
        }

        public static void Write(this BinaryWriter writer, RealVector3d vect)
        {
            // Write a RealVector3d object to the stream.
            writer.Write(vect.i);
            writer.Write(vect.j);
            writer.Write(vect.k);
        }

        public static void Write(this BinaryWriter writer, RealQuaternion quat)
        {
            // Write a RealQuaternion object to the stream.
            writer.Write(quat.x);
            writer.Write(quat.y);
            writer.Write(quat.z);
            writer.Write(quat.w);
        }

        public static void Write(this BinaryWriter writer, RealEulerAngle2d angle)
        {
            // Write a RealEulerAngle2d object to the stream.
            writer.Write(angle.yaw);
            writer.Write(angle.pitch);
        }

        public static void Write(this BinaryWriter writer, RealEulerAngle3d angle)
        {
            // Write a RealEulerAngle3d object to the stream.
            writer.Write(angle.yaw);
            writer.Write(angle.pitch);
            writer.Write(angle.roll);
        }

        public static void Write(this BinaryWriter writer, RealPlane2d plane)
        {
            // Write a RealPlane2d object to the stream.
            writer.Write(plane.i);
            writer.Write(plane.j);
            writer.Write(plane.d);
        }

        public static void Write(this BinaryWriter writer, RealPlane3d plane)
        {
            // Write a RealPlane3d object to the stream.
            writer.Write(plane.i);
            writer.Write(plane.j);
            writer.Write(plane.k);
            writer.Write(plane.d);
        }

        /// <summary>
        /// Aligns the stream to the specified interval using padding bytes of null data.
        /// </summary>
        /// <param name="writer">Stream to align</param>
        /// <param name="alignment">Alignment interval</param>
        public static void AlignTo(this BinaryWriter writer, int alignment)
        {
            // Compute the number of bytes to skip.
            long skip = alignment - (writer.BaseStream.Position % alignment);
            if (skip == alignment)
                skip = 0;

            // If the current position is not properly aligned they align it.
            if (skip > 0)
            {
                // Write an empty buffer to the file.
                writer.Write(new byte[skip]);
            }
        }

        /// <summary>
        /// Writes a null terminated string to the stream.
        /// </summary>
        /// <param name="writer">Stream to write to</param>
        /// <param name="value">String value to write</param>
        /// <param name="maxLength">Maximum length in characters to write.</param>
        public static void WriteNullTerminatedString(this BinaryWriter writer, string value, int maxLength = 0)
        {
            // Check if the string constant is longer than the max length.
            if (maxLength > 0 && value.Length > maxLength)
            {
                // Write maxLength - 1 characters of the string constant.
                writer.Write(value.Substring(0, maxLength - 1).ToCharArray());

                // Write the null terminator.
                writer.Write((byte)0);
            }
            else
            {
                // Write the string constant.
                writer.Write(value.ToCharArray());

                // Write padding.
                writer.Write(new byte[maxLength - value.Length]);
            }
        }
    }
}
