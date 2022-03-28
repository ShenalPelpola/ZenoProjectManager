using Blazored.LocalStorage;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using ZenoProjectManager.Shared.Entities;
using ZenoProjectManager.Shared.Entities.RequestFormats;
using ZenoProjectManager.Shared.Entities.ResponseFormats;

namespace ZenoProjectManager.Client.Services
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorageService;
        private readonly ILogger<CompanyService> _logger;
        private readonly string base_uri = "https://localhost:8080/api/auth";

        public AuthService(HttpClient httpClient,
            ILogger<CompanyService> logger, ILocalStorageService localStorageService)
        {
            _logger = logger;
            _httpClient = httpClient;
            _localStorageService = localStorageService;
        }

        /// <summary>
        /// API call to register a new admin user to the system.
        /// </summary>
        /// <returns>A JWT token</returns>     
        public async Task<AuthenticationResponse> RegisterAdmin(User user)
        {
            var response = await _httpClient.PostAsJsonAsync($"{base_uri}/registerAdmin", user);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<AuthenticationResponse>();
            }

            _logger.LogWarning(
                $"Method: {nameof(RegisterAdmin)}" +
                $"Message: 'Request failed due to ${response.ReasonPhrase} status code: ${response.StatusCode}'");

            return null;
        }

        /// <summary>
        /// API call to register a new user to the system.
        /// </summary>
        /// <returns>A JWT token</returns> 
        public async Task<AuthenticationResponse> RegisterUser(User user)
        {
            var response = await _httpClient.PostAsJsonAsync($"{base_uri}/registerUser", user);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<AuthenticationResponse>();
            }

            _logger.LogWarning(
                $"Method: {nameof(RegisterAdmin)}" +
                $"Message: 'Request failed due to ${response.ReasonPhrase} status code: ${response.StatusCode}'");

            return null;
        }

        /// <summary>
        /// API call to login the user to the system.
        /// </summary>
        /// <returns>A JWT token</returns> 
        public async Task<AuthenticationResponse> Login(User user)
        {
            var response = await _httpClient.PostAsJsonAsync($"{base_uri}/login", user);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<AuthenticationResponse>();
            }

            _logger.LogWarning(
                $"Method: {nameof(Login)}" +
                $"Message: 'Request failed due to ${response.ReasonPhrase} status code: ${response.StatusCode}'");

            return null;
        }

        /// <summary>
        /// API call to get the user details from the system.
        /// </summary>
        /// <returns>User details/returns> 
        public async Task<User> GetUserByJwt(string jwtToken)
        {
            // check if the token exist in the local storage.
            if (jwtToken == null)
            {
                return null;
            }

            var tokenrequest = new TokenRequest() { JwtToken = jwtToken };  
            // send a post request with jwt token
            var response = await _httpClient.PostAsJsonAsync($"{base_uri}/getuser", tokenrequest);

            // if response is successfull
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<User>();
            }
            return null;
        }

        /// <summary>
        /// API call to get the google access token.
        /// </summary>
        /// <returns>A Google client id and redirect uri</returns>     
        public async Task<string> GetGoogleClientID()
        {
            return await _httpClient.GetStringAsync($"{base_uri}/getgoogleclientid");
        }

        /// <summary>
        /// API call to autherize the admin user from google services.
        /// </summary>
        /// <returns>JWT token</returns>
        public async Task<string> GoogleSignUpAdmin(string code)
        {
            var httpMessageResponse = await _httpClient.PostAsJsonAsync($"{base_uri}/googleSignUpAdmin", new GoogleAuthRequest { Code = code });

            return (await httpMessageResponse.Content.ReadFromJsonAsync<AuthenticationResponse>()).Token;
        }

        /// <summary>
        /// API call to autherize the admin user from google services.
        /// </summary>
        /// <returns>JWT token</returns>
        public async Task<string> GoogleLogin(string code)
        {
            var httpMessageResponse = await _httpClient.PostAsJsonAsync($"{base_uri}/googlelogin", new GoogleAuthRequest { Code = code });

            return (await httpMessageResponse.Content.ReadFromJsonAsync<AuthenticationResponse>()).Token;
        }

        /// <summary>
        /// API call to autherize the user from google services.
        /// </summary>
        /// <returns>JWT token</returns>
        public async Task<string> GoogleSignUpUser(string code)
        {
            var httpMessageResponse = await _httpClient.PostAsJsonAsync($"{base_uri}/googleSignUpUser", new GoogleAuthRequest { Code = code });

            return (await httpMessageResponse.Content.ReadFromJsonAsync<AuthenticationResponse>()).Token;
        }
    }
}
