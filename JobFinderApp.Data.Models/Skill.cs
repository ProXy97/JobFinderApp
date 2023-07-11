using System.ComponentModel.DataAnnotations;
using static JobFinderApp.Common.EntityValidationConstants.Skill;
namespace JobFinderApp.Data.Models
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;
    }
}
