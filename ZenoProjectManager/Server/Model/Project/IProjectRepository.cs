using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using ZenoProjectManager.Shared.Entities;
using ZenoProjectManager.Shared.Entities.ResponseFormats;

namespace ZenoProjectManager.Server.Model
{
    public interface IProjectRepository
    {
        Task<IEnumerable<Project>> GetProjects(Guid companyId);
        Task<Project> GetById(Guid id);
        Task<Project> GetProjectByName(string name);
        Task<Project> IsProjectExists(string projectName, Guid companyId);
        Task<IEnumerable<Project>> GetTotalProjectsByDate(Guid companyId, DateTime date);
        Task<Project> Add(Project project);
        Task<Project> Update(Project project);
        Task<Project> DeleteByName(string name, Guid CompanyId);
    }
}


