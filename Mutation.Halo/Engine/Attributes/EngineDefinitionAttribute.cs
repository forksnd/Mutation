using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutation.Halo.Engine.Attributes
{
    /// <summary>
    /// Attribute that describes the engine version for an engine definition class.
    /// </summary>
    public class EngineDefinitionAttribute : Attribute
    {
        /// <summary>
        /// Engine version for this engine definition.
        /// </summary>
        public EngineVersion Version { get; private set; }

        /// <summary>
        /// Initializes a new EngineDefinitionAttribute using the info provided.
        /// </summary>
        /// <param name="version">Engine version for this engine definition.</param>
        public EngineDefinitionAttribute(EngineVersion version)
        {
            // Initialize fields.
            this.Version = version;
        }
    }
}
