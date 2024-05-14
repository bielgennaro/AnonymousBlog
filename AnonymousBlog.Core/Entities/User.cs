namespace AnonymousBlog.Core.Entities
{
    public sealed class User
    {
        private int Id { get; set; }

        private string Username { get; set; }

        private string Password { get; set; }

        private string Email { get; set; }

        public User(int id, string username, string password, string email)
        {
            Id = id;
            Username = username;
            Password = password;
            Email = email;
        }

        public User(string username, string password, string email)
        {
            Username = username;
            Password = password;
            Email = email;
        }

        public override bool Equals(object? obj)
        {
            return obj is User user &&
                   Id == user.Id &&
                   Username == user.Username &&
                   Password == user.Password &&
                   Email == user.Email;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Username, Password, Email);
        }
    }
}
