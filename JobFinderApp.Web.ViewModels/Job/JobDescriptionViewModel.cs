using System.ComponentModel.DataAnnotations;

namespace JobFinderApp.Web.ViewModels.Job
{
    public class JobDescriptionViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string Company { get; set; } = null!;

        public string Location { get; set; } = null!;

        public double? Salary { get; set; }

        public string Category { get; set; } = null!;

        [Display(Name = "Posted on")]
        public DateTime DatePosted { get; set; }
    }
}
