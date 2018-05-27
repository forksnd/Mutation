using Mutation.Halo.TagGroups.FieldTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutation.Halo.Cache
{
    /// <summary>
    /// Language enum
    /// </summary>
    public enum language : int
    {
        _language_invalid = -1,
        _language_english = 0,
        _language_japanese = 1,
        _language_german = 2,
        _language_french = 3,
        _language_spanish = 4,
        _language_italian = 5,
        _language_korean = 6,
        _language_chinese = 7,
        _language_portuguese = 8,
        k_language_count = 9
    }

    public struct multilingual_unicode_string
    {
        /// <summary>
        /// String Id used to reference this unicode string.
        /// </summary>
        public string_id StringId { get; set; }

        /// <summary>
        /// Gets or sets the list of unicode strings associated with this string_id.
        /// </summary>
        public List<byte[]> UnicodeStrings { get; set; }

        /// <summary>
        /// Gets the unicode string for the specified string index.
        /// </summary>
        /// <param name="index">Index of the string to retreive.</param>
        /// <returns>Unicode string</returns>
        public string GetString(int index)
        {
            // Conert the string data to an actual string and return it.
            return Encoding.UTF8.GetString(this.UnicodeStrings[index]);
        }
    }

    public class UnicodeStringCache
    {
        // Unicode string list and lookup table, one for each language.
        private List<multilingual_unicode_string>[] unicodeStrings;
        private Dictionary<string_id, int>[] unicodeStringTable;

        /// <summary>
        /// Engine version this unicode string cache belongs to.
        /// </summary>
        public EngineVersion Version { get; private set; }

        /// <summary>
        /// Gets or sets the unicode string entry at the specified index.
        /// </summary>
        /// <param name="lang">Language of the string.</param>
        /// <param name="index">Index of the unicode string entry.</param>
        /// <returns>The multilingual_unicode_string at the specified index in the unicode string cache.</returns>
        public multilingual_unicode_string this[language lang, int index]
        {
            get
            {
                return this.unicodeStrings[(int)lang][index];
            }
            set
            {
                this.unicodeStrings[(int)lang][index] = value;
            }
        }

        /// <summary>
        /// Gets or sets the unicode string entry for the specified string_id.
        /// </summary>
        /// <param name="lang">Language of the string.</param>
        /// <param name="id">Id of the string entry</param>
        /// <returns>The multilingual_unicode_string for the specified id.</returns>
        public multilingual_unicode_string this[language lang, string_id id]
        {
            get
            {
                return this.unicodeStrings[(int)lang][this.unicodeStringTable[(int)lang][id]];
            }
            set
            {
                this.unicodeStrings[(int)lang][this.unicodeStringTable[(int)lang][id]] = value;
            }
        }

        /// <summary>
        /// Initializes a new UnicodeStringCache object for the engine version specified.
        /// </summary>
        /// <param name="version">Engine version</param>
        public UnicodeStringCache(EngineVersion version)
        {
            // Initialize fields.
            this.Version = version;

            // Initialize the unicode string tables.
            this.unicodeStrings = new List<multilingual_unicode_string>[(int)language.k_language_count];
            this.unicodeStringTable = new Dictionary<string_id, int>[(int)language.k_language_count];

            // Loop for every language and initialize the unicode tables.
            for (int i = 0; i < (int)language.k_language_count; i++)
            {
                // Initialize unicode string data.
                this.unicodeStrings[i] = new List<multilingual_unicode_string>();
                this.unicodeStringTable[i] = new Dictionary<string_id, int>();
            }
        }

        /// <summary>
        /// Adds the specified unicode string to the cache.
        /// </summary>
        /// <param name="lang">Language of the unicode string</param>
        /// <param name="stringId">String id that identifies the multilingual_unicode_string object</param>
        /// <param name="stringData">String data for the unicode string</param>
        public void AddString(language lang, string_id stringId, byte[] stringData)
        {
            // Check to see if a multilingual_unicode_string object already exists for this string id.
            if (this.unicodeStringTable[(int)lang].ContainsKey(stringId) == false)
            {
                // No multilingual_unicode_string object exists for this string_id, create one.
                multilingual_unicode_string unicodeString = new multilingual_unicode_string();
                unicodeString.StringId = stringId;
                unicodeString.UnicodeStrings = new List<byte[]>();

                // Add a mapping to lookup table.
                this.unicodeStringTable[(int)lang].Add(unicodeString.StringId, this.unicodeStrings[(int)lang].Count);

                // Add the string data to the unicode string list.
                this.unicodeStrings[(int)lang].Add(unicodeString);
            }

            // Add this string to the multilingual_unicode_string for this string_id.
            int stringIndex = this.unicodeStringTable[(int)lang][stringId];
            this.unicodeStrings[(int)lang][stringIndex].UnicodeStrings.Add(stringData);
        }

        /// <summary>
        /// Gets the number of unicode strings in the cache for the specified language.
        /// </summary>
        /// <returns>Number of unicode strings in the cache.</returns>
        public int Count(language lang)
        {
            // Return the number of strings in the unicode cache.
            return this.unicodeStrings[(int)lang].Count;
        }

        /// <summary>
        /// Removes all existing unicode strings from the cache for the specified language.
        /// </summary>
        /// <param name="lang">Lnaguage of the cache that should be cleared</param>
        public void Clear(language lang)
        {
            // Clear the lookup table and unicode string table.
            this.unicodeStrings[(int)lang].Clear();
            this.unicodeStringTable[(int)lang].Clear();
        }

        /// <summary>
        /// Checks if a unicode string exists in the cache for the specified language and string_id.
        /// </summary>
        /// <param name="lang">Language of the string.</param>
        /// <param name="stringId">StringId to search for.</param>
        /// <returns>True if the cache contains a string with the specified string_id, false otherwise.</returns>
        public bool Contains(language lang, string_id stringId)
        {
            // Check if there is a multilingual string in the table with the specified string_id.
            return this.unicodeStringTable[(int)lang].ContainsKey(stringId);
        }

        /// <summary>
        /// Gets a string in the specified langauge matching the string_id and index provided.
        /// </summary>
        /// <param name="lang">Language of the string</param>
        /// <param name="stringId">String id that identifies the multilingual_unicode_string object</param>
        /// <param name="index">Index of the string within the multilingual_unicode_string object</param>
        /// <returns>A string in the specified language for the string id.</returns>
        public string GetString(language lang, string_id stringId, int index)
        {
            // Check if the specified string_id exists in the lookup table.
            if (this.unicodeStringTable[(int)lang].ContainsKey(stringId) == false)
            {
                // The specified string_id does not exist in the lookup table.
                throw new KeyNotFoundException("string_id does not exist in the lookup table");
            }

            // Get the unicode string in the specified language.
            return this.unicodeStrings[(int)lang][this.unicodeStringTable[(int)lang][stringId]].GetString(index);
        }
    }
}
