namespace ChillForum.Profiles.Models.Trophey
{
    using ChillForum.Common.Infrastructure.AutoMapper;
    using ChillForum.Profiles.Data.Models;

    public class TrophyOutputModel : IMapFrom<Trophy>
    {
        public int Id { get; set; }

        public byte[] Image { get; set; }

        public string Title { get; set; }
    }
}
