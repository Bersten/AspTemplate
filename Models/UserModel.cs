namespace Exercice.Models
{
    public class User
    {
        public int Id { get; set; }
        public string ?Name { get; set; }

        // Navigation vers UserProfile
        public UserProfile UserProfile { get; set; } = new UserProfile();
    }
}
