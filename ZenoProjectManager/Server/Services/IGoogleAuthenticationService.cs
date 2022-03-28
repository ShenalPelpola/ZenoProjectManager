using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using ZenoProjectManager.Shared.Entities;
using ZenoProjectManager.Shared.Entities.ResponseFormats;

namespace ZenoProjectManager.Server.Services
{
    public interface IGoogleAuthenticationService
    {
        Task<GoogleTokenResponse> GetAccessToken(string code, string clientId, string clientSecret, string redirectUri);
        Task<GoogleProfileResponse> GetUserProfile(string accessToken);
    }
}
