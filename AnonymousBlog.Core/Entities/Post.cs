namespace AnonymousBlog.Core.Entities
{
    public sealed class Post
    {
        private int Id { get; set; }

        private string Title { get; set; }

        private string Content { get; set; }

        private DateTime CreatedAt { get; set; }

        private User Author { get; set; }

        private ICollection<Comment> Comments { get; } = new List<Comment>();

        private ICollection<PostTag> PostTags { get; } = new List<PostTag>();

        public Post(int id, string title, string content, DateTime createdAt)
        {
            Id = id;
            Title = title;
            Content = content;
            CreatedAt = createdAt;
        }

        public Post(string title, string content, DateTime createdAt, User author)
        {
            Title = title;
            Content = content;
            CreatedAt = createdAt;
            Author = author;
        }

        public override bool Equals(object? obj)
        {
            return obj is Post post &&
                   Id == post.Id &&
                   Title == post.Title &&
                   Content == post.Content &&
                   CreatedAt == post.CreatedAt &&
                   EqualityComparer<User>.Default.Equals(Author, post.Author);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Title, Content, CreatedAt, Author);
        }
    }
}
