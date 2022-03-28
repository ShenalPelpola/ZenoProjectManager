using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenoProjectManager.Shared.Entities;
using ZenoProjectManager.Shared.Entities.RequestFormats;

namespace ZenoProjectManager.Client.Services
{
    public interface IReportService
    {
        Task<IEnumerable<Ticket>> GetCompletedTicketsInCompany(ReportRequest reportRequest);
        Task<IEnumerable<Ticket>> GetTicketsByStatusInCompany(ReportRequest reportRequest);
        Task<IEnumerable<Ticket>> GetCompletedTicketsInProject(ReportRequest reportReqest);
        Task<IEnumerable<Ticket>> GetTicketsByStatusInProject(ReportRequest reportReqest);
        Task<IEnumerable<Project>> GetCompletedProjects(ReportRequest reportReqest);
        Task<IEnumerable<Project>> GetInProgressProjects(ReportRequest reportReqest);
    }
}
