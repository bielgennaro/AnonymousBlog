using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AnonymousBlog.Core.Entities;

namespace AnonymousBlog.Ui.Data
{
    public class AnonymousBlogContext : DbContext
    {
        public AnonymousBlogContext(DbContextOptions<AnonymousBlogContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; } = default!;
        public DbSet<Post> Post { get; set; } = default!;
        public DbSet<Tag> Tag { get; set; } = default!;
        public DbSet<PostTag> PostTag { get; set; } = default!;
        public DbSet<Comment> Comment { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AnonymousBlogContext).Assembly);
        }
    }
}
