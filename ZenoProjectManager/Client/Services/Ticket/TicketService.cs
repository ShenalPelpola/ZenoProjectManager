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
    public class TicketService : ITicketService
    {
        private readonly HttpClient _httpClient;
        private readonly string base_uri = "/api/ticket";
        private readonly ILogger<TicketService> _logger;

        public TicketService(HttpClient httpClient,
            ILogger<TicketService> logger)
        {
            _logger = logger;
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Ticket>> GetTickets(string projectId)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Ticket>>($"{base_uri}?projectId={projectId}");
        }

        public async Task<Ticket> GetTicketById(Guid id)
        {
            return await _httpClient.GetFromJsonAsync<Ticket>($"{base_uri}/{id}");
        }

        public async Task<Ticket> CreateTicket(Ticket ticket)
        {
            var response = await _httpClient.PostAsJsonAsync(base_uri, ticket);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Ticket>();
            }

            _logger.LogWarning(
                $"Method: {nameof(CreateTicket)}" +
                $"Message: 'Request failed due to ${response.ReasonPhrase} status code: ${response.StatusCode}'");

            return null;
        }

        public async Task<Ticket> DeleteTicket(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"{base_uri}/{id}");

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Ticket>();
            }

            _logger.LogWarning(
                $"Method: {nameof(DeleteTicket)}" +
                $"Message: 'Request failed due to ${response.ReasonPhrase} status code: ${response.StatusCode}'");

            return null;
        }

        public async Task<Ticket> UpdateTicket(Ticket ticket)
        {
            var response = await _httpClient.PutAsJsonAsync(base_uri, ticket);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Ticket>();
            }

            _logger.LogWarning(
                $"Method: {nameof(UpdateTicket)}" +
                $"Message: 'Request failed due to ${response.ReasonPhrase} status code: ${response.StatusCode}'");

            return null;
        }

        public async Task<Ticket> UpdateTicketStatus(Ticket ticket)
        {
            var response = await _httpClient.PutAsJsonAsync($"{base_uri}/status", ticket);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<Ticket>();
            }

            _logger.LogWarning(
                $"Method: {nameof(UpdateTicketStatus)}" +
                $"Message: 'Request failed due to ${response.ReasonPhrase} status code: ${response.StatusCode}'");

            return null;
        }
    }
}
