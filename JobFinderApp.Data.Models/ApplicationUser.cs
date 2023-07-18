using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static JobFinderApp.Common.EntityValidationConstants.User;

namespace JobFinderApp.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid();
            this.Skills = new HashSet<Skill>();
        }

        [Required]
        [MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(LastNameMaxLength)]
        public string LastName { get; set; } = null!;

        [MaxLength(AddressMaxLength)]
        public string? Address { get; set; }

        [Phone]
        [MaxLength(PhoneMaxLength)]
        public string? Phone { get; set; }

        [ForeignKey(nameof(Resumee))]
        public int? ResumeeId { get; set; }

        public Resumee? Resumee { get; set; }

        public ICollection<Skill> Skills { get; set; }

    }
}
