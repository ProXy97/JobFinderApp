using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobFinderApp.Data.Models
{
    public class UserJobs
    {
        public UserJobs()
        {
            this.ApplicationDate = DateTime.UtcNow;
        }

        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }

        public ApplicationUser User { get; set; } = null!;

        [ForeignKey(nameof(Job))]
        public int JobId { get; set; }

        public Job Job { get; set; } = null!;

        public DateTime ApplicationDate { get; set; }


    }
}


//Status(e.g., Applied, Shortlisted, Rejected)