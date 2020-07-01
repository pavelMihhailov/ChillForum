namespace ChillForum.Posts.Gateway.Services.Posts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using ChillForum.Posts.Gateway.Models.Posts;
    using Refit;

    public interface IPostsService
    {
        [Get("/Posts/AllPostsOfProfile")]
        Task<List<PostOutputModel>> AllPostsOfProfile(int profileId);
    }
}
