using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenoProjectManager.Server.Model;
using ZenoProjectManager.Shared;
using ZenoProjectManager.Shared.Entities.RequestFormats;

namespace ZenoProjectManager.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReportController : ControllerBase
    {
        private readonly ILogger<ReportController> _logger;
        private readonly IReportRepository _reportRepository;

        public ReportController(ILogger<ReportController> logger,
            IReportRepository reportRepository)
        {
            _logger = logger;
            _reportRepository = reportRepository;
        }

        /* 
         <summary>
             POST: /api/report/companyTickets/completed - For returning a list of completed tickets in a company at a given date range.
         </summary>
         <returns>A list of completed tickets in the company</returns>
        */

        [HttpPost("companyTickets/completed")]
        public async Task<IActionResult> GetCompletedTicketsInCompany(ReportRequest reportReqest)
        {
            _logger.LogInformation($"Method: {nameof(GetCompletedTicketsInCompany)}" +$"Message: 'created: ${reportReqest.StartDate} End: ${reportReqest.EndDate}.'");
            // check if the value are empty
            if (reportReqest.CompanyId == Guid.Empty ||
                reportReqest.StartDate == DateTime.MinValue ||
                reportReqest.EndDate == DateTime.MinValue)
            {
                _logger.LogError($"Method: {nameof(GetCompletedTicketsInCompany)}" +
                     $"Message: 'Invalid request format.'");
                return BadRequest();
            }
            _logger.LogInformation(
                    $"Method: {nameof(GetCompletedTicketsInCompany)}" +
                    $"Message: 'return list of completed tickets.'");
            return Ok(await _reportRepository.GetCompletedTicketsInCompany(
                reportReqest.CompanyId,
                reportReqest.StartDate,
                reportReqest.EndDate));
        }

        /* 
         <summary>
             POST: /api/companyTickets/status - For returning a list tickets by status in a company at a given date range.
         </summary>
         <returns>A list of tickets by status</returns>
        */
        [HttpPost("companyTickets/status")]
        public async Task<IActionResult> GetTicketsByStatusInCompany(ReportRequest reportReqest)
        {
            _logger.LogInformation($"Method: {nameof(GetCompletedTicketsInCompany)}" + $"Message: 'created: ${reportReqest.StartDate} End: ${reportReqest.EndDate}.'");
            if (reportReqest.CompanyId == Guid.Empty ||
                reportReqest.Status == null ||
                reportReqest.StartDate == DateTime.MinValue ||
                reportReqest.EndDate == DateTime.MinValue)
            {
                _logger.LogError($"Method: {nameof(GetTicketsByStatusInCompany)}" +
                     $"Message: 'Invalid request format.'");
                return BadRequest();
            }
            _logger.LogInformation(
                    $"Method: {nameof(GetTicketsByStatusInCompany)}" +
                    $"Message: 'return list of completed tickets.'");
            return Ok(await _reportRepository.GetTicketsByStatusInCompany(
                reportReqest.CompanyId,
                reportReqest.Status,
                reportReqest.StartDate,
                reportReqest.EndDate));
        }

        /* 
         <summary>
             POST: /api/report/projectTickets/completed- For returning a list of completed tickets in a project at a given date range.
         </summary>
         <returns>A list of completed tickets in a project</returns>
        */

        [HttpPost("projectTickets/completed")]
        public async Task<IActionResult> GetCompletedTicketsInProject(ReportRequest reportReqest)
        {
            if (reportReqest.ProjectId == Guid.Empty ||
                reportReqest.StartDate == DateTime.MinValue ||
                reportReqest.EndDate == DateTime.MinValue)
            {
                _logger.LogError($"Method: {nameof(GetCompletedTicketsInCompany)}" +
                     $"Message: 'Invalid request format.'");
                return BadRequest();
            }
            _logger.LogInformation(
                    $"Method: {nameof(GetCompletedTicketsInCompany)}" +
                    $"Message: 'return list of completed tickets.'");
            return Ok(await _reportRepository.GetCompletedTicketsInProject(
                reportReqest.ProjectId,
                reportReqest.StartDate,
                reportReqest.EndDate));
        }

        /* 
         <summary>
             POST: /api/report/projectTickets/completed- For returning a list tickets in a project by status in a company at a given date range.
         </summary>
         <returns>A list of completed tickets in a project</returns>
       */

        [HttpPost("projectTickets/status")]
        public async Task<IActionResult> GetTicketsByStatusInProject(ReportRequest reportReqest)
        {
            if (reportReqest.ProjectId == Guid.Empty ||
                reportReqest.StartDate == DateTime.MinValue ||
                reportReqest.Status == null ||
                reportReqest.EndDate == DateTime.MinValue)
            {
                _logger.LogError($"Method: {nameof(GetTicketsByStatusInProject)}" +
                     $"Message: 'Invalid request format.'");
                return BadRequest();
            }
            _logger.LogInformation(
                    $"Method: {nameof(GetTicketsByStatusInProject)}" +
                    $"Message: 'return list of completed tickets.'");
            return Ok(await _reportRepository.GetTicketsByStatusInProject(
                reportReqest.ProjectId,
                reportReqest.Status,
                reportReqest.StartDate,
                reportReqest.EndDate));
        }

        /* 
         <summary>
             POST: /api/report/projects/completed - For returning a list of completed projects at a given date range.
         </summary>
         <returns>A list of completed projects</returns>
        */
        [HttpPost("projects/completed")]
        public async Task<IActionResult> GetCompletedProjects(ReportRequest reportReqest)
        {
            if (reportReqest.CompanyId == Guid.Empty ||
                reportReqest.StartDate == DateTime.MinValue ||
                reportReqest.EndDate == DateTime.MinValue)
            {
                _logger.LogError($"Method: {nameof(GetCompletedProjects)}" +
                     $"Message: 'Invalid request format.'");
                return BadRequest();
            }
            _logger.LogInformation(
                    $"Method: {nameof(GetCompletedProjects)}" +
                    $"Message: 'return list of completed projects.'");
            return Ok(await _reportRepository.GetCompletedProjects(
                reportReqest.CompanyId,
                reportReqest.StartDate,
                reportReqest.EndDate));
        }

        /* 
         <summary>
             POST: /api/report/projects/inprogress - For returning a list of in-progress projects at a given date range.
         </summary>
         <returns>A list of completed projects</returns>
        */
        [HttpPost("projects/in-Progress")]
        public async Task<IActionResult> GetInProgressProjects(ReportRequest reportReqest)
        {
            if (reportReqest.CompanyId == Guid.Empty ||
                reportReqest.StartDate == DateTime.MinValue ||
                reportReqest.EndDate == DateTime.MinValue)
            {
                _logger.LogError($"Method: {nameof(GetInProgressProjects)}" +
                     $"Message: 'Invalid request format.'");
                return BadRequest();
            }
            _logger.LogInformation(
                    $"Method: {nameof(GetInProgressProjects)}" +
                    $"Message: 'return list of completed projects.'");
            return Ok(await _reportRepository.GetInProgressProjects(
                reportReqest.CompanyId,
                reportReqest.StartDate,
                reportReqest.EndDate));
        }
    }
}
