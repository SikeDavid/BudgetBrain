using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace BudgetBrainDesktop.Models
{
    public class EntriesModel
    {
        [JsonPropertyName("entry_id")]
        public int Id { get; set; }
        [JsonPropertyName("category_id")]
        public int CategoryId { get; set; }
        [JsonPropertyName("category")]
        public string Category { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("amount")]
        public int Amount { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("date")]
        public string Date { get; set; }
        [JsonPropertyName("completed")]
        public int Completed { get; set; }

        public class Post
        {
            [JsonPropertyName("categoryid")]
            public int Categoryid { get; set; }
            [JsonPropertyName("amount")]
            public int Amount { get; set; }
            [JsonPropertyName("description")]
            public string Description { get; set; }
            [JsonPropertyName("date")]
            public string Date { get; set; }
        }
    }
}
