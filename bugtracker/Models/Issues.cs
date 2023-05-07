using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using bugtracker.Models;

namespace bugtracker.Models
{
    public class Issues
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [ForeignKey("Priority")]
        public IssuePriority PriorityFK { get; set; }

        [ForeignKey("CreatorFK")]
        public IdentityUser Creator { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedOn { get; set; }

        [ForeignKey("ClosedByFK")]
        public IdentityUser? ClosedBy { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ClosedOn { get; set; }

        public string Resolution { get; set; }
    }

}
