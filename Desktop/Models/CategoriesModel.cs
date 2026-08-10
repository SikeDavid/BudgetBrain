using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace BudgetBrainDesktop.Models
{
    public class CategoriesModel
    {
        public class Get
        {
            [JsonPropertyName("category_id")]
            public int Id { get; set; }
            [JsonPropertyName("name")]
            public string Name { get; set; }
            [JsonPropertyName("type")]
            public string Type { get; set; }
        }

        //public class Post
        //{
        //    [JsonPropertyName("categoryid")]
        //    public int Categoryid { get; set; }
        //    [JsonPropertyName("amount")]
        //    public string Amount { get; set; }
        //    [JsonPropertyName("description")]
        //    public string Description { get; set; }
        //    [JsonPropertyName("date")]
        //    public string Date { get; set; }
        //}
    }
}
