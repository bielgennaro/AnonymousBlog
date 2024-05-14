namespace AnonymousBlog.Core.Entities
{
    public sealed class Comment
    {
        private int Id { get; set; }

        private string Content { get; set; }

        private DateTime CreatedAt { get; set; }

        private Post PostId { get; set; }

        public Comment(int id, string content, DateTime createdAt, Post postId)
        {
            Id = id;
            Content = content;
            CreatedAt = createdAt;
            PostId = postId;
        }

        public Comment(string content, DateTime createdAt, Post postId)
        {
            Content = content;
            CreatedAt = createdAt;
            PostId = postId;
        }

        public override bool Equals(object? obj)
        {
            return obj is Comment comment &&
                   Id == comment.Id &&
                   Content == comment.Content &&
                   CreatedAt == comment.CreatedAt &&
                   EqualityComparer<Post>.Default.Equals(PostId, comment.PostId);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Content, CreatedAt, PostId);
        }
    }
}
