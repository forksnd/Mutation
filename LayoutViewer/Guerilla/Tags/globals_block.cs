using LayoutViewer.Guerilla.Attributes;
using Mutation.HEK.Common;
using Mutation.HEK.Common.TagFieldDefinitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayoutViewer.Guerilla.Tags
{
    public class globals_block
    {
        [GuerillaPreProcess("globals_block")]
        public static void PreProcess(TagBlockDefinition tagBlock)
        {
            // Remove the old padding field.
            tagBlock.TagFields[0].RemoveAt(tagBlock.TagFields[0].Count - 2);

            // Add in the unicode cache fields.
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_pad, definition_address = 8 });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_long_integer, Name = "English String Count" });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_long_integer, Name = "English String Table Size" });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_long_integer, Name = "English String Index Offset" });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_long_integer, Name = "English String Table Offset" });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_pad, definition_address = 4 });

            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_pad, definition_address = 8 });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_long_integer, Name = "Japanese String Count" });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_long_integer, Name = "Japanese String Table Size" });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_long_integer, Name = "Japanese String Index Offset" });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_long_integer, Name = "Japanese String Table Offset" });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_pad, definition_address = 4 });

            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_pad, definition_address = 8 });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_long_integer, Name = "German String Count" });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_long_integer, Name = "German String Table Size" });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_long_integer, Name = "German String Index Offset" });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_long_integer, Name = "German String Table Offset" });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_pad, definition_address = 4 });

            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_pad, definition_address = 8 });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_long_integer, Name = "French String Count" });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_long_integer, Name = "French String Table Size" });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_long_integer, Name = "French String Index Offset" });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_long_integer, Name = "French String Table Offset" });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_pad, definition_address = 4 });

            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_pad, definition_address = 8 });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_long_integer, Name = "Spanish String Count" });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_long_integer, Name = "Spanish String Table Size" });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_long_integer, Name = "Spanish String Index Offset" });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_long_integer, Name = "Spanish String Table Offset" });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_pad, definition_address = 4 });

            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_pad, definition_address = 8 });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_long_integer, Name = "Italian String Count" });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_long_integer, Name = "Italian String Table Size" });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_long_integer, Name = "Italian String Index Offset" });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_long_integer, Name = "Italian String Table Offset" });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_pad, definition_address = 4 });

            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_pad, definition_address = 8 });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_long_integer, Name = "Korean String Count" });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_long_integer, Name = "Korean String Table Size" });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_long_integer, Name = "Korean String Index Offset" });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_long_integer, Name = "Korean String Table Offset" });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_pad, definition_address = 4 });

            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_pad, definition_address = 8 });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_long_integer, Name = "Chinese String Count" });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_long_integer, Name = "Chinese String Table Size" });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_long_integer, Name = "Chinese String Index Offset" });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_long_integer, Name = "Chinese String Table Offset" });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_pad, definition_address = 4 });

            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_pad, definition_address = 8 });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_long_integer, Name = "Portuguese String Count" });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_long_integer, Name = "Portuguese String Table Size" });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_long_integer, Name = "Portuguese String Index Offset" });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_long_integer, Name = "Portuguese String Table Offset" });
            tagBlock.TagFields[0].Insert(tagBlock.TagFields[0].Count - 1, new tag_field() { type = field_type._field_pad, definition_address = 4 });
        }
    }
}
