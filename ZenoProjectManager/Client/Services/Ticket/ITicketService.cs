using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using ZenoProjectManager.Shared.Entities;

namespace ZenoProjectManager.Client. Services
{
    public interface ITicketService
    {
        Task<IEnumerable<Ticket>> GetTickets(string projectId);
        Task<Ticket> GetTicketById(Guid id);
        Task<Ticket> CreateTicket(Ticket ticket);
        Task<Ticket> UpdateTicket(Ticket ticket);
        Task<Ticket> UpdateTicketStatus(Ticket ticket);
        Task<Ticket> DeleteTicket(Guid id);
    }
}
