using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static JobFinderApp.Common.EntityValidationConstants.Resumee;
namespace JobFinderApp.Data.Models
{
    public class Resumee
    {
        public Resumee()
        {
            this.Id = new Guid();
            this.UploadDate = DateTime.UtcNow;
        }

        [Key]
        public Guid Id { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }

        public ApplicationUser User { get; set; } = null!;

        [Required]
        [MaxLength(FileMaxLength)]
        public string ResumeFile { get; set; }

        public DateTime UploadDate { get; set; }
    }
}
