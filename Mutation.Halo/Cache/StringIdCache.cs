using Mutation.Halo.TagGroups.FieldTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutation.Halo.Cache
{
    public class StringIdCache
    {
        // Hashtable of string handles and constants.
        private Dictionary<string_id, string> stringIdTable;

        // Reverse hashtable for easy lookup of string_id's from string values.
        private Dictionary<string, string_id> reverseStringIdTable;

        /// <summary>
        /// Engine version for the string_id cache.
        /// </summary>
        public EngineVersion Version { get; private set; }

        public string this[string_id id]
        {
            get
            {
                return this.stringIdTable[id];
            }
        }

        public string_id this[string value]
        {
            get
            {
                return this.reverseStringIdTable[value];
            }
        }

        public StringIdCache(EngineVersion version)
        {
            // Initialize fields.
            this.Version = version;

            // Initialize string_id tables.
            this.stringIdTable = new Dictionary<string_id, string>();
            this.reverseStringIdTable = new Dictionary<string, string_id>();
        }

        public string_id Add(string value)
        {
            // Make sure the string value does not already exist in the string_id table.
            if (this.reverseStringIdTable.Keys.Contains(value.ToLower()) == true)
            {
                // The string value already exists in the string id table, just return the handle for it.
                return this.reverseStringIdTable[value.ToLower()];
            }

            // Create a string_id handle for this string value.
            string_id handle = new string_id((byte)value.Length, this.stringIdTable.Count);

            // Add the string value to the string id table.
            this.stringIdTable.Add(handle, value.ToLower());
            this.reverseStringIdTable.Add(value.ToLower(), handle);

            // Return the handle to the string value.
            return handle;
        }

        public bool Contains(string value)
        {
            // Check if the specified string value exists in the string_id cache or not.
            return this.reverseStringIdTable.Keys.Contains(value.ToLower());
        }
    }
}
