using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using ZenoProjectManager.Shared.Entities;

namespace ZenoProjectManager.Server.Model
{
    public interface ITicketRepository
    {
        Task<IEnumerable<Ticket>> GetTickets(Guid projectId);
        Task<Ticket> GetById(Guid id);
        Task<Ticket> Add(Ticket ticket);
        Task<Ticket> UpdateStatus(Ticket ticket);
        Task<Ticket> Update(Ticket Ticket);
        Task<Ticket> DeleteByID(Guid id);
    }
}