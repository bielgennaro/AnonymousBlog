using System.ComponentModel.DataAnnotations;

namespace AnonymousBlog.Core.Entities
{
    public sealed class Post
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Title field can't be null!")]
        public string Title { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Content field can't be null!")]
        public string Content { get; set; }

        public DateTime CreatedAt { get; set; }

        public int UserId { get; set; }
        public User Author { get; set; }

        public ICollection<Comment> Comments { get; } = new List<Comment>();

        public ICollection<PostTag> PostTags { get; set; }

        public Post()
        { }

        public Post(int id, string title, string content, User author, int userId, DateTime createdAt)
        {
            Id = id;
            Title = title;
            Content = content;
            Author = author;
            UserId = userId;
            CreatedAt = createdAt;
        }

        public Post(string title, string content, int userId, DateTime createdAt, User author)
        {
            Title = title;
            Content = content;
            CreatedAt = createdAt;
            UserId = userId;
            Author = author;
        }

        public override bool Equals(object? obj)
        {
            return obj is Post post &&
                   Id == post.Id &&
                   Title == post.Title &&
                   Content == post.Content &&
                   CreatedAt == post.CreatedAt &&
                   UserId == post.UserId &&
                   EqualityComparer<User>.Default.Equals(Author, post.Author) &&
                   EqualityComparer<ICollection<Comment>>.Default.Equals(Comments, post.Comments) &&
                   EqualityComparer<ICollection<PostTag>>.Default.Equals(PostTags, post.PostTags);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Title, Content, CreatedAt, UserId, Author, Comments, PostTags);
        }
    }
}
