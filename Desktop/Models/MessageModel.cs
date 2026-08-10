using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace BudgetBrainDesktop.Models
{
    public class MessageModel
    {
        [JsonPropertyName("message")]
        public string Message { get; set; } = string.Empty;
    }
}
