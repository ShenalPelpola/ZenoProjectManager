using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using ZenoAuthServiceAPI.Entities.ResponseFormats;

namespace ZenoAuthServiceAPI.Services
{
    public interface IGoogleAuthenticationService
    {
        Task<GoogleTokenResponse> GetAccessToken(string code, string clientId, string clientSecret, string redirectUri);
        Task<GoogleProfileResponse> GetUserProfile(string accessToken);
    }
}
