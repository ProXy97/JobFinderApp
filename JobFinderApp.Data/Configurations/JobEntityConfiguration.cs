using JobFinderApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobFinderApp.Data.Configurations
{
    public class JobEntityConfiguration : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            ICollection<Job> jobs = CreateJobs();
            builder.HasData(jobs);
        }

        private ICollection<Job> CreateJobs()
        {
            List<Job> jobs = new List<Job>()
            {
                new Job
                {
                    Id = 1,
                    Title = "Junior Software Developer",
                    Description = "We are looking for a Junior Software Developer to join our team! As a Junior Software Developer, you will be responsible for the development of new software products and enhancements to existing products. You should excel in working with large-scale applications and frameworks and have outstanding communication and leadership skills.",
                    CategoryId = 1,
                    Company = "SoftUni",
                    Location = "Sofia",
                    Salary = 2000,
                },
                new Job
                {
                    Id = 2,
                    Title = "Senior Sales Representative",
                    Description = "We are looking for a Senior Sales Representative to join our team! As a Senior Sales Representative, you will be responsible for the development of new sales and enhancements to existing sales. You should excel in working with large-scale sales and frameworks and have outstanding communication and leadership skills.",
                    CategoryId = 5,
                    Company = "S&A Produce",
                    Location = "Plovdiv",
                },
                new Job
                {
                    Id = 3,
                    Title = "Production Supervisor",
                    Description = "We are looking for a Production Supervisor to join our team! As a Production Supervisor, you will be responsible for the development of new products and enhancements to existing products. You should excel in working with large-scale applications and frameworks and have outstanding communication and leadership skills.",
                    CategoryId = 4,
                    Company = "S&A Produce",
                    Location = "Bourgas",
                    Salary = 2500
                },
                new Job
                {
                    Id = 4,
                    Title = "ProSeal Engineer",
                    Description = "We are looking for a ProSeal Engineer to join our team! As a ProSeal Engineer, you will be responsible for the development of new products and enhancements to existing products. You should excel in working with large-scale applications and frameworks and have outstanding communication and leadership skills.",
                    CategoryId = 6,
                    Company = "Avara Foods",
                    Location = "Veliko Tarnovo",
                    Salary = 1800
                },
                new Job
                {
                    Id = 5,
                    Title = "Senior Accountant",
                    Description = "We are looking for a Senior Accountant to join our team! As a Senior Accountant, you will be responsible for the development of new products and enhancements to existing products. You should excel in working with large-scale applications and frameworks and have outstanding communication and leadership skills.",
                    CategoryId = 2,
                    Company = "Tesco Supermarket",
                    Location = "Canterbury, UK",
                    Salary = 3000

                }
                
            };
            return jobs;
        }
    }
}
