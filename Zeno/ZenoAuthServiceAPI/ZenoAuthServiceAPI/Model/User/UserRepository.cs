using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZenoAuthServiceAPI.Data;
using ZenoAuthServiceAPI.Entities;

namespace ZenoAuthServiceAPI.Model
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public UserRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        /// <summary>
        /// This method retrive a list of users from the database.
        /// </summary>
        /// <returns>A IEnumerable list of users.</returns>
        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _applicationDbContext.Users.ToListAsync();
        }

        /// <summary>
        /// This method retrive a users by email from the database.
        /// </summary>
        /// <returns>Details of user.</returns>
        public async Task<User> GetByEmail(string email)
        {
            return await _applicationDbContext.Users
                   .FirstOrDefaultAsync(user => user.Email == email);
        }

        /// <summary>
        /// This method retrive a users by id from the database.
        /// </summary>
        /// <returns>Details of user.</returns>
        public async Task<User> GetById(Guid id)
        {
            return await _applicationDbContext.Users
                   .FirstOrDefaultAsync(user => user.Id == id);
        }

        /// <summary>
        /// This method adds a user to the user table.
        /// </summary>
        /// <returns>Details of the newly added user.</returns>
        public async Task<User> Add(User user)
        {
            var result = await _applicationDbContext.Users.AddAsync(user);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        /// <summary>
        /// This method deletes a user to the user table by email.
        /// </summary>
        /// <returns>Details of the deleted user.</returns>
        public async Task<User> DeleteByEmail(string email)
        {
            var result = await GetByEmail(email);

            if (result != null)
            {
                _applicationDbContext.Users.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
                return result;
            }
            return null;
        }

        /// <summary>
        /// This method updates a user.
        /// </summary>
        /// <returns>Details of the updated user.</returns>
        public async Task<User> Update(User user)
        {
            var userToUpdate = await GetById(user.Id);
            if (userToUpdate != null)
            {
                userToUpdate.FirstName = user.FirstName;
                userToUpdate.LastName = user.LastName;
                userToUpdate.Department = user.Department;
                userToUpdate.Position = user.Position;
                userToUpdate.Avatar = user.Avatar;

                await _applicationDbContext.SaveChangesAsync();
                return userToUpdate;
            }
            return null;
        }
    }
}

