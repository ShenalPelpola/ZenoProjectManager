using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using ZenoProjectManager.Shared.Entities;

namespace ZenoProjectManager.Client.Services
{
    public interface ICompanyService
    {
        Task<IEnumerable<Company>> GetCompanies(string userId);
        Task<Company> GetCompanyById(Guid id);
        Task<Company> CreateCompany(Company company);
        Task<Company> UpdateCompany(Company company);
        Task<Company> DeleteCompany(string name);
    }
}

