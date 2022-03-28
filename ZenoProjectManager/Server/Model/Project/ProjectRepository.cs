using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenoProjectManager.Server.Data;
using ZenoProjectManager.Shared.Entities;
using ZenoProjectManager.Shared.Entities.ResponseFormats;

namespace ZenoProjectManager.Server.Model
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ProjectRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        /// <summary>
        /// Get detials of the project from the projects table.
        /// </summary>
        /// <returns>IEnumerable list of projects by the company id.</returns>
        public async Task<IEnumerable<Project>> GetProjects(Guid companyId)
        {
            return await _applicationDbContext.Projects
                .Where(project => project.CompanyId == companyId)
                .ToListAsync();
        }

        /// <summary>
        /// Gets detials of the project by id from the projects table.
        /// </summary>
        /// <returns>Details of the project selected by id.</returns>
        public async Task<Project> GetById(Guid id)
        {
            return await _applicationDbContext.Projects
                    .FirstOrDefaultAsync(project => project.Id == id);
        }

        /// <summary>
        /// Gets detials of the project by name from the projects table.
        /// </summary>
        /// <returns>Details of the project selected by name.</returns>
        public async Task<Project> GetProjectByName(string projectName)
        {
            return await _applicationDbContext.Projects
                .FirstOrDefaultAsync(project => project.ProjectName == projectName);
        }

        /// <summary>
        /// Check if the project already exist in the company
        /// </summary>
        /// <returns>Details of the selected projects.</returns>
        public async Task<Project> IsProjectExists(string projectName, Guid companyId)
        {
            return await _applicationDbContext.Projects
                .FirstOrDefaultAsync(project => project.ProjectName == projectName && project.CompanyId == companyId);
        }

        /// <summary>
        /// Get the total number of projects upto a certain date.
        /// </summary>
        /// <returns>IEnumerable list of selected projects.</returns>
        public async Task<IEnumerable<Project>> GetTotalProjectsByDate(Guid companyId, DateTime date)
        {
            var projects = await (from
                                 project in _applicationDbContext.Projects
                                  join company in _applicationDbContext.Companies
                                  on project.CompanyId equals company.Id
                                  where
                                  (project.CreatedDate >= date && project.CreatedDate <= DateTime.Now) && company.Id == companyId
                                  select new Project
                                  {
                                      Id = project.Id,
                                      ProjectName = project.ProjectName,
                                      CompanyId = project.CompanyId
                                  }).ToListAsync();
            return projects;
        }

        /// <summary>
        /// Create a new project in the project table.
        /// </summary>
        /// <returns>Details of the newly created project.</returns>
        public async Task<Project> Add(Project project)
        {
            var result = await _applicationDbContext.Projects.AddAsync(project);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        /// <summary>
        /// Deleted project from the projects table.
        /// </summary>
        /// <returns>Details of the deleted project.</returns>
        public async Task<Project> DeleteByName(string name, Guid CompanyId)
        {
            var result = await IsProjectExists(name, CompanyId);

            if (result != null)
            {
                _applicationDbContext.Projects.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
                return result;
            }
            return null;
        }

        /// <summary>
        /// update project from the projects table.
        /// </summary>
        /// <returns>Details of the updated project.</returns>
        public async Task<Project> Update(Project project)
        {
            var projectToUpdate = await GetById(project.Id);
            if (projectToUpdate != null)
            {
                projectToUpdate.ProjectName = project.ProjectName;
                projectToUpdate.Description = project.Description;
                projectToUpdate.Image = project.Image;

                await _applicationDbContext.SaveChangesAsync();
                return projectToUpdate;
            }
            return null;
        }

    }
}



