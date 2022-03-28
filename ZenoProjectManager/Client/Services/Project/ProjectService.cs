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
    public class ProjectService : IProjectService
    {
        private readonly HttpClient _httpClient;
        private readonly string base_uri = "/api/project";
        private readonly ILogger<ProjectService> _logger;

        public ProjectService(HttpClient httpClient,
            ILogger<ProjectService> logger)
        {
            _logger = logger;
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Project>> GetProjects(string companyId)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Project>>($"{base_uri}?companyId={companyId}");
        }

        public async Task<Project> GetProjectById(Guid id)
        {
            return await _httpClient.GetFromJsonAsync<Project>($"{base_uri}/{id}");
        }


        public async Task<Project> CreateProject(Project project)
        {
            var response = await _httpClient.PostAsJsonAsync(base_uri, project);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Project>();
            }

            _logger.LogWarning(
                $"Method: {nameof(CreateProject)}" +
                $"Message: 'Request failed due to ${response.ReasonPhrase} status code: ${response.StatusCode}'");

            return null;
        }

        public async Task<Project> DeleteProject(string name, Guid companyId)
        {
            var response = await _httpClient.DeleteAsync($"{base_uri}?name={name}&companyId={companyId}");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Project>();
            }

            _logger.LogWarning(
                $"Method: {nameof(DeleteProject)}" +
                $"Message: 'Request failed due to ${response.ReasonPhrase} status code: ${response.StatusCode}'");

            return null;
        }

        public async Task<Project> UpdateProject(Project project)
        {
            var response = await _httpClient.PutAsJsonAsync(base_uri, project);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Project>();
            }

            _logger.LogWarning(
                $"Method: {nameof(UpdateProject)}" +
                $"Message: 'Request failed due to ${response.ReasonPhrase} status code: ${response.StatusCode}'");

            return null;
        }
    }
}
