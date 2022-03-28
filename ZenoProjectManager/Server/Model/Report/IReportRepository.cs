using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using ZenoProjectManager.Shared.Entities;

namespace ZenoProjectManager.Server.Model
{
    public interface IReportRepository
    {
        Task<IEnumerable<Project>> GetCompletedProjects(Guid companyId, DateTime startDate, DateTime endDate);
        Task<IEnumerable<Project>> GetInProgressProjects(Guid companyId, DateTime startDate, DateTime endDate);
        Task<IEnumerable<Ticket>> GetCompletedTicketsInProject(Guid projectId, DateTime startDate, DateTime endDate);
        Task<IEnumerable<Ticket>> GetTicketsByStatusInProject(Guid projectId, string status, DateTime startDate, DateTime endDate);
        Task<IEnumerable<Ticket>> GetCompletedTicketsInCompany(Guid companyId, DateTime startDate, DateTime endDate);
        Task<IEnumerable<Ticket>> GetTicketsByStatusInCompany(Guid companyId, string status, DateTime startDate, DateTime endDate);
    }
}
