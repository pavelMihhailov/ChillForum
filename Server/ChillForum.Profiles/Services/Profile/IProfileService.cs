namespace ChillForum.Profiles.Services.Profile
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using ChillForum.Profiles.Data.Models;
    using ChillForum.Profiles.Models.Profile;
    using ChillForum.Profiles.Models.Trophey;

    public interface IProfileService : IDataService<Profile>
    {
        Task<ProfileDetailsOutputModel> Details(string username);

        Task<T> GetByProfileId<T>(int id);

        Task<T> GetByUserId<T>(string id);
    }
}
