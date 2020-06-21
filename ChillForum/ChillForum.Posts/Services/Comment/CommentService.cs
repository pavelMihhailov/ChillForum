namespace ChillForum.Posts.Services.Comment
{
    using System.Linq;
    using System.Threading.Tasks;

    using ChillForum.Posts.Data;
    using ChillForum.Posts.Data.Models;
    using Microsoft.AspNetCore.Mvc;

    public class CommentService : DataService<Comment>, ICommentService
    {
        public CommentService(PostsDbContext dbContext)
            : base(dbContext)
        {
        }

        public async Task<IActionResult> Delete(int id)
        {
            var comment = this.Data.Comments.FirstOrDefault(x => x.Id == id);

            if (comment == null)
            {
                return new BadRequestResult();
            }

            this.Data.Remove(comment);
            await this.Data.SaveChangesAsync();

            return new OkResult();
        }
    }
}
