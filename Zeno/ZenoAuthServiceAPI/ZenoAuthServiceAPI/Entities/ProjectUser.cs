using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenoAuthServiceAPI.Entities
{
    public class ProjectUser
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey("ProjectId")]
        public Guid ProjectId { get; set; }

        [ForeignKey("UserId")]
        public Guid UserId { get; set; }

        [Required, StringLength(50)]
        public string Email { get; set; }

        // Navigation Property - Project
        public Project Project { get; set; }

        // Navigation Property - User
        public User User { get; set; }
    }
}
