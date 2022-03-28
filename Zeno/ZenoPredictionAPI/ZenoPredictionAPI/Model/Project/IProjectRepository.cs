using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using ZenoPredictionAPI.Entities;

namespace ZenoPredictionAPI.Model
{
    public interface IProjectRepository
    {
        Task<IEnumerable<Project>> GetProjects(Guid companyId);
        Task<IEnumerable<Project>> GetTotalProjectsByDate(Guid companyId, DateTime date);
    }
}


