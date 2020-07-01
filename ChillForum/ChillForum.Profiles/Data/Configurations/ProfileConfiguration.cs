namespace ChillForum.Profiles.Data.Configurations
{
    using ChillForum.Profiles.Data.Models;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using static ChillForum.Profiles.Data.DataConstants;

    public class ProfileConfiguration : IEntityTypeConfiguration<Profile>
    {
        public void Configure(EntityTypeBuilder<Profile> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .Property(x => x.UserId)
                .IsRequired();

            builder
                .Property(x => x.Username)
                .IsRequired()
                .HasMaxLength(MaxUsernameLength);

            builder
                .Property(x => x.Description)
                .IsRequired(false)
                .HasMaxLength(MaxProfileDescriptionLength);
        }
    }
}
