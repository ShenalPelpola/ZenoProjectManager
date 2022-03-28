using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenoProjectManager.Server.Data;
using ZenoProjectManager.Shared.Entities;

namespace ZenoProjectManager.Server.Model
{
    public class ReportRepository : IReportRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly ILogger<ReportRepository> _logger;

        public ReportRepository(ILogger<ReportRepository> logger, ApplicationDbContext applicationDbContext)
        {
            _logger = logger;
            _applicationDbContext = applicationDbContext;
        }

        public async Task<IEnumerable<Project>> GetCompletedProjects(Guid companyId, DateTime startDate, DateTime endDate)
        {
            var projects = await _applicationDbContext.Projects.Where(project => project.CompanyId == companyId)
                                    .ToListAsync();

            List<Project> completedProjects = new List<Project>();

            foreach (Project project in projects)
            {
                var totalTickets = await GetAllTicketsInProject(project.Id, startDate, endDate);
                var completedTicket = await GetCompletedTicketsInProject(project.Id, startDate, endDate);

                if ((totalTickets.Count() == completedTicket.Count()) && totalTickets.Count() != 0)
                {
                    completedProjects.Add(project);
                }
            }
            return completedProjects;
        }

        public async Task<IEnumerable<Project>> GetInProgressProjects(Guid companyId, DateTime startDate, DateTime endDate)
        { 
            var projects = await _applicationDbContext.Projects.Where(project => project.CompanyId == companyId)
                        .ToListAsync();

            List<Project> InprogressProjects = new List<Project>();

            foreach (Project project in projects)
            {
                var totalTickets = await GetAllTicketsInProject(project.Id, startDate, endDate);
                var incompletedTicket = await GetIncompletedTicketsInProject(project.Id, startDate, endDate);

                if ((incompletedTicket.Count() > 0) && (totalTickets.Count() != 0))
                {
                    InprogressProjects.Add(project);
                }
            }
            return InprogressProjects;
        }

        public async Task<IEnumerable<Ticket>> GetCompletedTicketsInCompany(Guid companyId, DateTime startDate, DateTime endDate)
        {
            var tickets = await (from
                                 ticket in _applicationDbContext.Tickets
                                 join project in _applicationDbContext.Projects
                                 on ticket.ProjectId equals project.Id
                                 where
                                 (ticket.CompletedDate >= startDate && ticket.CompletedDate <= endDate)
                                 && ticket.Status == "DONE"
                                 && project.CompanyId == companyId
                                 select new Ticket
                                 {
                                     Id = ticket.Id,
                                     ProjectId = ticket.ProjectId,
                                     Status = ticket.Status,
                                     CreatedDate = ticket.CreatedDate,
                                     CompletedDate = ticket.CompletedDate
                                 }).ToListAsync();
            return tickets;
        }

        public async Task<IEnumerable<Ticket>> GetTicketsByStatusInCompany(Guid companyId,
            string status, DateTime startDate, DateTime endDate)
        {
            var tickets = await (from
                                 ticket in _applicationDbContext.Tickets
                                 join project in _applicationDbContext.Projects
                                 on ticket.ProjectId equals project.Id
                                 where
                                 (ticket.CreatedDate >= startDate && ticket.CreatedDate <= endDate)
                                 && ticket.Status == status
                                 && project.CompanyId == companyId
                                 select new Ticket
                                 {
                                     Id = ticket.Id,
                                     ProjectId = ticket.ProjectId,
                                     Status = ticket.Status,
                                     CreatedDate = ticket.CreatedDate,
                                     CompletedDate = ticket.CompletedDate
                                 }).ToListAsync();
            return tickets;
        }
        public async Task<IEnumerable<Ticket>> GetCompletedTicketsInProject(Guid projectId, DateTime startDate, DateTime endDate)
        {
            var tickets = await (from
                                 ticket in _applicationDbContext.Tickets
                                 join project in _applicationDbContext.Projects
                                 on ticket.ProjectId equals project.Id
                                 where
                                 (ticket.CompletedDate >= startDate && ticket.CompletedDate <= endDate)
                                 && ticket.Status == "DONE"
                                 && project.Id == projectId
                                 select new Ticket
                                 {
                                     Id = ticket.Id,
                                     ProjectId = ticket.ProjectId,
                                     Status = ticket.Status,
                                     CreatedDate = ticket.CreatedDate,
                                     CompletedDate = ticket.CompletedDate
                                 }).ToListAsync();
            return tickets;
        }
        public async Task<IEnumerable<Ticket>> GetTicketsByStatusInProject(Guid projectId, string status, DateTime startDate, DateTime endDate)
        {
            var tickets = await(from
                          ticket in _applicationDbContext.Tickets
                                join project in _applicationDbContext.Projects
                                on ticket.ProjectId equals project.Id
                                where
                                (ticket.CreatedDate >= startDate && ticket.CreatedDate <= endDate)
                                && ticket.Status == status
                                && project.Id == projectId
                                select new Ticket
                                {
                                    Id = ticket.Id,
                                    ProjectId = ticket.ProjectId,
                                    Status = ticket.Status,
                                    CreatedDate = ticket.CreatedDate,
                                    CompletedDate = ticket.CompletedDate
                                }).ToListAsync();
            return tickets;
        }

        private async Task<IEnumerable<Ticket>> GetIncompletedTicketsInProject(Guid projectId, DateTime startDate, DateTime endDate)
        {
            var tickets = await (from
                     ticket in _applicationDbContext.Tickets
                                 join project in _applicationDbContext.Projects
                                 on ticket.ProjectId equals project.Id
                                 where
                                 (ticket.CreatedDate >= startDate && ticket.CreatedDate <= endDate)
                                 && (ticket.Status == "TODO" || ticket.Status == "IN-PROGRESS")
                                && project.Id == projectId
                                select new Ticket
                                {
                                    Id = ticket.Id,
                                    Status = ticket.Status,
                                    CreatedDate = ticket.CreatedDate,
                                    CompletedDate = ticket.CompletedDate
                                }).ToListAsync();
            return tickets;
        }

        private async Task<IEnumerable<Ticket>> GetAllTicketsInProject(Guid projectId, DateTime startDate, DateTime endDate)
        {
            var tickets = await (from
                     ticket in _applicationDbContext.Tickets
                                 join project in _applicationDbContext.Projects
                                 on ticket.ProjectId equals project.Id
                                 where
                                 (ticket.CreatedDate >= startDate && ticket.CreatedDate <= endDate)
                                 && project.Id == projectId
                                 select new Ticket
                                 {
                                     Id = ticket.Id,
                                     Status = ticket.Status,
                                     CreatedDate = ticket.CreatedDate,
                                     CompletedDate = ticket.CompletedDate
                                 }).ToListAsync();
            return tickets;
        }
    }
}


