using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenoPredictionAPI.Entities
{
    public class Company
    {
        [Key]
        public Guid Id { get; set; }

        [Required, StringLength(255)]
        public string CompanyName { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public string Type { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        public string Avatar { get; set; }

        // Navigation Property - Project
        public ICollection<Project> Projects { get; set; }

        [Required]
        public Guid UserId { get; set; }

        // Navigation property - Company
        [ForeignKey("UserId")]
        public User User { get; set; }

        public Company()
        {
            Projects = new List<Project>();
        }
    }
}
