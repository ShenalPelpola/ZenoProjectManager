using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ZenoPredictionAPI.Data;
using ZenoPredictionAPI.Entities;

namespace ZenoPredictionAPI.Model
{
    public class ProjectUserRepository : IProjectUserRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ProjectUserRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

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
    }
}



