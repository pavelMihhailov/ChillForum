namespace ChillForum.Posts.Controllers
{
    using System.Threading.Tasks;

    using ChillForum.Common.Controllers;
    using ChillForum.Posts.Data.Models;
    using ChillForum.Posts.Models.Comments;
    using ChillForum.Posts.Services.Comment;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class CommentsController : ApiController
    {
        private readonly ICommentService comments;

        public CommentsController(ICommentService comments)
        {
            this.comments = comments;
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Add(CreateCommentInputModel inputModel)
        {
            var comment = new Comment
            {
                AuthorId = inputModel.AuthorId,
                PostId = inputModel.PostId,
                Content = inputModel.Content,
            };

            await this.comments.Save(comment);

            return this.Ok();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Delete(int id) =>
            await this.comments.Delete(id);
    }
}
