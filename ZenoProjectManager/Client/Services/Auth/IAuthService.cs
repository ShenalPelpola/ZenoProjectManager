using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using ZenoProjectManager.Shared.Entities;
using ZenoProjectManager.Shared.Entities.ResponseFormats;

namespace ZenoProjectManager.Client.Services
{
    public interface IAuthService
    {
        Task<AuthenticationResponse> RegisterAdmin(User user);
        Task<AuthenticationResponse> RegisterUser(User user);
        Task<AuthenticationResponse> Login(User user);
        Task<string> GoogleLogin(string code);
        Task<User> GetUserByJwt(string jwtToken);
        Task<string> GetGoogleClientID();
        Task<string> GoogleSignUpAdmin(string code);
        Task<string> GoogleSignUpUser(string code);
    }
}

