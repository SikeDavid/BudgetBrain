using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace BudgetBrainDesktop.Models
{
    public class FeedbackModel
    {
        [JsonPropertyName("feedback_id")]
        public int Id { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("message")]
        public string Message { get; set; }
        [JsonPropertyName("username")]
        public string Username { get; set; } = string.Empty;
        [JsonPropertyName("foreign_email")]
        public string Quest { get; set; } = string.Empty;
        [JsonPropertyName("is_read")]
        public int Readed { get; set; }
    }
}
