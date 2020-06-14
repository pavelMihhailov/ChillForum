namespace ChillForum.Profiles.Services.Profile
{
    using System.Threading.Tasks;

    using ChillForum.Profiles.Data.Models;
    using ChillForum.Profiles.Models.Profile;

    public interface IProfileService : IDataService<Profile>
    {
        Task<ProfileDetailsOutputModel> Details(string username);

        Task<T> GetByProfileId<T>(int id);
    }
}
