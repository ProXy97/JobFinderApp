using JobFinderApp.Data.Models;
using JobFinderApp.Services.Data.Interfaces;
using JobFinderApp.Web.Data;
using JobFinderApp.Web.ViewModels.Category;
using JobFinderApp.Web.ViewModels.Job;
using Microsoft.EntityFrameworkCore;

namespace JobFinderApp.Services.Data
{
    public class JobService : IJobService
    {
        private readonly JobFinderDbContext dbContext;

        public JobService(JobFinderDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddJobAsync(JobViewModel model, string userId)
        {
            try
            {
                Job newJob = new Job
                {
                    Title = model.Title,
                    Description = model.Description,
                    Company = model.Company,
                    Location = model.Location,
                    IsActive = true,
                    Salary = model.Salary,
                    CategoryId = model.CategoryId,
                };
                await dbContext.Jobs.AddAsync(newJob);
                await dbContext.SaveChangesAsync();
            }
            catch (Exception)
            {

            }
        }

        public async Task DeleteJobByIdAsync(int id)
        {
            Job jobToDelete = await dbContext.Jobs
                .Where(j => j.IsActive)
                .FirstAsync(j => j.Id == id);

            jobToDelete.IsActive = false;

            await dbContext.SaveChangesAsync();
        }

        public async Task EditJobAsync(JobViewModel model, string userId)
        {
            var currentJob = await dbContext.Jobs.FindAsync(userId);

            if (currentJob != null)
            {
                currentJob.Title = model.Title;
                currentJob.Description = model.Description;
                currentJob.Company = model.Company;
                currentJob.Location = model.Location;
                currentJob.Salary = model.Salary;
                currentJob.CategoryId = model.CategoryId;

                dbContext.Jobs.Update(currentJob);
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<AllJobsViewModel>> GetAllJobsAsync()
        {
            return await dbContext.Jobs
                .Where(j => j.IsActive == true)
                .Select(j => new AllJobsViewModel
                {
                    Id = j.Id,
                    Title = j.Title,
                    Description = j.Description,
                    Location = j.Location,
                    Salary = j.Salary,
                })
                .ToListAsync();
        }

        public async Task<JobViewModel?> GetJobByIdForEdit(int id)
        {
            var categories = await dbContext.Categories
                .Select(c => new JobSelectCategoryFormModel
                {
                    Id = c.Id,
                    Name = c.Name,
                }).ToListAsync();
                
            return await dbContext.Jobs
                .Where(j => j.IsActive && j.Id == id)
                .Select(j => new JobViewModel
                {
                    Title = j.Title,
                    Description = j.Description,
                    Company = j.Company,
                    Location = j.Location,
                    Salary = j.Salary,
                    CategoryId = j.CategoryId,
                    Categories = categories
                })
                .FirstOrDefaultAsync();
        }

        public async Task<JobViewModel> GetNewAddJobAsync()
        {
            var categories = await dbContext.Categories
                .Select (c => new JobSelectCategoryFormModel
                {
                    Id = c.Id,
                    Name = c.Name,
                })
                .ToListAsync();
            var model = new JobViewModel
            {
                Categories = categories
            };
            return model;
        }

        public async Task<JobDescriptionViewModel?> JobDetailsAsync(int id)
        {
            return await dbContext.Jobs
                .Where(j => j.Id == id)
                .Select(j => new JobDescriptionViewModel
                {
                    Id = j.Id,
                    Title = j.Title,
                    Description = j.Description,
                    Company = j.Company,
                    Location = j.Location,
                    Salary = j.Salary,
                    Category = j.Category.Name,
                    DatePosted = j.DatePosted,
                })
                .FirstOrDefaultAsync();
        }
    }
}
