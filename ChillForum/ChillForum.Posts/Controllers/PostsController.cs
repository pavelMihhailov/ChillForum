namespace ChillForum.Posts.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using AutoMapper;
    using ChillForum.Common.Controllers;
    using ChillForum.Posts.Data.Models;
    using ChillForum.Posts.Models.Posts;
    using ChillForum.Posts.Services.Post;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class PostsController : ApiController
    {
        private readonly IPostService posts;
        private readonly IMapper mapper;

        public PostsController(IPostService posts, IMapper mapper)
        {
            this.posts = posts;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IList<Post>> All() =>
            await this.posts.GetAll();

        [HttpGet]
        [Route(Id)]
        public async Task<PostOutputModel> Details(int id)
        {
            var post = await this.posts.GetById<PostOutputModel>(id);

            return post;
        }

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

        [HttpPost]
        [Route(nameof(Delete))]
        public async Task<bool> Delete(int id)
        {
            var isDeleted = await this.posts.Delete(id);

            return isDeleted;
        }
    }
}
