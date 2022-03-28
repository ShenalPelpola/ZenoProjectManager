using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using ZenoProjectManager.Shared.Entities;

namespace ZenoProjectManager.Client.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<UserService> _logger;
        private readonly string base_uri = "/api/user";

        public UserService(HttpClient httpClient,
            ILogger<UserService> logger)
        {
            _logger = logger;
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<User>>(base_uri);
        }

        public async Task<User> GetUserById(Guid id)
        {
            return await _httpClient.GetFromJsonAsync<User>($"{base_uri}/{id}");
        }

        public async Task<User> DeleteUser(string email)
        {
            var response = await _httpClient.DeleteAsync($"{base_uri}/{email}");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<User>();
            }

            _logger.LogWarning(
                $"Method: {nameof(DeleteUser)}" +
                $"Message: 'Request failed due to ${response.ReasonPhrase} status code: ${response.StatusCode}'");

            return null;
        }

        public async Task<User> UpdateUser(User user)
        {
            var response = await _httpClient.PutAsJsonAsync(base_uri, user);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<User>();
            }

            _logger.LogWarning(
                $"Method: {nameof(UpdateUser)}" +
                $"Message: 'Request failed due to ${response.ReasonPhrase} status code: ${response.StatusCode}'");

            return null;
        }
    }
}
