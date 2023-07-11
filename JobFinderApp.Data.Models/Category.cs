using System.ComponentModel.DataAnnotations;
using static JobFinderApp.Common.EntityValidationConstants.Category;
namespace JobFinderApp.Data.Models
{
    public class Category
    {
        public Category()
        {
            this.JobsCategories = new HashSet<JobCategory>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        public ICollection<JobCategory> JobsCategories { get; set; }
    }
}
