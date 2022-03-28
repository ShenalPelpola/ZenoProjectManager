using Microsoft.EntityFrameworkCore;
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
    public class TicketRepository : ITicketRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public TicketRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<IEnumerable<Ticket>> GetTickets(Guid projectId)
        {
            return await _applicationDbContext.Tickets
                .Where(ticket => ticket.ProjectId == projectId)
                .ToListAsync();
        }

        public async Task<Ticket> GetById(Guid id)
        {
            return await _applicationDbContext.Tickets
                    .FirstOrDefaultAsync(ticket => ticket.Id == id);
        }

        public async Task<Ticket> Add(Ticket ticket)
        {
            var result = await _applicationDbContext.Tickets.AddAsync(ticket);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Ticket> DeleteByID(Guid id)
        {
            var result = await GetById(id);

            if (result != null)
            {
                _applicationDbContext.Tickets.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<Ticket> Update(Ticket ticket)
        {
            var ticketToUpdate = await GetById(ticket.Id);
            if (ticketToUpdate != null)
            {
                ticketToUpdate.TicketName = ticket.TicketName;
                ticketToUpdate.Description = ticket.Description;
                ticketToUpdate.StoryPoints = ticket.StoryPoints;
                ticketToUpdate.Type = ticket.Type;
                ticketToUpdate.UserId = ticket.UserId;

                await _applicationDbContext.SaveChangesAsync();
                return ticketToUpdate;
            }
            return null;
        }

        public async Task<Ticket> UpdateStatus(Ticket ticket)
        {
            var ticketToUpdate = await GetById(ticket.Id);
            if (ticketToUpdate != null)
            {
                // setup the completion date based on ticket status.

                if(ticket.Status == "DONE")
                {
                    ticketToUpdate.CompletedDate = ticket.CompletedDate;
                }
                else if(ticket.Status == "TODO" || ticket.Status == "IN-PROGRESS")
                {
                    ticketToUpdate.CompletedDate = null;
                }

                ticketToUpdate.Status = ticket.Status;
                await _applicationDbContext.SaveChangesAsync();
                return ticketToUpdate;
            }
            return null;
        }
    }
}



