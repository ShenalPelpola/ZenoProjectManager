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
    public class CompanyService : ICompanyService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<CompanyService> _logger;
        private readonly string base_uri = "/api/company";

        public CompanyService(HttpClient httpClient,
            ILogger<CompanyService> logger)
        {
            _logger = logger;
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Company>> GetCompanies(string userId)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Company>>($"{base_uri}?userId={userId}");
        }

        public async Task<Company> GetCompanyById(Guid id)
        {
            return await _httpClient.GetFromJsonAsync<Company>($"{base_uri}/{id}");
        }

        public async Task<Company> CreateCompany(Company company)
        {
            var response = await _httpClient.PostAsJsonAsync(base_uri, company);

            if (response.IsSuccessStatusCode) 
            {
                return await response.Content.ReadFromJsonAsync<Company>();
            }

            _logger.LogWarning(
                $"Method: {nameof(CreateCompany)}" +
                $"Message: 'Request failed due to ${response.ReasonPhrase} status code: ${response.StatusCode}'");
        
            return null;
        }

        public async Task<Company> DeleteCompany(string name)
        {
            var response = await _httpClient.DeleteAsync($"{base_uri}/{name}");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Company>();
            }

            _logger.LogWarning(
                $"Method: {nameof(DeleteCompany)}" +
                $"Message: 'Request failed due to ${response.ReasonPhrase} status code: ${response.StatusCode}'");

            return null;
        }

        public async Task<Company> UpdateCompany(Company company)
        {
            var response = await _httpClient.PutAsJsonAsync(base_uri, company);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Company>();
            }

            _logger.LogWarning(
                $"Method: {nameof(UpdateCompany)}" +
                $"Message: 'Request failed due to ${response.ReasonPhrase} status code: ${response.StatusCode}'");

            return null;
        }
    }
}
