using bugtracker.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace bugtracker.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<ProjectAccess> ProjectAccess { get; set; }
        public DbSet<Issues> Issues { get; set; }
        public DbSet<IssuePriority> IssuePriority { get; set; }
        public DbSet<IssueStatus> IssueStatus { get; set; }
    }
}