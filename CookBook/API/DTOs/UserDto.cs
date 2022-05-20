namespace API.DTOs
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
    }
}
