using JobFinderApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobFinderApp.Data.Configurations
{
    public class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            ICollection<Category> categories = CreateCategory();
            builder.HasData(categories);
        }

        private ICollection<Category> CreateCategory()
        {
            List<Category> categories = new List<Category>()
            {
                new Category()
                {
                    Id = 1,
                    Name = "IT"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Accounting"
                },
                new Category()
                {
                    Id = 3,
                    Name = "Marketing"
                },
                new Category()
                {
                    Id = 4,
                    Name = "Management"
                },
                new Category()
                {
                    Id = 5,
                    Name = "Sales"
                },
                new Category()
                {
                    Id = 6,
                    Name = "Engineering"
                },
                new Category()
                {
                    Id = 7,
                    Name = "Healthcare"
                },
                new Category()
                {
                    Id = 8,
                    Name = "Education"
                },
                new Category()
                {
                    Id = 9,
                    Name = "Other"
                },
                new Category()
                {
                    Id = 10,
                    Name = "Finance"
                }
                
            };
            return categories;
        }
    }
}
