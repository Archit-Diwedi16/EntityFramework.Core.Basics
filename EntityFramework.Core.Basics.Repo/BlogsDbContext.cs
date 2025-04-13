using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Core.Basics.Repo
{
    public class BlogsDbContext : DbContext
    {
        public BlogsDbContext(DbContextOptions<BlogsDbContext> options) : base(options)
        {

        }
        public BlogsDbContext() { }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Post> Blogs { get; set; }
        public DbSet<Post> BlogSettings { get; set; }
        public DbSet<Post> PostTags { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-CAIV8K1;Database=BlogsDb;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True"); // Replace with your PostgreSQL connection string
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>()
            .HasOne(b => b.blogSettings)
            .WithOne(bs => bs.Blog)
            .HasForeignKey<BlogSettings>(bs => bs.BlogId);

            modelBuilder.Entity<PostTag>()
            .HasKey(pt => new { pt.PostId, pt.TagId });

            modelBuilder.Entity<PostTag>()
            .HasOne(pt => pt.Post)
            .WithMany(p => p.PostTags)
            .HasForeignKey(pt => pt.PostId);

            modelBuilder.Entity<PostTag>()
            .HasOne(pt => pt.Tag)
            .WithMany(t => t.PostTags)
            .HasForeignKey(pt => pt.TagId);
        }
    }
}
