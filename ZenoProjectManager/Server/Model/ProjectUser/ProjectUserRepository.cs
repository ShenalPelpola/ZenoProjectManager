using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ZenoProjectManager.Server.Data;
using ZenoProjectManager.Shared.Entities;

namespace ZenoProjectManager.Server.Model
{
    public class ProjectUserRepository : IProjectUserRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ProjectUserRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        ///<summary>
        /// Returns all the users that is part of a projects.
        ///</summary>
        /// <returns>List of users in a project selected by project id</returns>
        public async Task<IEnumerable<User>> GetUsersInProject(Guid projectId)
        {
            var users = await (from user in _applicationDbContext.Users
                          join projectuser in _applicationDbContext.ProjectUser
                          on user.Id equals projectuser.UserId
                          where projectuser.ProjectId == projectId
                          select new User
                          {
                              Id = user.Id,
                              FirstName = user.FirstName,
                              LastName = user.LastName,
                              Role = user.Role,
                              Department = user.Department,
                              Position = user.Position,
                              Email = user.Email,
                              Avatar = user.Avatar,
                          }).ToListAsync();

            return users;
        }

        public async Task<IEnumerable<User>> GetUsersInProjectByDate(Guid projectId, DateTime date)
        {
            var users = await (from user in _applicationDbContext.Users
                               join projectuser in _applicationDbContext.ProjectUser
                               on user.Id equals projectuser.UserId
                               where (projectuser.AssignedDate >= date && projectuser.AssignedDate <= DateTime.Now)
                               && projectuser.ProjectId == projectId
                               select new User
                               {
                                   Id = user.Id,
                                   FirstName = user.FirstName,
                                   LastName = user.LastName,
                                   Role = user.Role,
                                   Department = user.Department,
                                   Position = user.Position,
                                   Email = user.Email,
                                   Avatar = user.Avatar,
                               }).ToListAsync();

            return users;
        }

        ///<summary>
        /// Returns all the project that the user is a part of.
        ///</summary>
        /// <returns>List of projects.</returns>
        public async Task<IEnumerable<Project>> GetUserProjects(Guid userId)
        {
            var projects = await (from project in _applicationDbContext.Projects
                               join projectuser in _applicationDbContext.ProjectUser
                               on project.Id equals projectuser.ProjectId
                               where projectuser.UserId == userId
                               select new Project
                               {
                                   Id = project.Id,
                                   ProjectName = project.ProjectName,
                                   Description = project.Description,
                                   Image = project.Image
                               }).ToListAsync();

            return projects;
        }

        ///<summary>
        /// Check if the user is assigned to a project.
        ///</summary>
        /// <returns>A boolean value based on the user's assignment to a project.</returns>
        public async Task<bool> HasAssigned(Guid projectId, string email, Guid userId)
        {
            var result = await _applicationDbContext.ProjectUser
                    .FirstOrDefaultAsync(pu => pu.Email == email && pu.ProjectId == projectId && pu.UserId == userId);

            if(result != null)
            {
                return true;
            }
            return false;
        }

        ///<summary>
        /// Check if the user exists int a project.
        ///</summary>
        /// <returns>A boolean value based on the user's existence in a project.</returns>
        public async Task<bool> UserExists(Guid projectId, string email)
        {
            var result = await _applicationDbContext.ProjectUser
                    .FirstOrDefaultAsync(pu => pu.Email == email && pu.ProjectId == projectId);

            if (result != null)
            {
                return true;
            }
            return false;
        }

        ///<summary>
        /// Assign a new User to the project.
        ///</summary>
        /// <returns>Details of the created record.</returns>
        public async Task<ProjectUser> Add(ProjectUser projectUser)
        {
            var result = await _applicationDbContext.ProjectUser.AddAsync(projectUser);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        ///<summary>
        /// Delete a user from the project.
        ///</summary>
        /// <returns>Details of the deleted record.</returns>
        public async Task<ProjectUser> Delete(Guid projectId, string email)
        {
            
           var result = await _applicationDbContext.ProjectUser
                    .FirstOrDefaultAsync(pu => pu.Email == email && pu.ProjectId == projectId);

           if (result != null)
            {
                _applicationDbContext.ProjectUser.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
                 return result;
             }
           return null;      
        }
    }
}



