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
    public class CompanyRepository : ICompanyRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CompanyRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        /// <summary>
        /// Get detials of the company from the companies table.
        /// </summary>
        /// <returns>IEnumerable of Details of companies</returns>
        public async Task<IEnumerable<Company>> GetCompanies(Guid userId)
        {
            return await _applicationDbContext.Companies
                 .Where(company => company.UserId == userId)
                .ToListAsync();
        }

        /// <summary>
        /// Gets detials of the company by id from the companies table.
        /// </summary>
        /// <returns>Details of the company selected by id.</returns>
        public async Task<Company> GetCompanyById(Guid id)
        {
            return await _applicationDbContext.Companies
                .FirstOrDefaultAsync(company => company.Id == id);
        }

        /// <summary>
        /// Gets detials of the company by name from the compaies table.
        /// </summary>
        /// <returns>Details of the company selected by name.</returns>
        public async Task<Company> GetCompanyByName(string companyName)
        {
            return await _applicationDbContext.Companies
                .FirstOrDefaultAsync(company => company.CompanyName == companyName);
        }

        /// <summary>
        /// Create a new company from the companies table.
        /// </summary>
        /// <returns>Details of the newly created company.</returns>
        public async Task<Company> Add(Company company)
        {
            var result = await _applicationDbContext.Companies.AddAsync(company);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        /// <summary>
        /// Deleted company from the companies table.
        /// </summary>
        /// <returns>Details of the deleted company.</returns>
        public async Task<Company> DeleteByName(string name)
        {
            var result = await GetCompanyByName(name);

            if (result != null)
            {
                _applicationDbContext.Companies.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
                return result;
            }
            return null;
        }

        /// <summary>
        /// update company from the companies table.
        /// </summary>
        /// <returns>Details of the updated company.</returns>
        public async Task<Company> Update(Company company)
        {
            var CompanyToUpdate = await GetCompanyById(company.Id);
            if (CompanyToUpdate != null) 
            {
                CompanyToUpdate.CompanyName = company.CompanyName;
                CompanyToUpdate.Description = company.Description;
                CompanyToUpdate.Type = company.Type;
                CompanyToUpdate.Avatar = company.Avatar;

                await _applicationDbContext.SaveChangesAsync();
                return CompanyToUpdate;
            }
            return null;
        }
    }
}



