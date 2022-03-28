using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using ZenoProjectManager.Shared.Entities;

namespace ZenoProjectManager.Client.Services
{
    public interface IProjectService
    {
        Task<IEnumerable<Project>> GetProjects(string companyId);
        Task<Project> GetProjectById(Guid id);
        Task<Project> CreateProject(Project project);
        Task<Project> UpdateProject(Project project);
        Task<Project> DeleteProject(string name, Guid companyId);
    }
}
