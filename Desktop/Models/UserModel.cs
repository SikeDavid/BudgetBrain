using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace BudgetBrainDesktop.Models
{
    public class UserModel
    {
        [JsonPropertyName("user_id")]
        public int UserId { get; set; }
        [JsonPropertyName("username")]
        public string Username { get; set; } = string.Empty;
        [JsonPropertyName("email")]
        public string Email { get; set; } = string.Empty;
        [JsonPropertyName("user_status")]
        public string UserStatus { get; set; } = string.Empty;
        [JsonPropertyName("role")]
        public string UserRole { get; set; } = string.Empty;

        public class Status
        {
            [JsonPropertyName("status")]
            public string UserStatus { get; set; } = string.Empty;
        }
    }
}
