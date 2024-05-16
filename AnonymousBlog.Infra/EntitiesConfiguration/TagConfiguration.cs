using AnonymousBlog.Core.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnonymousBlog.Infra.EntitiesConfiguration
{
    public class TagConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Name).IsRequired();

            builder.HasMany(t => t.PostTags)
                .WithOne(pt => pt.Tag)
                .HasForeignKey(pt => pt.TagId);
        }
    }
}
