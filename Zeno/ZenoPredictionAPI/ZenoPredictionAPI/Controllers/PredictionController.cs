using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenoPredictionAPI.Data;
using ZenoPredictionAPI.Entities;
using ZenoPredictionAPI.Entities.RequestFormats;
using ZenoPredictionAPI.Entities.ResponseFormats;
using ZenoPredictionAPI.Model;
using ZenoProjectManager.Shared.Entities.ResponseFormats;

namespace ZenoPredictionAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class PredictionController : Controller
    {
        private readonly ILogger<PredictionController> _logger;
        private readonly IProjectRepository _projectRepository;
        private readonly IProjectUserRepository _projectUserRepository;

        public PredictionController(ILogger<PredictionController> logger,
                IProjectRepository projectRepository,
                IProjectUserRepository projectUserRepository)
        {
            _logger = logger;
            _projectRepository = projectRepository;
            _projectUserRepository = projectUserRepository;
        }

        [Authorize(Roles = "admin")]
        [HttpPost("projects")]
        public async Task<ActionResult<PredictionResponse>> GetProjectsPrediction(PredictionRequest predictionRequest)
        {
            if (predictionRequest.CompanyId == Guid.Empty ||
                predictionRequest.PredictionDate == DateTime.MinValue ||
                predictionRequest.CompanyCreatedDate == DateTime.MinValue)
            {
                _logger.LogError($"Method: {nameof(GetProjectsPrediction)}" +
                  $"Message: 'Invalid request format.'");
                return BadRequest();
            }

            DateTime currentDate = DateTime.Now;
            DateTime createdDate = predictionRequest.CompanyCreatedDate;
            int projects = 0;
            int monthlyAvg = 0;

            if (predictionRequest.PredictionDate.Month <= currentDate.Month || currentDate <= createdDate)
            {
                return await Task.FromResult(new PredictionResponse()
                {
                    PredictionDate = DateTime.MinValue,
                    Current = 0,
                    MonthlyAvg = 0,
                    Prediction = 0,
                });
            }

            int diff = ((currentDate.Year - createdDate.Year) * 12) + currentDate.Month - createdDate.Month;
            if (diff <= 0)
            {
                return await Task.FromResult(new PredictionResponse()
                {
                    PredictionDate = DateTime.MinValue,
                    Current = 0,
                    MonthlyAvg = 0,
                    Prediction = 0,
                });
            }

            if (diff >= 6)
            {
                DateTime lastMonth = currentDate.AddMonths(-6);
                projects = (await _projectRepository.GetTotalProjectsByDate(predictionRequest.CompanyId, lastMonth)).Count();
                monthlyAvg = projects / 6;
            }
            else
            {
                projects = (await _projectRepository.GetProjects(predictionRequest.CompanyId)).Count();
                monthlyAvg = projects / diff;
            }
            var prediction = monthlyAvg * (((predictionRequest.PredictionDate.Year - currentDate.Year) * 12) + predictionRequest.PredictionDate.Month - currentDate.Month);

            return await Task.FromResult(new PredictionResponse()
            {
                PredictionDate = predictionRequest.PredictionDate,
                Current = projects,
                MonthlyAvg = monthlyAvg,
                Prediction = prediction + projects,
            });
        }

        [Authorize(Roles = "admin")]
        [HttpPost("users")]
        public async Task<ActionResult<List<PredictionResponse>>> GetUserPrediction(PredictionRequest predictionRequest)
        {
            if (predictionRequest.CompanyId == Guid.Empty ||
                predictionRequest.PredictionDate == DateTime.MinValue ||
                predictionRequest.CompanyCreatedDate == DateTime.MinValue)
            {
                _logger.LogError($"Method: {nameof(GetUserPrediction)}" +
                  $"Message: 'Invalid request format.'");
                return BadRequest();
            }

            DateTime currentDate = DateTime.Now;
            DateTime createdDate = predictionRequest.CompanyCreatedDate;
            int monthlyAvg = 0;
            IEnumerable<Project> projects = new List<Project>();
            List<UserPredictionResponse> res = new List<UserPredictionResponse>();

            if (predictionRequest.PredictionDate.Month <= currentDate.Month || currentDate <= createdDate)
            {
                return Ok(res);
            }

            int diff = ((currentDate.Year - createdDate.Year) * 12) + currentDate.Month - createdDate.Month;
            if (diff <= 0)
            {
                return Ok(res);
            }

            if (diff >= 6)
            {
                DateTime lastMonth = currentDate.AddMonths(-6);
                projects = await _projectRepository.GetTotalProjectsByDate(predictionRequest.CompanyId, lastMonth);
                foreach (Project project in projects)
                {
                    var users = (await _projectUserRepository.GetUsersInProjectByDate(project.Id, lastMonth)).Count();
                    monthlyAvg = users / 6;
                    var prediction = monthlyAvg * (((predictionRequest.PredictionDate.Year - currentDate.Year) * 12) + predictionRequest.PredictionDate.Month - currentDate.Month);
                    res.Add(new UserPredictionResponse()
                    {
                        ProjectId = project.Id,
                        ProjectName = project.ProjectName,
                        PredictedUsers = prediction + users,
                        CurrentUsers = users,
                        PredictionDate = predictionRequest.PredictionDate
                    });
                }
            }
            else
            {
                projects = await _projectRepository.GetProjects(predictionRequest.CompanyId);
                foreach (Project project in projects)
                {
                    var users = (await _projectUserRepository.GetUsersInProject(project.Id)).Count();
                    monthlyAvg = users / diff;
                    var prediction = monthlyAvg * (((predictionRequest.PredictionDate.Year - currentDate.Year) * 12) + predictionRequest.PredictionDate.Month - currentDate.Month);
                    res.Add(new UserPredictionResponse()
                    {
                        ProjectId = project.Id,
                        ProjectName = project.ProjectName,
                        PredictedUsers = prediction + users,
                        CurrentUsers = users,
                        PredictionDate = predictionRequest.PredictionDate
                    });
                }
            }
            return Ok(res);
        }
    }
}
