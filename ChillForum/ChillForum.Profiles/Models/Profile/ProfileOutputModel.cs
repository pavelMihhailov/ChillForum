namespace ChillForum.Profiles.Models.Profile
{
    using ChillForum.Common.Infrastructure.AutoMapper;
    using ChillForum.Profiles.Data.Models;

    public class ProfileOutputModel : IMapFrom<Profile>
    {
        public int Id { get; set; }

        public string Username { get; set; }
    }
}
