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
    public class multilingual_unicode_string_list_block
    {
        [GuerillaPreProcess("multilingual_unicode_string_list_block")]
        public static void PreProcess(TagBlockDefinition tagBlock)
        {
            // Remove the padding field.
            tagBlock.TagFields[tagBlock.GetFieldSetIndexClosestToH2Xbox()].RemoveAt(2);

            // Add in the unicode string offset/count fields.
            tagBlock.TagFields[tagBlock.GetFieldSetIndexClosestToH2Xbox()].Add(new tag_field { type = field_type._field_short_integer, Name = "English String Index" });
            tagBlock.TagFields[tagBlock.GetFieldSetIndexClosestToH2Xbox()].Add(new tag_field { type = field_type._field_short_integer, Name = "English String Count" });
            tagBlock.TagFields[tagBlock.GetFieldSetIndexClosestToH2Xbox()].Add(new tag_field { type = field_type._field_short_integer, Name = "Japanese String Index" });
            tagBlock.TagFields[tagBlock.GetFieldSetIndexClosestToH2Xbox()].Add(new tag_field { type = field_type._field_short_integer, Name = "Japanese String Count" });
            tagBlock.TagFields[tagBlock.GetFieldSetIndexClosestToH2Xbox()].Add(new tag_field { type = field_type._field_short_integer, Name = "German String Index" });
            tagBlock.TagFields[tagBlock.GetFieldSetIndexClosestToH2Xbox()].Add(new tag_field { type = field_type._field_short_integer, Name = "German String Count" });
            tagBlock.TagFields[tagBlock.GetFieldSetIndexClosestToH2Xbox()].Add(new tag_field { type = field_type._field_short_integer, Name = "French String Index" });
            tagBlock.TagFields[tagBlock.GetFieldSetIndexClosestToH2Xbox()].Add(new tag_field { type = field_type._field_short_integer, Name = "French String Count" });
            tagBlock.TagFields[tagBlock.GetFieldSetIndexClosestToH2Xbox()].Add(new tag_field { type = field_type._field_short_integer, Name = "Spanish String Index" });
            tagBlock.TagFields[tagBlock.GetFieldSetIndexClosestToH2Xbox()].Add(new tag_field { type = field_type._field_short_integer, Name = "Spanish String Count" });
            tagBlock.TagFields[tagBlock.GetFieldSetIndexClosestToH2Xbox()].Add(new tag_field { type = field_type._field_short_integer, Name = "Italian String Index" });
            tagBlock.TagFields[tagBlock.GetFieldSetIndexClosestToH2Xbox()].Add(new tag_field { type = field_type._field_short_integer, Name = "Italian String Count" });
            tagBlock.TagFields[tagBlock.GetFieldSetIndexClosestToH2Xbox()].Add(new tag_field { type = field_type._field_short_integer, Name = "Korean String Index" });
            tagBlock.TagFields[tagBlock.GetFieldSetIndexClosestToH2Xbox()].Add(new tag_field { type = field_type._field_short_integer, Name = "Korean String Count" });
            tagBlock.TagFields[tagBlock.GetFieldSetIndexClosestToH2Xbox()].Add(new tag_field { type = field_type._field_short_integer, Name = "Chinese String Index" });
            tagBlock.TagFields[tagBlock.GetFieldSetIndexClosestToH2Xbox()].Add(new tag_field { type = field_type._field_short_integer, Name = "Chinese String Count" });
            tagBlock.TagFields[tagBlock.GetFieldSetIndexClosestToH2Xbox()].Add(new tag_field { type = field_type._field_short_integer, Name = "Portuguese String Index" });
            tagBlock.TagFields[tagBlock.GetFieldSetIndexClosestToH2Xbox()].Add(new tag_field { type = field_type._field_short_integer, Name = "Portuguese String Count" });
        }
    }
}
