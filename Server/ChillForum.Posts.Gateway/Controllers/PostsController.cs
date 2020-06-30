namespace ChillForum.Posts.Gateway.Controllers
{
    using System.Threading.Tasks;

    using ChillForum.Common.Controllers;
    using ChillForum.Posts.Gateway.Models;
    using ChillForum.Posts.Gateway.Services.Posts;
    using ChillForum.Posts.Gateway.Services.Profiles;

    public class PostsController : ApiController
    {
        private readonly IPostsService postsService;
        private readonly IProfilesService profilesService;

        public PostsController(IPostsService postsService, IProfilesService profilesService)
        {
            this.postsService = postsService;
            this.profilesService = profilesService;
        }

        public async Task<ProfilePostsAndTropheysOutputModel> ProfilePostsAndTropheys(int profileId)
        {
            var posts = await this.postsService.AllPostsOfProfile(profileId);
            var trophies = await this.profilesService.GetAll(profileId);

            var viewModel = new ProfilePostsAndTropheysOutputModel()
            {
                ProfileId = profileId,
                Posts = posts,
                Tropheys = trophies,
            };

            return viewModel;
        }
    }
}
