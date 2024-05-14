namespace AnonymousBlog.Core.Entities
{
    public sealed class Tag
    {
        private int Id { get; set; }

        private string Name { get; set; }

        private ICollection<PostTag> PostTags { get; } = new List<PostTag>();

        public Tag(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Tag(string name)
        {
            Name = name;
        }
    }
}
