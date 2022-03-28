using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.Http.Headers;
using ZenoAuthServiceAPI.Entities.ResponseFormats;
using ZenoAuthServiceAPI.Entities.RequestFormats;

namespace ZenoAuthServiceAPI.Services
{
    public class GoogleAuthenticationService : IGoogleAuthenticationService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public GoogleAuthenticationService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        /*<summary>
           Helper method to get the access token from the google oauth code.
          </summary>
        <returns>A google oauth access token</returns>
        */
        public async Task<GoogleTokenResponse> GetAccessToken(string code, string clientId, string clientSecret, string redirectUri)
        {
            var httpClient = _httpClientFactory.CreateClient();
            var accessTokenRequest = "https://accounts.google.com/o/oauth2/token";
            var accessReqestData = new GoogleAccessTokenRequest()
            {
                code = code,
                client_id = clientId,
                client_secret = clientSecret,
                redirect_uri = redirectUri,
                grant_type = "authorization_code"
            };

            var response = await httpClient.PostAsJsonAsync(accessTokenRequest, accessReqestData);
            return await response.Content.ReadFromJsonAsync<GoogleTokenResponse>();
        }

        /*<summary>
           Helper method to get the user profile data from the access token.
          </summary>
        <returns>A google profile of the user</returns>
        */
        public async Task<GoogleProfileResponse> GetUserProfile(string accessToken)
        {
            var httpClient = _httpClientFactory.CreateClient();
            var userProfileUri = $"https://www.googleapis.com/oauth2/v3/userinfo";
            var profileRequest = new HttpRequestMessage(HttpMethod.Get, userProfileUri);
            profileRequest.Headers.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

            var res = await httpClient.SendAsync(profileRequest);
            return await res.Content.ReadFromJsonAsync<GoogleProfileResponse>();
        }
    }
}