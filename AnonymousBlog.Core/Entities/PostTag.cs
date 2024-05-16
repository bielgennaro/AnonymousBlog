namespace AnonymousBlog.Core.Entities
{
    public sealed class PostTag
    {
        public int PostId { get; set; }
        public Post Post { get; set; }

        public int TagId { get; set; }
        public Tag Tag { get; set; }

        public PostTag()
        { }

        public PostTag(int postId, int tagId)
        {
            PostId = postId;
            TagId = tagId;
        }
    }
}
