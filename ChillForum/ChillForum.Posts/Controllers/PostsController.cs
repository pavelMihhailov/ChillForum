namespace ChillForum.Posts.Controllers
{
    using System.Threading.Tasks;

    using ChillForum.Common.Controllers;
    using ChillForum.Posts.Data.Models;
    using ChillForum.Posts.Models.Posts;
    using ChillForum.Posts.Services.Post;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class PostsController : ApiController
    {
        private readonly IPostService posts;

        public PostsController(IPostService posts)
        {
            this.posts = posts;
        }

        [HttpGet]
        [Route(Id)]
        public async Task<PostOutputModel> Index(int id) =>
            await this.posts.GetById<PostOutputModel>(id);

        [HttpPost]
        [Authorize]
        public async Task<ActionResult> Create(CreatePostInputModel inputModel)
        {
            var post = new Post
            {
                AuthorId = inputModel.AuthorId,
                Title = inputModel.Title,
                Content = inputModel.Content,
            };

            await this.posts.Save(post);

            return this.Ok();
        }
    }
}
