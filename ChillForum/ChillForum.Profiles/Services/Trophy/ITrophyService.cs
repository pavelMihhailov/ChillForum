namespace ChillForum.Profiles.Services.Trophy
{
    using System.Collections.Generic;

    using ChillForum.Profiles.Data.Models;
    using ChillForum.Profiles.Models.Trophey;

    public interface ITrophyService : IDataService<Trophy>
    {
        List<TrophyOutputModel> GetTrophiesOf(int profileId);
    }
}
