using JobFinderApp.Services.Data.Interfaces;
using JobFinderApp.Web.Data;
using JobFinderApp.Web.ViewModels.Category;
using Microsoft.EntityFrameworkCore;

namespace JobFinderApp.Services.Data
{
    public class CategoryService : ICategoryService
    {

        private readonly JobFinderDbContext dbContext;

        public CategoryService(JobFinderDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<JobSelectCategoryFormModel>> AllCategoriesAsync()
        {
            IEnumerable<JobSelectCategoryFormModel> allCategories = await this.dbContext
                .Categories
                .AsNoTracking()
                .Select(c => new JobSelectCategoryFormModel
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .ToArrayAsync();

            return allCategories;
        }
    }
}
