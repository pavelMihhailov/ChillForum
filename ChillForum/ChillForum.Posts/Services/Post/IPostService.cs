namespace ChillForum.Posts.Services.Post
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using ChillForum.Posts.Data.Models;
    using ChillForum.Posts.Models.Posts;

    public interface IPostService : IDataService<Post>
    {
        Task<T> GetById<T>(int id);

        Post GetById(int id);

        Task<IList<Post>> GetAll();

        Task<bool> Delete(int id);
    }
}
