using Mutation.Halo.TagGroups;
using Mutation.Halo.TagGroups.Attributes;
using Mutation.Halo.TagGroups.FieldTypes;
using Mutation.Halo.TagGroups.IO;
using Mutation.Halo.TagGroups.Serialization;
using Mutation.Halo.TagGroups.Tags;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mutation.Halo.Cache.Map
{
    /// <summary>
    /// Database type for shared resources databases, not to be confused with _cache_file_address_location
    /// </summary>
    public enum shared_resource_database_type
    {
        /// <summary>
        /// Internal; resource database is the active map
        /// </summary>
        _shared_resource_database_type_none = -1,
        /// <summary>
        /// Resource database is single player shared
        /// </summary>
        _shared_resource_database_type_singleplayer_shared = 0,
        /// <summary>
        /// Resource database is multiplayer shared
        /// </summary>
        _shared_resource_database_type_multiplayer_shared = 1,
        /// <summary>
        /// Resource database is main menu
        /// </summary>
        _shared_resource_database_type_main_menu = 2
    }

    /// <summary>
    /// Mask values for determining what resource database a cache file address is located in.
    /// </summary>
    public enum _cache_file_address_location : uint
    {
        /// <summary>
        /// Address points to an internal location
        /// </summary>
        _cache_file_address_location_internal = 0,
        /// <summary>
        /// Address points to singleplayer shared
        /// </summary>
        _cache_file_address_location_singleplayer_shared = 0x40000000,
        /// <summary>
        /// Address points to multiplayer shared
        /// </summary>
        _cache_file_address_location_multiplayer_shared = 0x80000000,
        /// <summary>
        /// Address points to main menu
        /// </summary>
        _cache_file_address_location_main_menu = 0xC0000000
    }

    public class H2XCacheMap : ISerializationContext
    {
        #region s_cache_file_header

        public struct s_cache_file_header
        {
            public const int kSizeOf = 2048;
            public const int k_cache_file_header_signature = 0x68656164; // 'head'
            public const int k_cache_file_footer_signature = 0x666F6F74; // 'foot'

            public const int _k_engine_version = 8;

            public const int _k_max_cache_file_size = 0x19000000;

            public const string _k_build_date = "02.09.27.09809";

            public int header_signature;
            public int version;
            public int fileSize;
            public int scenarioPointer;
            public int indexOffset;
            public int indexSize;
            public int metaTableSize;
            public int total_tags_size;

            [Padding(PaddingType.Padding, 256)]
            public byte[] _padding1;

            public String32 buildDate;
            public e_map_type mapType;

            [Padding(PaddingType.Padding, 20)]
            public byte[] _padding2;

            public int crazyOffset;
            public int crazySize;
            public int stringIdPaddedTableOffset;
            public int stringIdCount;
            public int stringIdTableSize;
            public int stringIdIndexOffset;
            public int stringIdTableOffset;

            [Padding(PaddingType.Padding, 36)]
            public byte[] _padding3;

            public String32 mapName;
            public int _padding4;
            public String256 mapScenario;
            public int _padding5;
            public int tagCount;
            public int fileTableOffset;
            public int fileTableSize;
            public int fileTableIndexOffset;
            public int checksum;

            [Padding(PaddingType.Padding, 1320)]
            public byte[] _padding6;

            public int footer_signature;
        }

        #endregion

        #region s_tag_cache_header

        public struct s_tag_cache_header
        {
            public const int kSizeOf = 32;
            public const int _k_tag_cache_header_signature = 0x74616773; // 'tags'

            public uint tagIndexAddress;
            public int tagHierarchyCount;
            public uint tagStartAddress;
            public datum_index scenarioDatum;
            public datum_index globalsDatum;
            public int unknown;
            public int tag_count;
            public int signature;
        }

        #endregion

        #region s_tag_geneology_entry

        public struct s_tag_geneology_entry
        {
            public const int kSizeOf = 12;

            public GroupTag childClass;
            public GroupTag parentClass;
            public GroupTag grandparentClass;
        }

        #endregion

        #region tag_instance

        public struct tag_instance
        {
            public const int kSizeOf = 16;

            public GroupTag group_tag;
            public datum_index datum;
            public uint address;
            public int size;
        }

        #endregion

        public const uint _k_tag_cache_memory_address = 0x80061000;

        /// <summary>
        /// Full file path of the map file.
        /// </summary>
        public string FileName { get; private set; }

        // File stream reader and writer.
        private FileStream fileStream;
        private BinaryReader reader;
        private BinaryWriter writer;

        // Virtual memory stream for the tag cache.
        private VirtualMemoryStream tagCacheStream;
        private BinaryReader tagReader;
        private BinaryWriter tagWriter;

        // Tag data serializer/deserializer.
        private TagDataSerializer serializer;
        private TagDataDeserializer deserializer;

        // Map and tag index headers.
        private s_cache_file_header mapHeader;
        private s_tag_cache_header tagIndexHeader;

        // String id cache.
        private StringIdCache stringIdCache;

        // Tag cache data.
        private tag_instance[] tagInstances;
        private TagCache tagCache;

        // Critical/resource tags.
        private scenario_block scenario;
        private int activeBspIndex = -1;
        private globals_block match_globals;

        // Unicode string cache.
        private UnicodeStringCache unicodeCache;

        public H2XCacheMap(string fileName)
        {
            // Initialize fields.
            this.FileName = fileName;

            // Initialize the file stream.
            this.fileStream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite, FileShare.Read);
            this.reader = new BinaryReader(this.fileStream);
            this.writer = new BinaryWriter(this.fileStream);

            // Initialize various cache containers.
            this.tagCache = new TagCache(EngineVersion.Halo2Xbox, this);
            this.stringIdCache = new StringIdCache(EngineVersion.Halo2Xbox);
            this.unicodeCache = new UnicodeStringCache(EngineVersion.Halo2Xbox);
        }

        ~H2XCacheMap()
        {
            // Close out the tag reader/writer if they are initialized.
            if (this.tagReader != null)
            {
                this.tagReader.Dispose();
                this.tagReader = null;
            }

            if (this.tagWriter != null)
            {
                this.tagWriter.Dispose();
                this.tagWriter = null;
            }

            // Dispose of the tag cache stream if it was created.
            if (this.tagCacheStream != null)
            {
                this.tagCacheStream.Dispose();
                this.tagCacheStream = null;
            }

            // Close out any existing file streams.
            if (this.reader != null)
            {
                this.reader.Dispose();
                this.reader = null;
            }

            if (this.writer != null)
            {
                this.writer.Dispose();
                this.writer = null;
            }

            // Close the underlying file stream.
            if (this.fileStream != null)
            {
                this.fileStream.Dispose();
                this.fileStream = null;
            }
        }

        public bool Read()
        {
            // Initialize the tag data deserializer.
            this.deserializer = new TagDataDeserializer(EngineVersion.Halo2Xbox);

            // Read and verify the map header.
            if (ReadAndVerifyHeader() == false)
            {
                // Map header is invalid.
                return false;
            }

            // Seek to the tag file name table.
            this.reader.BaseStream.Position = this.mapHeader.fileTableOffset;

            // Loop and read each tag file name.
            string[] tagFileNames = new string[this.mapHeader.tagCount];
            for (int i = 0; i < this.mapHeader.tagCount; i++)
            {
                // Read the tag file path.
                tagFileNames[i] = this.reader.ReadNullTerminatedString();
            }

            // Seek to the string id index.
            this.reader.BaseStream.Position = this.mapHeader.stringIdIndexOffset;

            // Loop and read all of the string id offsets.
            int[] stringIdOffsets = new int[this.mapHeader.stringIdCount];
            for (int i = 0; i < this.mapHeader.stringIdCount; i++)
            {
                // Read the next string id offset.
                stringIdOffsets[i] = this.reader.ReadInt32();
            }

            // Loop and read all of the string id values from the string id table.
            for (int i = 0; i < this.mapHeader.stringIdCount; i++)
            {
                // Seek to the string id offset within the table.
                this.reader.BaseStream.Position = this.mapHeader.stringIdTableOffset + stringIdOffsets[i];

                // Read the string value and add it to the string id cache.
                string stringId = this.reader.ReadNullTerminatedString();
                this.stringIdCache.Add(stringId);
            }

            // Initialize the virtual tag stream.
            this.tagCacheStream = new VirtualMemoryStream(_k_tag_cache_memory_address, this.mapHeader.total_tags_size);
            this.tagReader = new BinaryReader(this.tagCacheStream);
            this.tagWriter = new BinaryWriter(this.tagCacheStream);

            // Seek to and deserialize the tag index header.
            this.reader.BaseStream.Position = this.mapHeader.indexOffset;
            this.tagIndexHeader = this.deserializer.DeserializeBlock<s_tag_cache_header>(this, SerializationFlags.FileType_Raw);

            // Check the tag index header signature is valid.
            if (this.tagIndexHeader.signature != s_tag_cache_header._k_tag_cache_header_signature)
            {
                // Tag index header has an invalid signature.
                Console.WriteLine("Halo2CacheMap::Read(): tag index header has invalid signature!");
                return false;
            }

            // Seek to the tag index and read it into the virtual tag stream.
            Console.WriteLine("Reading tag index: 0x{0} 0x{1}", _k_tag_cache_memory_address.ToString("X8"), this.mapHeader.indexSize);
            this.reader.BaseStream.Position = this.mapHeader.indexOffset;
            this.tagWriter.Write(this.reader.ReadBytes(this.mapHeader.indexSize));

            // Seek to the start of the general tag table in the virtual tag stream.
            this.tagWriter.BaseStream.Position = _k_tag_cache_memory_address + (this.mapHeader.total_tags_size - this.mapHeader.metaTableSize);
            Console.WriteLine("Tag data start: 0x{0}", ((int)this.tagWriter.BaseStream.Position).ToString("X8"));

            // Read the general tag data into the virtual tag stream.
            this.reader.BaseStream.Position = this.mapHeader.indexOffset + this.mapHeader.indexSize;
            this.tagWriter.Write(this.reader.ReadBytes(this.mapHeader.metaTableSize));

            // Create an array to hold all of the tags entries in the index.
            this.tagInstances = new tag_instance[this.tagIndexHeader.tag_count];

            // Seek to the start of the tag entries and read each one from the index.
            this.tagReader.BaseStream.Position = this.tagIndexHeader.tagStartAddress;
            for (int i = 0; i < this.tagIndexHeader.tag_count; i++)
            {
                // Deserialize the current tag instance.
                this.tagInstances[i] = this.deserializer.DeserializeBlock<tag_instance>(this, SerializationFlags.FileType_TagStream | SerializationFlags.FileType_Raw);

                // Add the tag instance to the tag cache.
                this.tagCache.Add(this.tagInstances[i].datum, this.tagInstances[i].group_tag, tagFileNames[i]);
            }

            // Get the scenario tag so we can load the active bsp.
            this.scenario = this.tagCache.GetTagInstance<scenario_block>(this.tagIndexHeader.scenarioDatum);
            if (this.scenario == null)
            {
                // Failed to load the scenario tag.
                Console.WriteLine("H2xCacheMap::Read(): failed to load the map scenario!");
                return false;
            }

            // Print details on each bsp that is in the secenario.
            Console.WriteLine();
            for (int i = 0; i < this.scenario.structure_bsps.Count; i++)
            {
                // Print bsp info.
                Console.WriteLine("Structure BSP #{0}:", i);
                Console.WriteLine("\tBSP address: 0x{0}", this.scenario.structure_bsps[i].structure_bsp_base_address.ToString("X8"));
                Console.WriteLine("\tBSP offset: {0}", this.scenario.structure_bsps[i].structure_bsp_offset);
                Console.WriteLine("\tBSP size: {0}\n", this.scenario.structure_bsps[i].structure_bsp_size);
            }

            // Load the first bsp into the tag stream.
            if (SetActiveBsp(0) == false)
            {
                // Failed to load the primary bsp.
                Console.WriteLine("H2xCacheMap::Read(): failed to load primary bsp!");
                return false;
            }

            // Parse the globals tag so we can read the unicode tables.
            this.match_globals = this.tagCache.GetTagInstance<globals_block>(this.tagIndexHeader.globalsDatum);
            if (this.match_globals == null)
            {
                // Failed to load the match globals tag.
                Console.WriteLine("H2xCacheMap::Read(): failed to load match globals tag!");
                return false;
            }

            // Read all of the unicode string tables into the unicode string cache.
            if (ReadUnicodeTables() == false)
            {
                // Failed to read the unicode string tables.
                Console.WriteLine("H2xCacheMap::Read(): failed to read the unicode string tables!");
                return false;
            }

            // Successfully read the map.
            return true;
        }

        /// <summary>
        /// Reads and varifies the map header is valid.
        /// </summary>
        /// <returns>A boolean indicating if the map header is valid.</returns>
        private bool ReadAndVerifyHeader()
        {
            // Check to make sure the file is large enough to contain the map header.
            if (this.fileStream.Length < s_cache_file_header.kSizeOf)
            {
                // File is not large enough to be a valid cache map.
                Console.WriteLine("H2xCacheMap::ReadAndVerifyHeader(): map file \"{0}\" is not large enough to be a valid cache map!", this.FileName);
                return false;
            }

            // Deserialize the map header.
            this.mapHeader = this.deserializer.DeserializeBlock<s_cache_file_header>(this, SerializationFlags.FileType_Raw);

            // Check if the map header signature is valid.
            if (this.mapHeader.header_signature != s_cache_file_header.k_cache_file_header_signature)
            {
                // Map header signature is invalid.
                Console.WriteLine("H2xCacheMap::ReadAndVerifyHeader(): map header signature is invalid!");
                return false;
            }

            // Check to make sure the map header footer signature is valid.
            if (this.mapHeader.footer_signature != s_cache_file_header.k_cache_file_footer_signature)
            {
                // Map headeer footer signature is invalid.
                Console.WriteLine("H2xCacheMap::ReadAndVerifyHeader(): map header footer signature is invalid!");
                return false;
            }

            // Check to make sure the engine version is correct.
            if (this.mapHeader.version != s_cache_file_header._k_engine_version)
            {
                // Map engine version is incorrect.
                Console.WriteLine("H2xCacheMap::ReadAndVerifyHeader(): map engine version is incorrect!");
                return false;
            }

            // Check to make sure the file size is correct.
            if (this.mapHeader.fileSize != (int)this.fileStream.Length || this.mapHeader.fileSize > s_cache_file_header._k_max_cache_file_size)
            {
                // Map file size is incorrect.
                Console.WriteLine("H2xCacheMap::ReadAndVerifyHeader(): map file size is incorrect!");
                return false;
            }

            // Check to make sure the build date is correct.
            for (int i = 0; i < s_cache_file_header._k_build_date.Length; i++)
            {
                // Check if the current character is correct.
                if (this.mapHeader.buildDate.value[i] != s_cache_file_header._k_build_date[i])
                {
                    // Build data is incorrect.
                    Console.WriteLine("H2xCacheMap::ReadAndVerifyHeader(): map build data is incorrect!");
                    return false;
                }
            }

            // Check to make sure the tag index offset and size are valid.
            if (this.mapHeader.indexOffset >= (int)this.fileStream.Length || (this.mapHeader.indexOffset + this.mapHeader.indexSize) >= (int)this.fileStream.Length)
            {
                // Tag index offset or size are invalid.
                Console.WriteLine("H2xCacheMap::ReadAndVerifyHeader(): tag index offset or size is invalid!");
                return false;
            }

            // TODO: Check to make sure the tag data size is valid.

            // Map header appears to be valid.
            return true;
        }

        /// <summary>
        /// Switches which bsp is loaded into the virtual tag stream.
        /// </summary>
        /// <param name="bspIndex">Index of the bsp to switch to</param>
        /// <returns>True if the bsp switch was successful, false otherwise.</returns>
        public bool SetActiveBsp(int bspIndex)
        {
            // Check to make sure there is at least one bsp block.
            if (this.scenario.structure_bsps.Count == 0)
            {
                // Scenario does not contain any structure bsp blocks.
                Console.WriteLine("H2xCacheMap::SetActiveBsp(): scenario does not contain any structure_bsp blocks!");
                return false;
            }

            // Check to make sure the specified bsp index is within bounds.
            if (bspIndex < 0 || bspIndex >= this.scenario.structure_bsps.Count)
            {
                // Bsp index is out of bounds.
                throw new IndexOutOfRangeException("Bsp index is out of bounds");
            }

            // Check that the bsp address and size are valid.
            if (this.scenario.structure_bsps[bspIndex].structure_bsp_base_address < _k_tag_cache_memory_address + this.mapHeader.indexSize ||
                this.scenario.structure_bsps[bspIndex].structure_bsp_base_address + this.scenario.structure_bsps[bspIndex].structure_bsp_size > _k_tag_cache_memory_address + (this.mapHeader.total_tags_size - this.mapHeader.metaTableSize))
            {
                // Bsp would overlap the tag cache index or the meta table.
                throw new Exception("BSP would overlap existing memory");
            }

            // Print the new bsp details.
            Console.WriteLine("Switching to bsp {0} from {1}:", bspIndex, this.activeBspIndex);
            Console.WriteLine("Bsp Offset: {0}", this.scenario.structure_bsps[bspIndex].structure_bsp_offset);
            Console.WriteLine("Bsp Size: {0}", this.scenario.structure_bsps[bspIndex].structure_bsp_size);
            Console.WriteLine("Bsp Address: 0x{0}", this.scenario.structure_bsps[bspIndex].structure_bsp_base_address.ToString("X8"));

            // Seek to and read the bsp tag data.
            this.reader.BaseStream.Position = this.scenario.structure_bsps[bspIndex].structure_bsp_offset;
            byte[] bspData = this.reader.ReadBytes(this.scenario.structure_bsps[bspIndex].structure_bsp_size);

            // Write the bsp data to the tag stream.
            this.tagWriter.BaseStream.Position = this.scenario.structure_bsps[bspIndex].structure_bsp_base_address;
            this.tagWriter.Write(bspData);

            // Update the active bsp index.
            this.activeBspIndex = bspIndex;

            // Bsp loaded successfully.
            return true;
        }

        /// <summary>
        /// Opens the specified map file and determins if it is valid and compatible with this engine version.
        /// </summary>
        /// <param name="fileName">Map file to test for engine compatibility.</param>
        /// <returns>True if the map file appears valid and is compatible with this engine version, false otherwise.</returns>
        public static bool CheckForEngineCompatibility(string fileName)
        {
            // Create a new cache map instance using the file name provided.
            H2XCacheMap cacheMap = new H2XCacheMap(fileName);

            // Try to read and verify the map header.
            if (cacheMap.ReadAndVerifyHeader() == false)
            {
                // Map is invalid or not compatible with this engine version.
                return false;
            }

            // Map is valid and compatible with this engine version.
            return true;
        }

        /// <summary>
        /// Reads the unicode string tables into the unicode string cache.
        /// </summary>
        /// <returns>True if all of the unicode string tables were successfully read, false otherwise.</returns>
        private bool ReadUnicodeTables()
        {
            // Initialize a tuple array that contains the unicode string table information for each language.
            Tuple<language, int, int, int, int>[] unicodeTableInfo = 
            {
                new Tuple<language, int, int, int, int>(language._language_english, this.match_globals.english_string_count, this.match_globals.english_string_table_size, this.match_globals.english_string_table_offset, this.match_globals.english_string_index_offset),
                new Tuple<language, int, int, int, int>(language._language_japanese, this.match_globals.japanese_string_count, this.match_globals.japanese_string_table_size, this.match_globals.japanese_string_table_offset, this.match_globals.japanese_string_index_offset),
                new Tuple<language, int, int, int, int>(language._language_german, this.match_globals.german_string_count, this.match_globals.german_string_table_size, this.match_globals.german_string_table_offset, this.match_globals.german_string_index_offset),
                new Tuple<language, int, int, int, int>(language._language_french, this.match_globals.french_string_count, this.match_globals.french_string_table_size, this.match_globals.french_string_table_offset, this.match_globals.french_string_index_offset),
                new Tuple<language, int, int, int, int>(language._language_spanish, this.match_globals.spanish_string_count, this.match_globals.spanish_string_table_size, this.match_globals.spanish_string_table_offset, this.match_globals.spanish_string_index_offset),
                new Tuple<language, int, int, int, int>(language._language_italian, this.match_globals.italian_string_count, this.match_globals.italian_string_table_size, this.match_globals.italian_string_table_offset, this.match_globals.italian_string_index_offset),
                new Tuple<language, int, int, int, int>(language._language_korean, this.match_globals.korean_string_count, this.match_globals.korean_string_table_size, this.match_globals.korean_string_table_offset, this.match_globals.korean_string_index_offset),
                new Tuple<language, int, int, int, int>(language._language_chinese, this.match_globals.chinese_string_count, this.match_globals.chinese_string_table_size, this.match_globals.chinese_string_table_offset, this.match_globals.chinese_string_index_offset),
                new Tuple<language, int, int, int, int>(language._language_portuguese, this.match_globals.portuguese_string_count, this.match_globals.portuguese_string_table_size, this.match_globals.portuguese_string_table_offset, this.match_globals.portuguese_string_index_offset)
            };

            // Loop through each unicode table and read them into the unicode string cache.
            for (int i = 0; i < unicodeTableInfo.Length; i++)
            {
                // Read the unicode string table into cache.
                if (ReadUnicodeTable(unicodeTableInfo[i].Item1, unicodeTableInfo[i].Item2, unicodeTableInfo[i].Item3, unicodeTableInfo[i].Item4, unicodeTableInfo[i].Item5) == false)
                {
                    // Failed to read the unicode string table for the current language.
                    Console.WriteLine("H2XCacheMap::ReadUnicodeTables(): failed to read the {0} unicode string table!", unicodeTableInfo[i].Item1.ToString());
                    return false;
                }
            }

            // Successfully read all of the unicode string tables into cache.
            return true;
        }

        /// <summary>
        /// Reads the unicode table into the unicode string cache.
        /// </summary>
        /// <param name="lang">Langauge of the table</param>
        /// <param name="stringCount">Number of strings in the table</param>
        /// <param name="tableSize">Size of the string table</param>
        /// <param name="tableOffset">Offset of the string table</param>
        /// <param name="indexOffset">Offset of the string index</param>
        /// <returns>True if the table was successfully read into cache, false otherwise.</returns>
        private bool ReadUnicodeTable(language lang, int stringCount, int tableSize, int tableOffset, int indexOffset)
        {
            // Check to make sure the table offset and size seem valid.
            if (tableOffset > this.reader.BaseStream.Length || (tableOffset + tableSize) > this.reader.BaseStream.Length)
            {
                // Table offset and/or size are invalid.
                Console.WriteLine("H2XCacheMap::ReadUnicodeTable(): unicode table for language {0} has invalid offset and/or size!", lang.ToString());
                return false;
            }

            // Seek to the table offset.
            this.reader.BaseStream.Position = tableOffset;

            // Read the unicode table into memory for easy access.
            MemoryStream tableStream = new MemoryStream(this.reader.ReadBytes(tableSize));

            // Create a binary reader for the table stream.
            BinaryReader tableReader = new BinaryReader(tableStream);

            // Seek to the unicode index offset.
            this.reader.BaseStream.Position = indexOffset;

            // Loop for the number of strings in the unicode cache and read each one.
            for (int i = 0; i < stringCount; i++)
            {
                // Read the string entry info from the index.
                string_id stringId = this.reader.ReadStringID();
                int stringOffset = this.reader.ReadInt32();

                // Check to make sure the string offset is valid.
                if (stringOffset > tableReader.BaseStream.Length)
                {
                    // String offset is invalid.
                    Console.WriteLine("H2XCacheMap::ReadUnicodeTable(): string data offset for string {0} is invalid!", i.ToString());

                    // Close and dispose of the table reader.
                    tableReader.Dispose();

                    // Close and dispose of the table stream.
                    tableStream.Dispose();

                    // Failed to read the unicode table.
                    return false;
                }

                // Seek to the string offset in the table stream.
                tableReader.BaseStream.Position = stringOffset;

                // Read the unicode string data from the stream.
                List<byte> stringData = new List<byte>();
                while (tableReader.BaseStream.Position < tableReader.BaseStream.Length)
                {
                    // Read the current unicode character and check if it is the null terminator.
                    byte unicodeCharacter = tableReader.ReadByte();
                    if (unicodeCharacter == 0)
                    {
                        // Null terminator hit, break the loop.
                        break;
                    }

                    // Add the character data to the data list.
                    stringData.Add(unicodeCharacter);
                }

                // Add the unicode string to the unicode string cache.
                this.unicodeCache.AddString(lang, stringId, stringData.ToArray());
            }

            // Close and dispose of the table reader.
            tableReader.Dispose();

            // Close and dispose of the table stream.
            tableStream.Dispose();

            // Successfully read the unicode table into cache.
            return true;
        }

        #region ISerializationContext Functions

        public BinaryWriter BeginSerialiation(SerializationFlags flags, object context)
        {
            // Check the flags and handle accordingly.
            if ((flags.HasFlag(SerializationFlags.FileType_CacheMap) == true && flags.HasFlag(SerializationFlags.FileType_TagStream) == false) ||
                (flags.HasFlag(SerializationFlags.FileType_Raw) == true && flags.HasFlag(SerializationFlags.FileType_TagStream) == false))
            {
                // Use the map stream.
                return this.writer;
            }
            else if (flags.HasFlag(SerializationFlags.FileType_TagStream) == true)
            {
                // Use the tag stream.
                return this.tagWriter;
            }
            else
            {
                // Unsupported flags.
                throw new InvalidOperationException("Unsupported flags");
            }
        }

        public void EndSerialization()
        {

        }

        public BinaryReader BeginDeserialization(SerializationFlags flags, object context)
        {
            // Check the flags and handle accordingly.
            if ((flags.HasFlag(SerializationFlags.FileType_CacheMap) == true && flags.HasFlag(SerializationFlags.FileType_TagStream) == false) ||
                (flags.HasFlag(SerializationFlags.FileType_Raw) == true && flags.HasFlag(SerializationFlags.FileType_TagStream) == false))
            {
                // Use the map stream.
                return this.reader;
            }
            else if (flags.HasFlag(SerializationFlags.FileType_TagStream) == true)
            {
                // Check if the context is valid and if so handle accordingly.
                if (context != null && context.GetType() == typeof(TagInstance))
                {
                    // Cast the context to the correct data type.
                    TagInstance tagInstance = (TagInstance)context;

                    // Seek to the tags address.
                    this.tagReader.BaseStream.Position = this.tagInstances[tagInstance.Datum.index].address;
                }

                // Use the tag stream.
                return this.tagReader;
            }
            else
            {
                // Unsupported flags.
                throw new InvalidOperationException("Unsupported flags");
            }
        }

        public void EndDeserialization()
        {

        }

        public object ResolveReference(ReferenceType type, object value)
        {
            throw new NotImplementedException();
        }

        public bool ValidateReference(ReferenceType type, object value)
        {
            // Check the type of reference to be resolved and handle accordingly.
            switch (type)
            {
                case ReferenceType.StringId:
                    {
                        // Check the value type and handle accordingly.
                        if (value.GetType() == typeof(string_id))
                        {
                            try
                            {
                                // Get the string constant for this string id.
                                string constant = this.stringIdCache[(string_id)value];
                                return true;
                            }
                            catch (KeyNotFoundException e)
                            {
                                // String id handle is invalid.
                                return false;
                            }
                        }
                        else if (value.GetType() == typeof(string))
                        {
                            try
                            {
                                // Get the string_id handle for this string constant.
                                string_id handle = this.stringIdCache[(string)value];
                                return true;
                            }
                            catch (KeyNotFoundException e)
                            {
                                // String constant was not found in the string id cache.
                                return false;
                            }
                        }
                        else
                        {
                            // Unsupported object type.
                            throw new NotSupportedException("Unsupported object type for reference resolution");
                        }
                    }
                case ReferenceType.DatumIndex:
                    {
                        // Check the value type and handle accordingly.
                        if (value.GetType() == typeof(TagReference))
                        {
                            try
                            {
                                // Cast the value to a TagReference object for easy access.
                                TagReference tagRef = (TagReference)value;

                                // If the tag reference is not null then validate it.
                                if (tagRef.Datum != datum_index.NONE)
                                {
                                    // Get the tag instance for the datum_index.
                                    TagInstance tagInstance = this.tagCache[tagRef.Datum];

                                    // Check to make sure the datim index matches exactly.
                                    if (tagRef.Datum != tagInstance.Datum)
                                    {
                                        // The datum does not match exactly, the reference is invalid.
                                        return false;
                                    }

                                    // TODO: Make sure the group tag (or parent/grandparent group tag) for the tag instance matches
                                    // the allowed group tag for the tag reference.
                                }

                                return true;
                            }
                            catch (ArgumentOutOfRangeException e)
                            {
                                // Failed to get the tag instance using the datum index.
                                return false;
                            }
                        }
                        else if (value.GetType() == typeof(datum_index))
                        {
                            // Check if the datum index exists in the tag cache.
                            return this.tagCache.Contains((datum_index)value);
                        }
                        else
                        {
                            // Unsupported object type.
                            throw new NotSupportedException("Unsupported object type for reference resolution");
                        }
                    }
                default:
                    {
                        // Reference type not supported.
                        throw new NotSupportedException(string.Format("Reference type {0} is not currently supported", type.ToString()));
                    }
            }
        }

        public byte[] LocateRawData(int offset, int size)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
