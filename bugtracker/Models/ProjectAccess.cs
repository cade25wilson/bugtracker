using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace bugtracker.Models
{
    public class ProjectAccess
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        public Projects Project { get; set; }

        [ForeignKey("AspNetUsers")]
        public IdentityUser UserId { get; set; }

        [ForeignKey("AspNetRoles")]
        public IdentityRole AccessType { get; set; }
    }
}
