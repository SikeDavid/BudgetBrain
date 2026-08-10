using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace BudgetBrainDesktop.Services
{
    public class TokenStorage
    {
        public static string AccessToken { get; set; } = string.Empty;
        public static string RefreshToken { get; set; } = string.Empty;

        public static void Clear()
        {
            AccessToken = string.Empty;
            RefreshToken = string.Empty;
        }

        internal class LogoutToken
        {
            [JsonPropertyName("refreshToken")]
            public string RefreshToken { get; set; } = string.Empty;
        }
    }
    internal class RefreshTokenResponse
    {
        public string AccessToken { get; set; } = string.Empty;
    }


}
