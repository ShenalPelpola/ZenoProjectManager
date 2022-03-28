using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenoProjectManager.Server.Model;
using ZenoProjectManager.Shared;
using ZenoProjectManager.Shared.Entities;

namespace ZenoProjectManager.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<AuthController> _logger;
        private readonly IUserRepository _userRepository;

        public UserController(ILogger<AuthController> logger,
            IUserRepository userRepository)
        {
            _logger = logger;
            _userRepository = userRepository;
        }

        /* 
         <summary>
             GET: /user - For returning a list of users.
         </summary>
         <returns>An list of users</returns>
        */
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            _logger.LogInformation(
                $"Method: {nameof(GetUsers)}" +
                $"Message: 'return list of users'");

            return Ok(await _userRepository.GetUsers());
        }

        /* 
          <summary>
              GET: /user/{id} - return details of the user. 
          </summary>
          <returns> Details of the retrived user</returns>
        */
        [HttpGet("{id:Guid}")]
        public async Task<ActionResult<User>> GetUserById(Guid id)
        {
            try
            {
                var result = await _userRepository.GetById(id);

                // check whether the user exists.
                if (result == null)
                {
                    _logger.LogWarning(
                        $"Method: {nameof(GetUserById)}" +
                        $"Message: 'User with the Id ${id} doesn't exist.'");
                    return NotFound();
                }
                _logger.LogInformation($"Method: {nameof(GetUserById)}" +
                                       $"Message: 'User with the Id ${id} returned'");
                return result;
            }
            catch (Exception)
            {
                _logger.LogError(
                     $"Method: {nameof(GetUserById)}" +
                     $"Message: 'Error retriving data from database.'");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving user data from the database");
            }
        }


        /* 
         <summary>
            POST: /User/ - Create a new user.
         </summary>
         <returns>Details of the newly created user</returns>
        */
        [HttpPost]
        public async Task<ActionResult<User>> CreateUser(User user)
        {
            try
            {
                // Check if the posted data is null and the user name is empty.
                if (user == null || user.Email == "")
                {
                    _logger.LogError($"Method: {nameof(CreateUser)}" +
                                      $"Message: 'Invalid request format.'");
                    return BadRequest();
                }

                // Check weather a user with the same name exists.
                var exists = await _userRepository.GetByEmail(user.Email);

                if (exists != null)
                {
                    _logger.LogError($"Method: {nameof(CreateUser)}" +
                                     $"Message: 'user with the email ${user.Email} already exist'");
                    return StatusCode(StatusCodes.Status409Conflict, "user already exists");
                }

                user.Id = Guid.NewGuid();
                var created = await _userRepository.Add(user);

                _logger.LogInformation($"Method: {nameof(CreateUser)}" +
                                       $"Message: 'A new user with the email ${user.Email} created'");

                return CreatedAtAction(nameof(CreateUser), new { id = created.Id }, created);
            }
            catch (Exception)
            {
                _logger.LogError($"Method: {nameof(CreateUser)}" +
                    $"Message: 'Error creating User in the database'");

                return StatusCode(StatusCodes.Status500InternalServerError, "Error creating User in the database");
            }
        }

        /* 
           <summary>
              DELETE: /user/ - Delete the user by name.
           </summary>
           <returns>An details of the deleted user</returns>
        */
        [HttpDelete("{email}")]
        public async Task<ActionResult<User>> DeleteUser(string email)
        {
            try
            {
                // check if the user exists.
                var user = await _userRepository.GetByEmail(email);

                if (user == null)
                {
                    _logger.LogError(
                            $"Method: {nameof(DeleteUser)}" +
                            $"Message: 'user with the email ${email} doesn't exist'");
                    return NotFound();
                }

                _logger.LogInformation($"Method: {nameof(DeleteUser)}" +
                       $"Message: 'user with the Id ${user.Id} deleted'");

                // return the deleted user data.
                return await _userRepository.DeleteByEmail(email);
            }
            catch (Exception)
            {
                _logger.LogError($"Method: {nameof(DeleteUser)}" +
                                 $"Message: 'Error deleting user from the database'");

                return StatusCode(StatusCodes.Status500InternalServerError, "Error deleting user from the database");
            }
        }


        /* 
           <summary>
              PUT: /user/ - Update a existing user.
           </summary>
           <returns>An details of the updated user</returns>
        */
        [HttpPut]
        public async Task<ActionResult<User>> UpdateUser(User user)
        {
            try
            {
                var exists = await _userRepository.GetById(user.Id);
                // check if the user exist.
                if (exists == null)
                {
                    _logger.LogError(
                        $"Method: {nameof(UpdateUser)}" +
                        $"Message: 'Project with the Id ${user.Id} doesn't exist'");
                    return NotFound();
                }
                _logger.LogInformation($"Method: {nameof(UpdateUser)}" +
                                       $"Message: 'user with the Id ${user.Id} is updated'");

                // return the updated user data
                return await _userRepository.Update(user);
            }
            catch (Exception)
            {
                _logger.LogError($"Method: {nameof(UpdateUser)}" +
                 $"Message: 'Error updating user data in the database'");

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error updating user data in the database");
            }
        }


    }
}
