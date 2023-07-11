using JobFinderApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobFinderApp.Data.Configurations
{
    public class SkillEntityConfiguration : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            ICollection<Skill> skills = CreateSkill();
            builder.HasData(skills);
        }

        private ICollection<Skill> CreateSkill()
        {
            List<Skill> skills = new List<Skill>()
            {
                new Skill
                {
                    Id = 1,
                    Name = "C#"
                },
                new Skill
                {
                    Id = 2,
                    Name = "Java"
                },
                new Skill
                {
                    Id = 3,
                    Name = "JavaScript"
                },
                new Skill
                {
                    Id = 4,
                    Name = "Python"
                },
                new Skill
                {
                    Id = 5,
                    Name = "PHP"
                },
                new Skill
                {
                    Id = 6,
                    Name = "Leadership"
                },
                new Skill
                {
                    Id = 7,
                    Name = "Communication"
                },
                new Skill
                {
                    Id = 8,
                    Name = "Teamwork"
                },
                new Skill
                {
                    Id = 9,
                    Name = "Problem-solving"
                },
                new Skill
                {
                    Id = 10,
                    Name = "Creativity"
                },
                new Skill
                {
                    Id = 11,
                    Name = "Adaptability"
                },
                new Skill
                {
                    Id = 12,
                    Name = "Collaboration"
                },
                new Skill
                {
                    Id = 13,
                    Name = "Technical proficiency"
                },
                new Skill
                {
                    Id = 14,
                    Name = "Adaptability"
                },
            };
            return skills;
        }
    }
}
