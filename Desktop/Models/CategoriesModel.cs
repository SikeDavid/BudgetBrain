using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace BudgetBrainDesktop.Models
{
    public class CategoriesModel
    {
        [JsonPropertyName("category_id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("in_use")]
        public int inUse { get; set; }

        public class Get
        {
            [JsonPropertyName("category_id")]
            public int Id { get; set; }
            [JsonPropertyName("name")]
            public string Name { get; set; }
            [JsonPropertyName("type")]
            public string Type { get; set; }
            [JsonPropertyName("in_use")]
            public int inUse { get; set; }
        }

        public class Post
        {
            [JsonPropertyName("name")]
            public string Name { get; set; }
            [JsonPropertyName("type")]
            public string Type { get; set; }
            [JsonPropertyName("in_use")]
            public int InUse { get; set; }
        }
    }
}
