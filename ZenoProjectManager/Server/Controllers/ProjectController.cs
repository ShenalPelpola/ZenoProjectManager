using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
    public class ProjectController : ControllerBase
    {
        private readonly ILogger<ProjectController> _logger;
        private readonly IProjectRepository _projectRepository;

        public ProjectController(ILogger<ProjectController> logger,
            IProjectRepository projectRepository)
        {
            _logger = logger;
            _projectRepository = projectRepository;
        }

        /// <summary>
        ///  GET: /project - For returning a list of projects in a company.
        ///  </summary>
        /// <returns>A list of projects in a company</returns>
        [Authorize(Roles = "admin, user")]
        [HttpGet]
        public async Task<IActionResult> GetProject([FromQuery] Guid companyId)
        {
            _logger.LogInformation(
                $"Method: {nameof(GetProject)}" +
                $"Message: 'return list of projects'");

            return Ok(await _projectRepository.GetProjects(companyId));
        }

        
        ///  <summary>
        ///  GET: /project/{id} - return details of the project. 
        ///  </summary>
        ///  <returns>An details of the retrived project</returns>
        [Authorize(Roles = "admin, user")]
        [HttpGet("{id:Guid}")]
        public async Task<ActionResult<Project>> GetProjectById(Guid id)
        {
            try
            {
                var result = await _projectRepository.GetById(id);

                // check whether the project exists.
                if (result == null)
                {
                    _logger.LogWarning(
                        $"Method: {nameof(GetProjectById)}" +
                        $"Message: 'Project with the Id ${id} doesn't exist.'");
                    return NotFound();
                }
                _logger.LogInformation($"Method: {nameof(GetProjectById)}" +
                                       $"Message: 'Project with the Id ${id} returned'");
                return result;
            }
            catch (Exception)
            {
                _logger.LogError(
                     $"Method: {nameof(GetProjectById)}" +
                     $"Message: 'Error retriving data from database.'");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving project data from the database");
            }
        }
       
         /// <summary>
         /// POST: /Project/ - Create a new project.
         /// </summary>
         /// <returns>An details of the newly created project</returns>
        [Authorize(Roles = "admin")]
        [HttpPost]
        public async Task<ActionResult<Project>> CreateProject(Project project)
        {
            try
            {
                // Check if the posted data is null and the project name is empty.
                if (project == null || project.ProjectName == "" || project.CreatedDate == DateTime.MinValue)
                {
                    _logger.LogError($"Method: {nameof(CreateProject)}" +
                                      $"Message: 'Invalid request format.'");
                    return BadRequest();
                }

                // Check weather a project with the same name exists.
                var exists = await _projectRepository.IsProjectExists(project.ProjectName, project.CompanyId);

                if (exists != null)
                {
                    _logger.LogError($"Method: {nameof(CreateProject)}" +
                                     $"Message: 'project with the Id ${project.Id} already exist'");
                    return StatusCode(StatusCodes.Status409Conflict, "project already exists");
                }

                project.Id = Guid.NewGuid();
                var created = await _projectRepository.Add(project);

                _logger.LogInformation($"Method: {nameof(CreateProject)}" +
                                       $"Message: 'A new project with the Id ${project.Id} created'");

                return CreatedAtAction(nameof(CreateProject), new { id = created.Id }, created);
            }
            catch (Exception)
            {
                _logger.LogError($"Method: {nameof(CreateProject)}" +
                    $"Message: 'Error creating Project in the database'");

                return StatusCode(StatusCodes.Status500InternalServerError, "Error creating Project in the database");
            }
        }

       
         /// <summary>
         /// DELETE: /project/ - Delete the project by name.
         /// </summary>
         /// <returns>An details of the deleted project</returns>
        [Authorize(Roles = "admin")]
        [HttpDelete]
        public async Task<ActionResult<Project>> DeleteProject([FromQuery] string name, [FromQuery] Guid companyId)
        {
            try
            {
                // check if the project exists.
                var project = await _projectRepository.IsProjectExists(name, companyId);

                if (project == null)
                {
                    _logger.LogError(
                            $"Method: {nameof(DeleteProject)}" +
                            $"Message: 'project with the name ${name} doesn't exist'");
                    return NotFound();
                }

                _logger.LogInformation($"Method: {nameof(DeleteProject)}" +
                       $"Message: 'project with the Id ${project.Id} deleted'");

                // return the deleted project data.
                return await _projectRepository.DeleteByName(name, companyId);
            }
            catch (Exception)
            {
                _logger.LogError($"Method: {nameof(DeleteProject)}" +
                                 $"Message: 'Error deleting project from the database'");

                return StatusCode(StatusCodes.Status500InternalServerError, "Error deleting project from the database");
            }
        }

 
        /// <summary>
        /// PUT: /project/ - Update a existing project.
        /// </summary>
        /// <returns>An details of the updated project</returns>
        [Authorize(Roles = "admin")]
        [HttpPut]
        public async Task<ActionResult<Project>> UpdateProject(Project project)
        {
            try
            {
                var exists = await _projectRepository.GetById(project.Id);
                // check if the project exist.
                if (exists == null)
                {
                    _logger.LogError(
                        $"Method: {nameof(UpdateProject)}" +
                        $"Message: 'Project with the Id ${project.Id} doesn't exist'");
                    return NotFound();
                }

                _logger.LogInformation($"Method: {nameof(UpdateProject)}" +
                                       $"Message: 'project with the Id ${project.Id} is updated'");

                // return the updated project data
                return await _projectRepository.Update(project);
            }
            catch (Exception)
            {
                _logger.LogError($"Method: {nameof(UpdateProject)}" +
                 $"Message: 'Error updating project data in the database'");

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error updating project data in the database");
            }
        }

    }
}