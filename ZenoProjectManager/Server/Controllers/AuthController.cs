using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using ZenoProjectManager.Server.Model;
using ZenoProjectManager.Shared.Entities;
using Microsoft.Extensions.Configuration;
using System.Text;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using ZenoProjectManager.Shared.Entities.ResponseFormats;
using ZenoProjectManager.Server.Middleware;
using ZenoProjectManager.Shared.Entities.RequestFormats;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Google;
using System.Net.Http.Json;
using System.Net.Http.Headers;
using ZenoProjectManager.Server.Services;

namespace ZenoProjectManager.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<AuthController> _logger;
        private readonly IUserRepository _userRepository;
        private readonly IConfiguration _configuration;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IGoogleAuthenticationService _googleAuthenticationService;

        public AuthController(ILogger<AuthController> logger, IHttpClientFactory httpClientFactory,
            IUserRepository userRepository, IConfiguration configuration,
            IGoogleAuthenticationService googleAuthenticationService)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
            _userRepository = userRepository;
            _configuration = configuration;
            _googleAuthenticationService = googleAuthenticationService;
        }

        /// <summary>
        /// POST: /api/auth/registerUser - Register a new general user to the system.
        /// </summary>
        /// <returns>A JWT token</returns>
        [HttpPost("registerUser")]
        public async Task<ActionResult<AuthenticationResponse>> RegisterUser(User user)
        {
            try
            {
                // Check if the posted data is null and the user email and password is empty.
                if (user.Email == "" || user.Password == "")
                {
                    _logger.LogError($"Method: {nameof(RegisterUser)}" +
                                      $"Message: 'Invalid request format.'");
                    return BadRequest();
                }

                // Check weather a user with the same email exists.
                var exists = await _userRepository.GetByEmail(user.Email);

                if (exists != null)
                {
                    _logger.LogError($"Method: {nameof(RegisterUser)}" +
                                     $"Message: 'user with the email ${user.Email} already exist'");
                    return StatusCode(StatusCodes.Status400BadRequest, "user already exists");
                }

                user.Id = Guid.NewGuid();
                user.Role = "user";

                // hash password
                user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);

                var created = await _userRepository.Add(user);

                _logger.LogInformation($"Method: {nameof(RegisterUser)}" +
                                       $"Message: 'A new user with the email ${user.Email} created'");

                var token = AuthorizationHelper.GenerateToken(user, _configuration["Authorization:JWT:SecretKey"]);
                return await Task.FromResult(new AuthenticationResponse()
                {
                    Token = token
                });
            }
            catch (Exception)
            {
                _logger.LogError($"Method: {nameof(RegisterUser)}" +
                    $"Message: 'Error creating User in the database'");

                return StatusCode(StatusCodes.Status500InternalServerError, "Error creating User in the database");
            }
        }

        /// <summary>
        /// POST: /api/auth/registerAdmin - Register a new admin user to the system.
        /// </summary>
        /// <returns>A JWT token</returns>
        [HttpPost("registerAdmin")]
        public async Task<ActionResult<AuthenticationResponse>> RegisterAdmin(User user)
        {
            try
            {
                // Check if the posted data is null and the user email and password is empty.
                if (user.Email == "" || user.Password == "")
                {
                    _logger.LogError($"Method: {nameof(RegisterAdmin)}" +
                                      $"Message: 'Invalid request format.'");
                    return BadRequest();
                }

                // Check weather a user with the same name exists.
                var exists = await _userRepository.GetByEmail(user.Email);

                if (exists != null)
                {
                    _logger.LogError($"Method: {nameof(RegisterAdmin)}" +
                                     $"Message: 'user with the email ${user.Email} already exist'");
                    return StatusCode(StatusCodes.Status409Conflict, "user already exists");
                }

                user.Id = Guid.NewGuid();
                user.Role = "admin";

                // hash password
                user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);

                var created = await _userRepository.Add(user);

                _logger.LogInformation($"Method: {nameof(RegisterUser)}" +
                                       $"Message: 'A new user with the email ${user.Email} created'");

                var token = AuthorizationHelper.GenerateToken(user, _configuration["Authorization:JWT:SecretKey"]);
                return await Task.FromResult(new AuthenticationResponse()
                {
                    Token = token
                });
            }
            catch (Exception)
            {
                _logger.LogError($"Method: {nameof(RegisterUser)}" +
                    $"Message: 'Error creating User in the database'");

                return StatusCode(StatusCodes.Status500InternalServerError, "Error creating User in the database");
            }
        }

        /// <summary>
        /// POST: /api/auth/login - Authenticate and login the user to the system.
        /// </summary>
        /// <returns>A Jwt token</returns>
        [HttpPost("login")]
        public async Task<ActionResult<AuthenticationResponse>> AuthenticateUser(User user)
        {
            try
            {
                // Check if the posted data is null and the user email or password is empty.
                if (user.Email == "" || user.Password == "")
                {
                    _logger.LogError($"Method: {nameof(AuthenticateUser)}" +
                                      $"Message: 'Invalid request format.'");
                    return BadRequest();
                }

                // Check weather a user with the email exists.
                var result = await _userRepository.GetByEmail(user.Email);
                 
                if (result != null)
                {
                    // verify the provided password is valid.
                    if (BCrypt.Net.BCrypt.Verify(user.Password, result.Password))
                    {

                        var token = AuthorizationHelper.GenerateToken(result, _configuration["Authorization:JWT:SecretKey"]);
                        return await Task.FromResult(new AuthenticationResponse()
                        {
                            Token = token
                        });
                    }
                    return StatusCode(StatusCodes.Status401Unauthorized, "Provided password is incorrect"); ;
                }
                return StatusCode(StatusCodes.Status404NotFound, "user doesn't exists"); ;
            }
            catch (Exception)
            {
                _logger.LogError($"Method: {nameof(AuthenticateUser)}" +
                    $"Message: 'Error authenticating the user'");

                return StatusCode(StatusCodes.Status500InternalServerError, "Error authenticating the user");
            }
        }

        /// <summary>
        /// POST: /api/auth/getuser - Returns the user details after verifing the token.
        /// </summary>
        /// <returns>Details of the user</returns>
        [HttpPost("getuser")]
        public async Task<ActionResult<User>> GetUserByJWT(TokenRequest tokenRequest)
        {
            try
            {
                string userId = AuthorizationHelper.ValidateToken(tokenRequest.JwtToken,
                                _configuration["Authorization:JWT:SecretKey"]);
                return await _userRepository.GetById(Guid.Parse(userId));
            }
            catch (Exception)
            {
                _logger.LogError($"Method: {nameof(GetUserByJWT)}" +
                        $"Message: 'Error fetching the user from from the database'");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error authenticating the user");
            }
        }

        /// <summary>
        /// GET: /api/auth/getgoogleclientid - Returns concat string of client id and redirect url.
        /// </summary>
        /// <returns>Client id and redirect url as a string </returns>
        [HttpGet("getgoogleclientid")]
        public ActionResult<string> GetGoogleClientID()
        {
            return _configuration["Authentication:Google:ClientId"] + "&" +
                   _configuration["Authentication:Google:CallbackUrl"];
        }

        /// <summary>
        /// POST: /api/auth/googleSignUpUser - Register a new general user to the system using google authentication.
        /// </summary>
        /// <returns>A JWT token</returns>
        [HttpPost("googleSignUpUser")]
        public async Task<ActionResult<AuthenticationResponse>> GoogleSignupUser([FromBody] GoogleAuthRequest googleAuthRequest)
        {
            var clientId = _configuration["Authentication:Google:ClientId"];
            var clientSecret = _configuration["Authentication:Google:ClientSecret"];
            var redirectUri = _configuration["Authentication:Google:CallbackUrl"];
            var token = string.Empty;

            GoogleTokenResponse accessTokenResponse = await _googleAuthenticationService.
                GetAccessToken(googleAuthRequest.Code, clientId, clientSecret, redirectUri);

            //check if the access token is null.
            if(accessTokenResponse == null)
            {
                _logger.LogError($"Method: {nameof(GoogleSignupUser)}" +
                  $"Message: 'Invalid request format.'");
                return BadRequest();
            }

            _logger.LogInformation("App Access Token successfully generated.");

            var userProfile = await _googleAuthenticationService.GetUserProfile(accessTokenResponse.access_token);

            // Check weather a user with the email exists.
            var user = await _userRepository.GetByEmail(userProfile.email);

            if (user != null)
            {
                token = AuthorizationHelper.GenerateToken(user, _configuration["Authorization:JWT:SecretKey"]);
                return await Task.FromResult(new AuthenticationResponse()
                {
                    Token = token
                });
            }
   
            User newUser = new User() {Id = Guid.NewGuid(), Email = userProfile.email, FirstName = userProfile.given_name,
                LastName = userProfile.family_name, Avatar = userProfile.picture, Password = "", Role = "user"};
            var created = await _userRepository.Add(newUser);

            token = AuthorizationHelper.GenerateToken(newUser, _configuration["Authorization:JWT:SecretKey"]);
            return await Task.FromResult(new AuthenticationResponse()
            {
                Token = token
            });    
        }

        /// <summary>
        /// POST: /api/auth/googleSignUpAdmin - Register a new admin user to the system using google authentication.
        /// </summary>
        /// <returns>A JWT token</returns>
        [HttpPost("googleSignUpAdmin")]
        public async Task<ActionResult<AuthenticationResponse>> GoogleSignupAdmin([FromBody] GoogleAuthRequest googleAuthRequest)
        {
            var clientId = _configuration["Authentication:Google:ClientId"];
            var clientSecret = _configuration["Authentication:Google:ClientSecret"];
            var redirectUri = _configuration["Authentication:Google:CallbackUrl"];
            var token = string.Empty;

            GoogleTokenResponse accessTokenResponse = await _googleAuthenticationService.
                GetAccessToken(googleAuthRequest.Code, clientId, clientSecret, redirectUri);

            //check if the access token is null.
            if (accessTokenResponse == null)
            {
                _logger.LogError($"Method: {nameof(GoogleSignupAdmin)}" +
                  $"Message: 'Invalid request format.'");
                return BadRequest();
            }

            _logger.LogInformation("App Access Token successfully generated.");

            var userProfile = await _googleAuthenticationService.GetUserProfile(accessTokenResponse.access_token);

            // Check weather a user with the email exists.
            var user = await _userRepository.GetByEmail(userProfile.email);
            _logger.LogInformation(userProfile.email);

            if (user != null)
            {
                token = AuthorizationHelper.GenerateToken(user, _configuration["Authorization:JWT:SecretKey"]);
                return await Task.FromResult(new AuthenticationResponse()
                {
                    Token = token
                });
            }

            User newUser = new User()
            {
                Id = Guid.NewGuid(),
                Email = userProfile.email,
                FirstName = userProfile.given_name,
                LastName = userProfile.family_name,
                Avatar = userProfile.picture,
                Password = "",
                Role = "admin"
            };
            var created = await _userRepository.Add(newUser);

            token = AuthorizationHelper.GenerateToken(newUser, _configuration["Authorization:JWT:SecretKey"]);
            return await Task.FromResult(new AuthenticationResponse()
            {
                Token = token
            });
        }

        [HttpPost("googlelogin")]
        public async Task<ActionResult<AuthenticationResponse>> GoogleLogin([FromBody] GoogleAuthRequest googleAuthRequest)
        {
            var clientId = _configuration["Authentication:Google:ClientId"];
            var clientSecret = _configuration["Authentication:Google:ClientSecret"];
            var redirectUri = _configuration["Authentication:Google:CallbackUrl"];
            var token = string.Empty;

            GoogleTokenResponse accessTokenResponse = await _googleAuthenticationService.
                GetAccessToken(googleAuthRequest.Code, clientId, clientSecret, redirectUri);

            //check if the access token is null.
            if (accessTokenResponse == null)
            {
                _logger.LogError($"Method: {nameof(GoogleSignupAdmin)}" +
                  $"Message: 'Invalid request format.'");
                return BadRequest();
            }

            _logger.LogInformation("App Access Token successfully generated.");

            var userProfile = await _googleAuthenticationService.GetUserProfile(accessTokenResponse.access_token);

            // Check weather a user with the email exists.
            var user = await _userRepository.GetByEmail(userProfile.email);
            _logger.LogInformation(userProfile.email);

            if (user != null)
            {
                token = AuthorizationHelper.GenerateToken(user, _configuration["Authorization:JWT:SecretKey"]);
                return await Task.FromResult(new AuthenticationResponse()
                {
                    Token = token
                });
            }
            return StatusCode(StatusCodes.Status404NotFound, "user doesn't exists"); ;
        }
    }
}