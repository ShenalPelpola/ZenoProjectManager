using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using ZenoProjectManager.Shared;
using ZenoProjectManager.Shared.Entities;

namespace ZenoProjectManager.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ProjectUser> ProjectUser { get; set; }
        public object Project { get; internal set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {}

        internal Task<bool> Where()
        {
            throw new NotImplementedException();
        }
    }
}