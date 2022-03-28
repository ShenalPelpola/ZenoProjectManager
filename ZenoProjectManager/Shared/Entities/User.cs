using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenoProjectManager.Shared.Entities
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [StringLength(50)]
        public string FirstName { get; set;}

        [StringLength(50)]
        public string LastName { get; set; }

        public string Avatar { get; set; }

        public string Role { get; set; }

        [Required, StringLength(50)]
        public string Email { get; set; }

        public string Password { get; set; }

        public string Department { get; set; }

        public string Position { get; set; }

        // Navigation Property - Company
        public ICollection<Company> Companies { get; set; }

        // Navigation Property - Ticket
        public ICollection<Ticket> Tickets { get; set; }

        // Navigation Property - ProjectUser
        public ICollection<ProjectUser> Projects { get; set; }

        public User()
        {
            Companies = new List<Company>();
            Tickets = new List<Ticket>();
            Projects = new List<ProjectUser>();
        }
    }
}
