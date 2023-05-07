using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace bugtracker.Models
{
    public class ProjectAccess
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        public Projects Project { get; set; }

        [ForeignKey("Users")]
        public int UserId { get; set; }
        public Users Users { get; set; }
        [ForeignKey("Roles")]
        public string AccessType { get; set; }

    }
}
