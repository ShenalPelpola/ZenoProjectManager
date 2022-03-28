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
    public class ProjectUserService : IProjectUserService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<ProjectUserService> _logger;
        private readonly string base_uri = "/api/projectuser";

        public ProjectUserService(HttpClient httpClient,
            ILogger<ProjectUserService> logger)
        {
            _logger = logger;
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<User>> GetUsersInProject(Guid projectId)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<User>>($"{base_uri}/{projectId}");
        }

        public async Task<bool> AddUserToProject(ProjectUser projectUser)
        {
            var response = await _httpClient.PostAsJsonAsync(base_uri, projectUser);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }

            _logger.LogWarning(
                $"Method: {nameof(AddUserToProject)}" +
                $"Message: 'Request failed due to ${response.ReasonPhrase} status code: ${response.StatusCode}'");

            return false;
        }

        public async Task<ProjectUser> DeleteUserFromProject(Guid projectId, string email)
        {
            var response = await _httpClient.DeleteAsync($"{base_uri}?projectId={projectId}&email={email}");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<ProjectUser>();
            }

            _logger.LogWarning(
                $"Method: {nameof(DeleteUserFromProject)}" +
                $"Message: 'Request failed due to ${response.ReasonPhrase} status code: ${response.StatusCode}'");

            return null;
        }

        public async Task<IEnumerable<Project>> GetUserProjects(Guid userId)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Project>>($"{base_uri}?userId={userId}");
        }
    }
}
