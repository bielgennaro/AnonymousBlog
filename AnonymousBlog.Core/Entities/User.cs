using System.ComponentModel.DataAnnotations;

namespace AnonymousBlog.Core.Entities
{
    public sealed class User
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Username field can't be null!")]
        public string Username { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password field can't be null!")]
        public string Password { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Email field can't be null!")]
        public string Email { get; set; }

        public User()
        { }

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
