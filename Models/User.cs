namespace library.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }        // human-friendly name
        public string Username { get; set; }    // login username
        public string PasswordHash { get; set; } // hashed password (education-level)
    }
}
