using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenoProjectManager.Server.Model;
using ZenoProjectManager.Shared.Entities;


namespace ZenoTicketManager.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketController : ControllerBase
    {
        private readonly ILogger<TicketController> _logger;
        private readonly ITicketRepository _ticketRepository;

        public TicketController(ILogger<TicketController> logger,
             ITicketRepository ticketRepository)
        {
            _logger = logger;
            _ticketRepository = ticketRepository;
        }

        /* 
         <summary>
             GET: /ticket - For returning a list of tickets in a project.
         </summary>
         <returns>An list of tickets</returns>
        */
        [HttpGet]
        public async Task<IActionResult> GetTickets([FromQuery] Guid projectId)
        {
            _logger.LogInformation(
                $"Method: {nameof(GetTickets)}" +
                $"Message: 'return list of tickets'");

            return Ok(await _ticketRepository.GetTickets(projectId));
        }

        /* 
          <summary>
              GET: /ticket/{id} - return details of the ticket. 
          </summary>
          <returns> Details of the retrived ticket</returns>
        */
        [HttpGet("{id:Guid}")]
        public async Task<ActionResult<Ticket>> GetTicketById(Guid id)
        {
            try
            {
                var result = await _ticketRepository.GetById(id);

                // check whether the ticket exists.
                if (result == null)
                {
                    _logger.LogWarning(
                        $"Method: {nameof(GetTicketById)}" +
                        $"Message: 'Ticket with the Id ${id} doesn't exist.'");
                    return NotFound();
                }
                _logger.LogInformation($"Method: {nameof(GetTicketById)}" +
                                       $"Message: 'Ticket with the Id ${id} returned'");
                return result;
            }
            catch (Exception)
            {
                _logger.LogError(
                     $"Method: {nameof(GetTicketById)}" +
                     $"Message: 'Error retriving data from database.'");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving ticket data from the database");
            }
        }

        /* 
         <summary>
            POST: /ticket/ - Create a new ticket.
         </summary>
         <returns>Details of the newly created ticket</returns>
        */
        [HttpPost]
        public async Task<ActionResult<Ticket>> CreateTicket(Ticket ticket)
        {
            try
            {
                // Check if the posted data is null and the ticket name is empty.
                if (ticket == null || ticket.TicketName == "" || ticket.Status == null)
                {
                    _logger.LogError($"Method: {nameof(CreateTicket)}" +
                                      $"Message: 'Invalid request format.'");
                    return BadRequest();
                }

                // Check weather a ticket with the same name exists.
                var exists = await _ticketRepository.GetById(ticket.Id);

                if (exists != null)
                {
                    _logger.LogError($"Method: {nameof(CreateTicket)}" +
                                     $"Message: 'ticket with the Id ${ticket.Id} already exist'");
                    return StatusCode(StatusCodes.Status409Conflict, "ticket already exists");
                }

                ticket.Id = Guid.NewGuid();
                ticket.CreatedDate = DateTime.Now;

                var created = await _ticketRepository.Add(ticket);

                _logger.LogInformation($"Method: {nameof(CreateTicket)}" +
                                       $"Message: 'A new ticket with the Id ${ticket.Id} created'");

                return CreatedAtAction(nameof(CreateTicket), new { id = created.Id }, created);
            }
            catch (Exception)
            {
                _logger.LogError($"Method: {nameof(CreateTicket)}" +
                    $"Message: 'Error creating Ticket in the database'");

                return StatusCode(StatusCodes.Status500InternalServerError, "Error creating Ticket in the database");
            }
        }

        /* 
           <summary>
              DELETE: /ticket/{id} - Delete the ticket by Id.
           </summary>
           <returns>An details of the deleted ticket</returns>
        */
        [HttpDelete("{id:Guid}")]
        public async Task<ActionResult<Ticket>> DeleteTicket(Guid id)
        {
            try
            {
                // check if the ticket exists.
                var ticket = await _ticketRepository.GetById(id);

                if (ticket == null)
                {
                    _logger.LogError(
                            $"Method: {nameof(DeleteTicket)}" +
                            $"Message: 'ticket with the id ${id} doesn't exist'");
                    return NotFound();
                }

                _logger.LogInformation($"Method: {nameof(DeleteTicket)}" +
                       $"Message: 'ticket with the Id ${ticket.Id} deleted'");

                // return the deleted ticket data.
                return await _ticketRepository.DeleteByID(id);
            }
            catch (Exception)
            {
                _logger.LogError($"Method: {nameof(DeleteTicket)}" +
                                 $"Message: 'Error deleting ticket from the database'");

                return StatusCode(StatusCodes.Status500InternalServerError, "Error deleting ticket from the database");
            }
        }

        /* 
           <summary>
              PUT: /ticket- Update a existing ticket.
           </summary>
           <returns>An details of the updated ticket</returns>
        */
        [HttpPut]
        public async Task<ActionResult<Ticket>> UpdateTicket(Ticket ticket)
        {
            try
            {
                var exists = await _ticketRepository.GetById(ticket.Id);
                // check if the ticket exist.
                if (exists == null)
                {
                    _logger.LogError(
                        $"Method: {nameof(UpdateTicket)}" +
                        $"Message: 'Ticket with the Id ${ticket.Id} doesn't exist'");
                    return NotFound();
                }

                _logger.LogInformation($"Method: {nameof(UpdateTicket)}" +
                                       $"Message: 'ticket with the Id ${ticket.Id} is updated'");

                // return the updated ticket data
                return await _ticketRepository.Update(ticket);
            }
            catch (Exception)
            {
                _logger.LogError($"Method: {nameof(UpdateTicket)}" +
                 $"Message: 'Error updating ticket data in the database'");

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error updating ticket data in the database");
            }
        }

        /* 
           <summary>
              PUT: /ticket/status/{id} - Change the status of a ticket.
           </summary>
           <returns>An details of the updated ticket</returns>
        */
        [HttpPut("status")]
        public async Task<ActionResult<Ticket>> UpdateTicketStatus(Ticket ticket)
        {
            _logger.LogInformation($"{ticket.Status} {ticket.Id}");
            try
            {
                var exists = await _ticketRepository.GetById(ticket.Id);
                // check if the ticket exist.
                if (exists == null)
                {
                    _logger.LogError(
                        $"Method: {nameof(UpdateTicketStatus)}" +
                        $"Message: 'Ticket with the Id ${ticket.Id} doesn't exist'");
                    return NotFound();
                }

                ticket.CompletedDate = DateTime.Now;
                _logger.LogInformation($"Method: {nameof(UpdateTicketStatus)}" +
                                       $"Message: 'ticket with the Id ${ticket.Id} is updated'");

                // return the updated ticket data
                return await _ticketRepository.UpdateStatus(ticket);
            }
            catch (Exception)
            {
                _logger.LogError($"Method: {nameof(UpdateTicketStatus)}" +
                 $"Message: 'Error updating ticket data int the database'");

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error updating ticket data int the database");
            }
        }
    }
}