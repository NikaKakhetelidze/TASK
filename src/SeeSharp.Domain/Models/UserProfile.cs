using System.ComponentModel.DataAnnotations;

namespace SeeSharp.Domain.Models
{
    public class UserProfile
    {
        [Key]
        public string ProfileId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PersonalNumber { get; set; }
        public int Id { get; set; }
        public ApplicationUser User { get; set; } = null!;

        public UserProfile()
        {
            ProfileId = Guid.NewGuid().ToString();
        }
    }
}