using JobFinderApp.Data.Configurations;
using JobFinderApp.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JobFinderApp.Web.Data
{
    public class JobFinderDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public JobFinderDbContext(DbContextOptions<JobFinderDbContext> options)
            : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Job> Jobs { get; set; } = null!;
        public DbSet<JobCategory> JobsCategories { get; set; } = null!;
        public DbSet<Resumee> Resumees { get; set; } = null!;
        public DbSet<SavedJobs> SavedJobs { get; set; } = null!;
        public DbSet<Skill> Skills { get; set; } = null!;
        public DbSet<UserJobs> UsersJobs { get; set; } = null!;
        public DbSet<UserSkills> UsersSkills { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<UserSkills>()
                .HasKey(x => new { x.UserId, x.SkillId });

            builder.Entity<UserJobs>()
                .HasKey(x => new { x.UserId, x.JobId });

            builder.Entity<UserSkills>()
                .HasKey(x => new { x.UserId, x.SkillId });

            builder.Entity<SavedJobs>()
                .HasKey(x => new { x.UserId, x.JobId });

            
            builder.ApplyConfiguration(new ResumeeEntityConfiguration());
            builder.ApplyConfiguration(new CategoryEntityConfiguration());
            builder.ApplyConfiguration(new JobEntityConfiguration());
            builder.ApplyConfiguration(new SkillEntityConfiguration());
            builder.ApplyConfiguration(new JobCategoryConfiguration());
            

            base.OnModelCreating(builder);
        }
    }
}