using BudgetBrainDesktop.Models;
using BudgetBrainDesktop.Properties;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace BudgetBrainDesktop.Services
{
    public static class ApiService
    {
        private static readonly HttpClient client = new HttpClient();

        static ApiService()
        {
            client.BaseAddress = new Uri(Resources.BaseAddress);
        }

        private static void AddToken()
        {
            if(string.IsNullOrWhiteSpace(TokenStorage.AccessToken))
            {
                client.DefaultRequestHeaders.Authorization = null;
                return;
            }

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", TokenStorage.AccessToken);
        }

        private static async Task<bool> RefreshAccessToken()
        {
            if (string.IsNullOrWhiteSpace(TokenStorage.RefreshToken))
            {
                return false;
            }

            var body = new
            {
                refreshToken = TokenStorage.RefreshToken
            };

            HttpResponseMessage response = await client.PostAsJsonAsync("auth/refresh", body);

            if (!response.IsSuccessStatusCode)
            {
                return false;
            }

            RefreshTokenResponse? refreshResponse = await response.Content.ReadFromJsonAsync<RefreshTokenResponse>();

            if (refreshResponse is null || string.IsNullOrWhiteSpace(refreshResponse.AccessToken))
            {
                return false;
            }

            TokenStorage.AccessToken = refreshResponse.AccessToken;

            return true;
        }

        public static async Task<Res> GetAsync<Res>(string endpoint)
        {
            AddToken();

            HttpResponseMessage response = await client.GetAsync(endpoint);

            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized &&
                !string.IsNullOrWhiteSpace(TokenStorage.RefreshToken))
            {
                bool refreshSuccess = await RefreshAccessToken();

                if (refreshSuccess)
                {
                    AddToken();
                    response = await client.GetAsync(endpoint);
                }
            }

            if (!response.IsSuccessStatusCode)
            {
                MessageModel? error = await response.Content.ReadFromJsonAsync<MessageModel>();
                throw new Exception(error?.Message ?? "unknown error");
            }

            Res? data = await response.Content.ReadFromJsonAsync<Res>();

            if (data is null)
            {
                throw new Exception("Server returned an empty response");
            }

            return data;
        }

        public static async Task<Res> PostAsync<Req, Res>(string endpoint, Req body)
        {
            AddToken();

            HttpResponseMessage response = await client.PostAsJsonAsync(endpoint, body);

            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized &&
                !string.IsNullOrWhiteSpace(TokenStorage.RefreshToken))
            {
                bool refreshSuccess = await RefreshAccessToken();

                if (refreshSuccess)
                {
                    AddToken();
                    response = await client.PostAsJsonAsync(endpoint, body);
                }
            }

            if (!response.IsSuccessStatusCode)
            {
                MessageModel? error = await response.Content.ReadFromJsonAsync<MessageModel>();
                throw new Exception(error?.Message ?? "unknown error");
            }

            return await response.Content.ReadFromJsonAsync<Res>();
        }

        public static async Task<MessageModel> PatchAsync<Req>(string endpoint, Req body)
        {
            AddToken();

            HttpResponseMessage response = await client.PatchAsJsonAsync(endpoint, body);

            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized &&
                !string.IsNullOrWhiteSpace(TokenStorage.RefreshToken))
            {
                bool refreshSuccess = await RefreshAccessToken();

                if (refreshSuccess)
                {
                    AddToken();
                    response = await client.PatchAsJsonAsync(endpoint, body);
                }
            }

            if (!response.IsSuccessStatusCode)
            {
                MessageModel? error = await response.Content.ReadFromJsonAsync<MessageModel>();

                throw new Exception(error?.Message ?? "unknown error");
            }

            MessageModel? result = await response.Content.ReadFromJsonAsync<MessageModel>();

            if (result is null)
            {
                throw new Exception("unknown response");
            }

            return result;
        }

        public static async Task<MessageModel> DeleteAsync(string endpoint)
        {
            AddToken();

            HttpResponseMessage response = await client.DeleteAsync(endpoint);

            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized &&
                !string.IsNullOrWhiteSpace(TokenStorage.RefreshToken))
            {
                bool refreshSuccess = await RefreshAccessToken();

                if (refreshSuccess)
                {
                    AddToken();
                    response = await client.DeleteAsync(endpoint);
                }
            }

            if (!response.IsSuccessStatusCode)
            {
                MessageModel? error = await response.Content.ReadFromJsonAsync<MessageModel>();
                throw new Exception(error?.Message ?? "unknown error");
            }

            MessageModel result = await response.Content.ReadFromJsonAsync<MessageModel>();
            return result;
        }
    }
}
