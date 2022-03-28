using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using ZenoProjectManager.Client.Services.Prediction;
using ZenoProjectManager.Shared.Entities.RequestFormats;
using ZenoProjectManager.Shared.Entities.ResponseFormats;

namespace ZenoProjectManager.Client.Services
{
    public class PredictionService : IPredictionService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<PredictionService> _logger;
        private readonly string base_uri = "https://localhost:8081/api/prediction";

        public PredictionService(HttpClient httpClient,
            ILogger<PredictionService> logger)
        {
            _logger = logger;
            _httpClient = httpClient;
        }
        public async Task<PredictionResponse> GetProjectsPrediction(PredictionRequest predictionRequest)
        {
            var response = await _httpClient.PostAsJsonAsync($"{base_uri}/projects", predictionRequest);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<PredictionResponse>();
            }

            _logger.LogWarning(
                $"Method: {nameof(GetProjectsPrediction)}" +
                $"Message: 'Request failed due to ${response.ReasonPhrase} status code: ${response.StatusCode}'");

            return null;
        }

        public async Task<IEnumerable<UserPredictionResponse>> GetUserPrediction(PredictionRequest predictionRequest)
        {
            var response = await _httpClient.PostAsJsonAsync($"{base_uri}/users", predictionRequest);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<IEnumerable<UserPredictionResponse>>();
            }

            _logger.LogWarning(
                $"Method: {nameof(GetUserPrediction)}" +
                $"Message: 'Request failed due to ${response.ReasonPhrase} status code: ${response.StatusCode}'");

            return null;
        }
    }
}
