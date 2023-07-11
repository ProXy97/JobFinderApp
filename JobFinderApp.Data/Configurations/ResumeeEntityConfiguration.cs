using JobFinderApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobFinderApp.Data.Configurations
{
    public class ResumeeEntityConfiguration : IEntityTypeConfiguration<Resumee>
    {
        public void Configure(EntityTypeBuilder<Resumee> builder)
        {
            builder
               .HasOne(x => x.User)
               .WithOne(x => x.Resumee)
               .HasForeignKey<Resumee>(x => x.UserId);

        }
    }
}
