using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobFinderApp.Data.Models
{
    public class JobCategory
    {

        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Job))]
        public int JobId { get; set; }

        public Job Job { get; set; } = null!;

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }

        public Category Category { get; set; } = null!;

    }
}
