using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mutation.Halo.TagGroups.Serialization
{
    public enum ReferenceType
    {
        StringId,
        DatumIndex
    }

    public interface ISerializationContext
    {
        /// <summary>
        /// Performs any pre-processing needed before serialization.
        /// </summary>
        /// <param name="flags">Serialization flags for the operation</param>
        /// <param name="context">Object that will be serialized</param>
        /// <returns>BinaryWriter that will be used for serialization</returns>
        BinaryWriter BeginSerialiation(SerializationFlags flags, object context);

        /// <summary>
        /// Performs any post-processing needed after serialization.
        /// </summary>
        void EndSerialization();

        /// <summary>
        /// Performs any pre-processing needed before deserialiation.
        /// </summary>
        /// <param name="flags">Serialization flags for the operation</param>
        /// <param name="context">Object that will be deserialized</param>
        /// <returns>BinaryReader that will be used for derserialization</returns>
        BinaryReader BeginDeserialization(SerializationFlags flags, object context);

        /// <summary>
        /// Performs any post-processing needed after deserialization.
        /// </summary>
        void EndDeserialization();

        /// <summary>
        /// Resolves a reference of the specified type using the object provided.
        /// </summary>
        /// <param name="type">Type fo reference to be resolved</param>
        /// <param name="value">Reference to be resolved</param>
        /// <returns>An object containing information about the resolved reference, or null if the reference could not be resolved</returns>
        object ResolveReference(ReferenceType type, object value);

        /// <summary>
        /// Validates a reference of the specified type using the object provided.
        /// </summary>
        /// <param name="type">Type fo reference to be validated</param>
        /// <param name="value">Reference to be validate</param>
        /// <returns>True if the reference is valid, false otherwise.</returns>
        bool ValidateReference(ReferenceType type, object value);

        /// <summary>
        /// Locates a block of raw data.
        /// </summary>
        /// <param name="offset">Offset of the raw data</param>
        /// <param name="size">Size of the raw data</param>
        /// <returns>The raw data if it was found, or null if it was not.</returns>
        byte[] LocateRawData(int offset, int size);
    }
}
