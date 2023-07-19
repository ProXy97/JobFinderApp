using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static JobFinderApp.Common.EntityValidationConstants.Job;
namespace JobFinderApp.Data.Models
{
    public class Job
    {
        public Job()
        {
            this.DatePosted = DateTime.UtcNow;
            this.JobsCategories = new HashSet<JobCategory>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Company { get; set; } = null!;

        [Required]
        [MaxLength(LocationMaxLength)]
        public string Location { get; set; } = null!;

        public double? Salary { get; set; }

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public bool IsActive { get; set; }

        public DateTime DatePosted { get; set; }

        public ICollection<JobCategory> JobsCategories { get; set; }
    }
}