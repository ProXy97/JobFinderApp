using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobFinderApp.Data.Models
{
    public class UserSkills
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; } 

        public ApplicationUser User { get; set; } = null!;

        [ForeignKey(nameof(Skill))]
        public int SkillId { get; set; }

        public Skill Skill { get; set; } = null!;
    }
}
