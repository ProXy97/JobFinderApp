using JobFinderApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobFinderApp.Data.Configurations
{
    public class JobCategoryConfiguration : IEntityTypeConfiguration<JobCategory>
    {
        public void Configure(EntityTypeBuilder<JobCategory> builder)
        {
            builder
                .HasKey(x => new { x.JobId, x.CategoryId });

            builder
            .HasOne(jc => jc.Job)
            .WithMany(j => j.JobsCategories)
            .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(jc => jc.Category)
                .WithMany(c => c.JobsCategories)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
