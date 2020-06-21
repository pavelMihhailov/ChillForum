namespace ChillForum.Posts.Services.Post
{
    using System.Linq;
    using System.Threading.Tasks;

    using AutoMapper;
    using ChillForum.Posts.Data;
    using ChillForum.Posts.Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class PostService : DataService<Post>, IPostService
    {
        private readonly IMapper mapper;

        public PostService(PostsDbContext dbContext, IMapper mapper)
            : base(dbContext)
        {
            this.mapper = mapper;
        }

        public async Task<T> GetById<T>(int id)
        {
            return await this.mapper
                .ProjectTo<T>(
                        this.All()
                        .Where(x => x.Id == id))
                .FirstOrDefaultAsync();
        }
    }
}
