using JobFinderApp.Web.ViewModels.Category;
using System.ComponentModel.DataAnnotations;
using static JobFinderApp.Common.EntityValidationConstants.Job;
namespace JobFinderApp.Web.ViewModels.Job
{
    public class JobViewModel
    {
        public JobViewModel()
        {
            this.Categories = new HashSet<JobSelectCategoryFormModel>();
        }

        [Required]
        [StringLength(TitleMaxLength, ErrorMessage = "Title must be between {2} and {1} characters long.", MinimumLength = TitleMinLength)]
        
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(DescriptionMaxLength, ErrorMessage = "Description must be between {2} and {1} characters long", MinimumLength = DescriptionMinLength)]
        public string Description { get; set; } = null!;

        [Required]
        [StringLength(CompanyMaxLength, ErrorMessage = "Company name must be between {2} and {1} characters long.", MinimumLength = CompanyMinLength)]
        public string Company { get; set; } = null!;

        [Required]
        [StringLength(LocationMaxLength, ErrorMessage = "Location must be between {2} and {1} characters long.", MinimumLength = LocationMinLength)]
        public string Location { get; set; } = null!;

        public double? Salary { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public IEnumerable<JobSelectCategoryFormModel> Categories { get; set; }
    }
}
