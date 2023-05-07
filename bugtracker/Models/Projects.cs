using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bugtracker.Models
{
    public class Projects
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }   
        [DataType(DataType.Date)]
        public DateTime ModifiedOn { get; set; }
        [ForeignKey("ModifiedBy")]
        public IdentityUser User { get; set; }
    }
}
