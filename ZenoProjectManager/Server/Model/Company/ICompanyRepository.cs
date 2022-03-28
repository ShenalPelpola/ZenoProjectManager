using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using ZenoProjectManager.Shared.Entities;

namespace ZenoProjectManager.Server.Model
{
    public interface ICompanyRepository
    {
        Task<IEnumerable<Company>> GetCompanies(Guid userId);
        Task<Company>GetCompanyById(Guid id);
        Task<Company> GetCompanyByName(string companyName);
        Task<Company> Add(Company company);
        Task<Company> Update(Company company);
        Task<Company> DeleteByName(string name);
    }
}
