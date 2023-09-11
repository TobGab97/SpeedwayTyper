namespace SpeedwayTyper.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string CurrentPassword { get; set; }
        public string CreatedBy { get; set; }
        public string Role { get; set; }
        public int UserPoints { get; set; }
    }
}
