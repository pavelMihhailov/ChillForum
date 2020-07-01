namespace ChillForum.Profiles.Data
{
    using System.Reflection;

    using ChillForum.Profiles.Data.Models;

    using Microsoft.EntityFrameworkCore;

    public class ProfilesDbContext : DbContext
    {
        public ProfilesDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Profile> Profiles { get; set; }

        public DbSet<Trophy> Trophies { get; set; }

        public DbSet<ProfileTrophy> ProfilesTrophies { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
