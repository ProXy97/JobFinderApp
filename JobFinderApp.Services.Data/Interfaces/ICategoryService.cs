using JobFinderApp.Web.ViewModels.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFinderApp.Services.Data.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<JobSelectCategoryFormModel>> AllCategoriesAsync();
    }
}
