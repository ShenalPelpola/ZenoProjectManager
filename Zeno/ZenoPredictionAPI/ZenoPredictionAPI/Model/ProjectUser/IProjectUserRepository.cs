using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using ZenoPredictionAPI.Entities;

namespace ZenoPredictionAPI.Model
{
    public interface IProjectUserRepository
    {
        Task<IEnumerable<User>> GetUsersInProject(Guid projectId);
        Task<IEnumerable<User>> GetUsersInProjectByDate(Guid projectId, DateTime date);
    }
}

