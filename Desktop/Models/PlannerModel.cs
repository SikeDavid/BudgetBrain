using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace BudgetBrainDesktop.Models
{
    public class PlannerModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("category_id")]
        public int CategoryId { get; set; }
        [JsonPropertyName("category")]
        public string CategoryName { get; set; }
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonPropertyName("name")]
        public string Description { get; set; }
        [JsonPropertyName("amount")]
        public int Amount { get; set; }
        [JsonPropertyName("day_of_month")]
        public int DayofMonth { get; set; }
        [JsonPropertyName("active")]
        public int Active { get; set; }

        public class Post
        {
            [JsonPropertyName("categoryid")]
            public int CategoryId { get; set; }
            [JsonPropertyName("name")]
            public string Description { get; set; }
            [JsonPropertyName("amount")]
            public int Amount { get; set; }
            [JsonPropertyName("dayofmonth")]
            public int DayofMonth { get; set; }
        }
    }
}
