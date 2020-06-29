namespace ChillForum.Admin.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using AutoMapper;
    using ChillForum.Admin.Models.Posts;
    using ChillForum.Admin.Services.Posts;
    using Microsoft.AspNetCore.Mvc;

    public class PostsController : AdministrationController
    {
        private readonly IPostService posts;
        private readonly IMapper mapper;

        public PostsController(IPostService posts, IMapper mapper)
        {
            this.posts = posts;
            this.mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var mappedPosts = this.mapper.Map<List<PostOutputModel>>(await this.posts.All());

            return this.View(mappedPosts);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int postId)
        {
            var post = await this.posts.Details(postId);

            return this.View(post);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var successfulDelete = await this.posts.Delete(id);

            if (!successfulDelete)
            {
                return this.BadRequest();
            }

            return this.Redirect(nameof(this.Index));
        }
    }
}
