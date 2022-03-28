using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;
using ZenoProjectManager.Shared.Entities;

namespace ZenoProjectManager.Server.Model
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetById(Guid id);
        Task<User> GetByEmail(string email);
        Task<User> Add(User user);
        Task<User> Update(User user);
        Task<User> DeleteByEmail(string email);
    }
}