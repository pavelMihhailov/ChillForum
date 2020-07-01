namespace ChillForum.Profiles.Data.Configurations
{
    using ChillForum.Profiles.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using static ChillForum.Profiles.Data.DataConstants;

    public class TrophyConfiguration : IEntityTypeConfiguration<Trophy>
    {
        public void Configure(EntityTypeBuilder<Trophy> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(MaxTrophyTitleLength);
        }
    }
}
