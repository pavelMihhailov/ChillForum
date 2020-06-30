namespace ChillForum.Posts.Services.Post
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using AutoMapper;
    using ChillForum.Posts.Data;
    using ChillForum.Posts.Data.Models;
    using ChillForum.Posts.Models.Posts;
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

        public Post GetById(int id)
        {
            var post = this.All().FirstOrDefault(x => x.Id == id);

            return post;
        }

        public async Task<IList<Post>> GetAll()
        {
            return await this.All().ToListAsync();
        }

        public async Task<bool> Delete(int id)
        {
            var post = this.GetById(id);

            if (post == null)
            {
                return false;
            }

            this.Data.Remove(post);
            await this.Data.SaveChangesAsync();

            return true;
        }
    }
}
