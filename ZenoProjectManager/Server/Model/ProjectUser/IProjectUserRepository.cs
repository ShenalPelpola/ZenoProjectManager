using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using ZenoProjectManager.Shared.Entities;

namespace ZenoProjectManager.Server.Model
{
    public interface IProjectUserRepository
    {
        Task<IEnumerable<User>> GetUsersInProject(Guid projectId);
        Task<IEnumerable<Project>> GetUserProjects(Guid userId);
        Task<bool> HasAssigned(Guid projectId, string email, Guid userId);
        Task<IEnumerable<User>> GetUsersInProjectByDate(Guid projectId, DateTime date);
        Task<bool> UserExists(Guid projectId, string email);
        Task<ProjectUser> Add(ProjectUser projectUser);
        Task<ProjectUser> Delete(Guid projectId, string email);
    }
}

