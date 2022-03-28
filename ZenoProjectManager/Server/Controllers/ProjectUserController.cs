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
    public class ProjectUserController : ControllerBase
    {
        private readonly ILogger<ProjectUserController> _logger;
        private readonly IProjectUserRepository _projectUserRepository;
        private readonly IProjectRepository _projectRepository;
        private readonly IUserRepository _userRepository;

        public ProjectUserController(ILogger<ProjectUserController> logger,
            IProjectUserRepository projectUserRepository,
            IProjectRepository projectRepository,
            IUserRepository userRepository)
        {
            _projectUserRepository = projectUserRepository;
            _projectRepository = projectRepository;
            _userRepository = userRepository;
            _logger = logger;
        }

        /* 
         <summary>
             GET: /projectuser - For returning a list of users in a project.
         </summary>
         <returns>A list of users in a project</returns>
        */
        [HttpGet("{projectId:Guid}")]
        public async Task<IActionResult> GetUsersInProject(Guid projectId)
        {
            _logger.LogInformation(

                $"Method: {nameof(GetUsersInProject)}" +
                $"Message: 'return list of users in a project'");

            return Ok(await _projectUserRepository.GetUsersInProject(projectId));
        }

        /* 
         <summary>
             GET: /projectuser - For returning a list of users in a project.
         </summary>
         <returns>A list of users in a project</returns>
        */
        [HttpGet]
        public async Task<IActionResult> GetUserProjects([FromQuery] Guid userId)
        {
            _logger.LogInformation(

                $"Method: {nameof(GetUsersInProject)}" +
                $"Message: 'return list of users in a project'");

            return Ok(await _projectUserRepository.GetUserProjects(userId));
        }

        /* 
        <summary>
            POST: /projectuser/ - Add a user to a project.
            </summary>
            <returns>An details of the newly added record</returns>
        */
        [HttpPost]

        public async Task<ActionResult<ProjectUser>> AddUserToProject(ProjectUser projectUser)
        {
            try
            {
                // check if the project exist in the system
                var projectExists = await _projectRepository.GetById(projectUser.ProjectId);
                var userExists = await _userRepository.GetByEmail(projectUser.Email);

                if (projectExists == null || userExists == null)
                {
                    _logger.LogError(
                        $"Method: {nameof(AddUserToProject)}" +
                        $"Message: 'User with the Id ${projectUser.UserId} Project with the Id ${projectUser.ProjectId} doesn't exist'");
                    return NotFound();
                }

                if(userExists.Role == "admin")
                {
                    _logger.LogError($"Method: {nameof(AddUserToProject)}" +
                                $"Message: 'Admins aren't assigned to projects.'");
                    return StatusCode(StatusCodes.Status409Conflict, "Admin's aren't allowed in projects.");
                }

                // check if the user exits in the project
                var exists = await _projectUserRepository.HasAssigned(projectUser.ProjectId, userExists.Email, userExists.Id);

                if (exists)
                {
                    _logger.LogError($"Method: {nameof(AddUserToProject)}" +
                                     $"Message: 'User with the Email ${projectUser.Email} already exist in the project ${projectUser.ProjectId}'");
                    return StatusCode(StatusCodes.Status409Conflict, "User already exists in the project.");
                }

                projectUser.Id = Guid.NewGuid();
                projectUser.UserId = userExists.Id;
                await _projectUserRepository.Add(projectUser);

                _logger.LogInformation($"Method: {nameof(AddUserToProject)}" +
                                       $"Message: 'User with the Id ${projectUser.Id} has been added to project ${projectUser.Id}'");

                return Ok();
            }
            catch (Exception)
            {
                _logger.LogError($"Method: {nameof(AddUserToProject)}" +
                    $"Message: 'Error assigning user to project in the database'");

                return StatusCode(StatusCodes.Status500InternalServerError, "Error assigning user to project in the database");
            }
        }


        /* 
           <summary>
              DELETE: /ticket/{id} - Delete the project user by Id.
           </summary>
           <returns>Details of the deleted project user.</returns>
        */
        [HttpDelete]
        public async Task<ActionResult<ProjectUser>> DeleteUserFromProject([FromQuery] Guid projectId, [FromQuery] string email)
        {
            try
            {
                // check if the project exist in the system
                var recordExists = await _projectUserRepository.UserExists(projectId, email);

                if (!recordExists)
                {
                    _logger.LogError(
                        $"Method: {nameof(AddUserToProject)}" +
                        $"Message: 'User with the email ${email} Project with the Id ${projectId} doesn't exist'");
                    return NotFound();
                }

                _logger.LogInformation($"Method: {nameof(DeleteUserFromProject)}" +
                       $"Message: 'project user with the email ${email} deleted'");

                // return the deleted project user data.
                return await _projectUserRepository.Delete(projectId, email);
            }
            catch (Exception)
            {
                _logger.LogError($"Method: {nameof(DeleteUserFromProject)}" +
                                 $"Message: 'Error deleting project user from the database'");

                return StatusCode(StatusCodes.Status500InternalServerError, "Error deleting project user from the database");
            }
        }
    }
}