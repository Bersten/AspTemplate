namespace Exercice.Models
{
    public class UserProfile
    {
        public int Id { get; set; }
        public string? Biography { get; set; }
        public string? ProfilePictureUrl { get; set; }

        // Clé étrangère vers User
        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
