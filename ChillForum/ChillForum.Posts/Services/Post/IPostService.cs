namespace ChillForum.Posts.Services.Post
{
    using System.Threading.Tasks;

    using ChillForum.Posts.Data.Models;

    public interface IPostService : IDataService<Post>
    {
        Task<T> GetById<T>(int id);
    }
}
