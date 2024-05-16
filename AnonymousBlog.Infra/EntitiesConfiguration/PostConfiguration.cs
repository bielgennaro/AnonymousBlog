using AnonymousBlog.Core.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class PostConfiguration : IEntityTypeConfiguration<Post>
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Title).IsRequired();

        builder.Property(p => p.Content).IsRequired();

        builder.Property(p => p.CreatedAt).IsRequired();

        builder.HasOne(p => p.Author)
        .WithOne()
        .HasForeignKey<Post>(p => p.UserId);

        builder.HasMany(p => p.Comments);
    }
}
