using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenoPredictionAPI.Data;
using ZenoPredictionAPI.Entities;
using ZenoPredictionAPI.Entities.ResponseFormats;
using ZenoPredictionAPI.Model;

namespace ZenoPredictionAPI.Model
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ProjectRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<IEnumerable<Project>> GetProjects(Guid companyId)
        {
            return await _applicationDbContext.Projects
                .Where(project => project.CompanyId == companyId)
                .ToListAsync();
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

    }
}



