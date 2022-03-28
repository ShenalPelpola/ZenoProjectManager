using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using ZenoProjectManager.Shared.Entities;
using ZenoProjectManager.Shared.Entities.RequestFormats;

namespace ZenoProjectManager.Client.Services.Report
{
    public class ReportService : IReportService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<ReportService> _logger;
        private readonly string base_uri = "/api/report";

        public ReportService(HttpClient httpClient,
            ILogger<ReportService> logger)
        {
            _logger = logger;
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Project>> GetCompletedProjects(ReportRequest reportReqest)
        {
            var response = await _httpClient.PostAsJsonAsync($"{base_uri}/projects/completed", reportReqest);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<IEnumerable<Project>>();
            }

            _logger.LogWarning(
                $"Method: {nameof(GetCompletedProjects)}" +
                $"Message: 'Request failed due to ${response.ReasonPhrase} status code: ${response.StatusCode}'");

            return null;
        }


        public async Task<IEnumerable<Project>> GetInProgressProjects(ReportRequest reportReqest)
        {
            var response = await _httpClient.PostAsJsonAsync($"{base_uri}/projects/in-progress", reportReqest);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<IEnumerable<Project>>();
            }

            _logger.LogWarning(
                $"Method: {nameof(GetInProgressProjects)}" +
                $"Message: 'Request failed due to ${response.ReasonPhrase} status code: ${response.StatusCode}'");

            return null;
        }


        public async Task<IEnumerable<Ticket>> GetCompletedTicketsInCompany(ReportRequest reportRequest)
        {
            var response = await _httpClient.PostAsJsonAsync($"{base_uri}/companyTickets/completed", reportRequest);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<IEnumerable<Ticket>>();
            }

            _logger.LogWarning(
                $"Method: {nameof(GetCompletedTicketsInCompany)}" +
                $"Message: 'Request failed due to ${response.ReasonPhrase} status code: ${response.StatusCode}'");

            return null;
        }

        public async Task<IEnumerable<Ticket>> GetCompletedTicketsInProject(ReportRequest reportReqest)
        {
            var response = await _httpClient.PostAsJsonAsync($"{base_uri}/projectTickets/completed", reportReqest);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<IEnumerable<Ticket>>();
            }

            _logger.LogWarning(
                $"Method: {nameof(GetCompletedTicketsInProject)}" +
                $"Message: 'Request failed due to ${response.ReasonPhrase} status code: ${response.StatusCode}'");

            return null;
        }

        public async Task<IEnumerable<Ticket>> GetTicketsByStatusInCompany(ReportRequest reportRequest)
        {
            var response = await _httpClient.PostAsJsonAsync($"{base_uri}/companyTickets/status", reportRequest);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<IEnumerable<Ticket>>();
            }

            _logger.LogWarning(
                $"Method: {nameof(GetTicketsByStatusInCompany)}" +
                $"Message: 'Request failed due to ${response.ReasonPhrase} status code: ${response.StatusCode}'");

            return null;
        }

        public async Task<IEnumerable<Ticket>> GetTicketsByStatusInProject(ReportRequest reportReqest)
        {
            var response = await _httpClient.PostAsJsonAsync($"{base_uri}/projectTickets/status", reportReqest);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<IEnumerable<Ticket>>();
            }

            _logger.LogWarning(
                $"Method: {nameof(GetTicketsByStatusInProject)}" +
                $"Message: 'Request failed due to ${response.ReasonPhrase} status code: ${response.StatusCode}'");

            return null;
        }
    }
}
