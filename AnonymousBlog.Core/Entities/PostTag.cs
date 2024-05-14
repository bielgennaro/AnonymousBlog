namespace AnonymousBlog.Core.Entities
{
    public sealed class PostTag
    {
        private int PostId { get; set; }

        private int TagId { get; set; }

        private Post Post { get; set; }

        private Tag Tag { get; set; }

        public PostTag(int postId, int tagId, Post post, Tag tag)
        {
            PostId = postId;
            TagId = tagId;
            Post = post;
            Tag = tag;
        }
    }
}
