namespace ChillForum.Admin.Services.Posts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using ChillForum.Admin.Models.Posts;
    using Microsoft.AspNetCore.Mvc;
    using Refit;

    public interface IPostService
    {
        [Get("/Posts")]
        Task<IList<PostOutputModel>> All();

        [Get("/Posts/{id}")]
        Task<PostOutputModel> Details(int id);

        [Post("/Posts/Delete")]
        Task<bool> Delete(int id);
    }
}
