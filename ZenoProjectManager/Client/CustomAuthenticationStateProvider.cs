using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using ZenoProjectManager.Client.Services;
using ZenoProjectManager.Shared.Entities;

namespace ZenoProjectManager.Client
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly IAuthService _authService;
        private readonly ILocalStorageService _localStorageService;

        public CustomAuthenticationStateProvider(IAuthService authService, ILocalStorageService localStorageService)
        {
            _authService = authService;
            _localStorageService = localStorageService;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var jwtToken = await _localStorageService.GetItemAsync<string>("jwt_token");
            User currentUser = await _authService.GetUserByJwt(jwtToken);

            if (currentUser != null && currentUser.Id != Guid.Empty)
            {
                //create claims
                var claimEmail = new Claim(ClaimTypes.Email, currentUser.Email);
                var claimNameIdentifier = new Claim(ClaimTypes.NameIdentifier, currentUser.Id.ToString());
                var claimRole = new Claim(ClaimTypes.Role, currentUser.Role == null ? "" : currentUser.Role);

                //create claimsIdentity
                var claimsIdentity = new ClaimsIdentity(new[] { claimNameIdentifier, claimEmail, claimRole }, "serverAuth");
                //create claimsPrincipal
                var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
                return new AuthenticationState(claimsPrincipal);
            }
            else
                return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
        }
    }
}
