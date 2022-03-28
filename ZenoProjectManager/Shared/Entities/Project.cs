using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenoProjectManager.Shared.Entities
{
    public class Project
    {
        [Key]
        public Guid Id { get; set; }

        [Required, StringLength(255)]
        public string ProjectName { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public string Image { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public Guid CompanyId { get; set; }

        // Navigation property - Company
        [ForeignKey("CompanyId")]
        public Company Company { get; set; }

        // Navigation property - Ticket
        public ICollection<Ticket> Tickets { get; set; }

        // Navigation Property - ProjectUser
        public ICollection<ProjectUser> Users { get; set; }

        public Project()
        {
            Tickets = new List<Ticket>();
            Users = new List<ProjectUser>();
        }
    }
}
