namespace ChillForum.Posts.Data
{
    using System.Reflection;

    using ChillForum.Posts.Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class PostsDbContext : DbContext
    {
        public PostsDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
