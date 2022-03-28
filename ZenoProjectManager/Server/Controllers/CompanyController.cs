using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenoProjectManager.Server.Model;
using ZenoProjectManager.Shared;
using ZenoProjectManager.Shared.Entities;

namespace ZenoProjectManager.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class CompanyController : ControllerBase
    {
        private readonly ILogger<CompanyController> _logger;
        private readonly ICompanyRepository _companyRepository;

        public CompanyController(ILogger<CompanyController> logger,
            ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
            _logger = logger;
        }

        /// <summary>
        /// GET: /company - For returning a list of companies managed by the admin.
        /// </summary>
        /// <returns>A list of companies</returns>
        [Authorize(Roles = "admin")]
        [HttpGet]
        public async Task<IActionResult> GetCompanies([FromQuery] Guid userId)
        {
            _logger.LogInformation(
                $"Method: {nameof(GetCompanies)}" +
                $"Message: 'return list of companies'");
            return Ok(await _companyRepository.GetCompanies(userId));
        }

        
        /// <summary>
        /// GET: /company/{id}return details of the company. 
        /// </summary>
        /// <returns>An details of the retrived company</returns>       
        [Authorize(Roles = "admin")]
        [HttpGet("{id:Guid}")]
        public async Task<ActionResult<Company>> GetCompanyById(Guid id)
        {
            try
            {
                var result = await _companyRepository.GetCompanyById(id);

                // check whether the company exists.
                if (result == null)
                {
                    _logger.LogWarning(
                        $"Method: {nameof(GetCompanyById)}" +
                        $"Message: 'Company with the Id ${id} doesn't exist.'");
                    return NotFound();
                }
                _logger.LogInformation($"Method: {nameof(GetCompanyById)}" +
                                       $"Message: 'Company with the Id ${id} returned'");
                return result;
            }
            catch (Exception)
            {
                _logger.LogError(
                     $"Method: {nameof(GetCompanyById)}" +
                     $"Message: 'Error retriving data from database.'");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retriving data from the database");
            }
        }

        
         /// <summary>
         /// POST: /company/ - Create a new company.
         /// </summary>
         /// <returns>An details of the newly created company</returns>
        [Authorize(Roles = "admin")]
        [HttpPost]
        public async Task<ActionResult<Company>> CreateCompany(Company company)
        {
            try
            {
                // Check if the posted data is null and the company name is empty.
                if (company == null || company.CompanyName == "")
                {
                    _logger.LogError($"Method: {nameof(CreateCompany)}" +
                                      $"Message: 'Invalid request format.'");
                    return BadRequest();
                }

                // Check weather a company with the same name exists.
                var exists = await _companyRepository.GetCompanyByName(company.CompanyName);

                if (exists != null)
                {
                    _logger.LogError($"Method: {nameof(CreateCompany)}" +
                                     $"Message: 'Company with the Id ${company.Id} already exist'");
                    return StatusCode(StatusCodes.Status409Conflict, "Company already exists");
                }

                company.Id = Guid.NewGuid();

                var created = await _companyRepository.Add(company);

                _logger.LogInformation($"Method: {nameof(CreateCompany)}" +
                                       $"Message: 'A new company with the Id ${company.Id} created'");

                return CreatedAtAction(nameof(CreateCompany), new { id = created.Id }, created);
            }
            catch (Exception)
            {
                _logger.LogError($"Method: {nameof(CreateCompany)}" +
                    $"Message: 'Error creating company in the database'");

                return StatusCode(StatusCodes.Status500InternalServerError, "Error creating company in the database");
            }
        }

        
        /// <summary>
        /// DELETE: /company/ - Delete the company by name.
        /// </summary>
        /// <returns>An details of the deleted company</returns>
        [Authorize(Roles = "admin")]
        [HttpDelete("{name}")]
        public async Task<ActionResult<Company>> DeleteCompany(string name)
        {
            try
            {
                // check if the company exists.
                var company = await _companyRepository.GetCompanyByName(name);

                if (company == null)
                {
                    _logger.LogError(
                            $"Method: {nameof(DeleteCompany)}" +
                            $"Message: 'Company with the name ${name} doesn't exist'");
                    return NotFound();
                }

                _logger.LogInformation($"Method: {nameof(DeleteCompany)}" +
                       $"Message: 'company with the Id ${company.Id} deleted'");

                // return the deleted company data.
                return await _companyRepository.DeleteByName(name);
            }
            catch (Exception)
            {
                _logger.LogError($"Method: {nameof(DeleteCompany)}" +
                                 $"Message: 'Error deleting company from the database'");

                return StatusCode(StatusCodes.Status500InternalServerError, "Error deleting company from the database");
            }
        }

         
         /// <summary>
         /// PUT: /company/ - Update a existing company.
         /// </summary>
         /// <returns>An details of the updated company</returns>
        [Authorize(Roles = "admin")]
        [HttpPut]
        public async Task<ActionResult<Company>> UpdateCompany(Company company)
        {
            try
            {
                var exists = await _companyRepository.GetCompanyById(company.Id);
                // check if the company exist.
                if (exists == null)
                {
                    _logger.LogError(
                        $"Method: {nameof(UpdateCompany)}" +
                        $"Message: 'Company with the Id ${company.Id} doesn't exist'");
                    return NotFound();
                }

                _logger.LogInformation($"Method: {nameof(UpdateCompany)}" +
                                       $"Message: 'company with the Id ${company.Id} is updated'");

                // return the updated company data
                return await _companyRepository.Update(company);
            }
            catch (Exception)
            {
                _logger.LogError($"Method: {nameof(UpdateCompany)}" +
                 $"Message: 'Error updating company data in the database'");

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error updating company data in the database");
            }
        }
    }
}