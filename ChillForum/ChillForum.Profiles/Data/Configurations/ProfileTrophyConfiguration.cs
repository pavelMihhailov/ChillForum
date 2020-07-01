namespace ChillForum.Profiles.Data.Configurations
{
    using ChillForum.Profiles.Data.Models;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ProfileTrophyConfiguration : IEntityTypeConfiguration<ProfileTrophy>
    {
        public void Configure(EntityTypeBuilder<ProfileTrophy> builder)
        {
            builder.HasKey(x => new { x.ProfileId, x.TrophyId });
        }
    }
}
