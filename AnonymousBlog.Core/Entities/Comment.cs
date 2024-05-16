using System.ComponentModel.DataAnnotations;

namespace AnonymousBlog.Core.Entities
{
    public sealed class Comment
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Content field can't be null!")]
        public string Content { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public int PostId { get; set; }

        public Comment()
        { }

        public Comment(int id, string content, DateTime createdAt)
        {
            Id = id;
            Content = content;
            CreatedAt = createdAt;
        }

        public Comment(string content, DateTime createdAt)
        {
            Content = content;
            CreatedAt = createdAt;
        }

        public override bool Equals(object? obj)
        {
            return obj is Comment comment &&
                   Id == comment.Id &&
                   Content == comment.Content &&
                   CreatedAt == comment.CreatedAt &&
                   PostId == comment.PostId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Content, CreatedAt, PostId);
        }
    }
}
