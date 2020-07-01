namespace ChillForum.Posts.Gateway.Services.Profiles
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using ChillForum.Posts.Gateway.Models.Tropheys;
    using Refit;

    public interface IProfilesService
    {
        [Get("/Trophies/GetAll")]
        Task<List<TrophyOutputModel>> GetAll(int profileId);
    }
}
