using System.ComponentModel.DataAnnotations;

namespace AnonymousBlog.Core.Entities
{
    public sealed class Tag
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Name field can't be null!")]
        public string Name { get; set; }

        public ICollection<PostTag> PostTags { get; set; }

        public Tag()
        { }

        public Tag(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Tag(string name)
        {
            Name = name;
        }

        public override bool Equals(object? obj)
        {
            return obj is Tag tag &&
                   Id == tag.Id &&
                   Name == tag.Name &&
                   EqualityComparer<ICollection<PostTag>>.Default.Equals(PostTags, tag.PostTags);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, PostTags);
        }
    }
}
