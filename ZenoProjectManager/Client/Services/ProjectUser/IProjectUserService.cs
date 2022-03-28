using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using ZenoProjectManager.Shared.Entities;

namespace ZenoProjectManager.Client.Services
{
    public interface IProjectUserService
    {
        Task<IEnumerable<User>> GetUsersInProject(Guid projectId);
        Task<IEnumerable<Project>> GetUserProjects(Guid userId);
        Task<bool> AddUserToProject(ProjectUser projectUser);
        Task<ProjectUser> DeleteUserFromProject(Guid projectId, string email);
    }
}
