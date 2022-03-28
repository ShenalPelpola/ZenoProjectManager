
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenoProjectManager.Shared.Entities
{
    public class Ticket
    {
        [Key]
        public Guid Id { get; set; }

        [Required, StringLength(255)]
        public string TicketName { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public int StoryPoints { get; set; }

        public string Type { get; set; }

        [Required]
        public string Status { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        public DateTime? CompletedDate { get; set; }

        [Required]
        public Guid ProjectId { get; set; }
        public Guid? UserId { get; set; }

        // Navigation Property - Project
        [ForeignKey("ProjectId")]
        public Project Project { get; set; }

        [ForeignKey("UserId")]
        // Navigation Property - User
        public User User { get; set; }
    }
}
