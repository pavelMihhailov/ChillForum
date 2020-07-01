namespace ChillForum.Posts.Services.Comment
{
    using System.Threading.Tasks;

    using ChillForum.Posts.Data.Models;
    using Microsoft.AspNetCore.Mvc;

    public interface ICommentService : IDataService<Comment>
    {
        Task<IActionResult> Delete(int id);
    }
}
