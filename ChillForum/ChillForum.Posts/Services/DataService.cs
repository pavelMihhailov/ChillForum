namespace ChillForum.Posts.Services
{
    using System.Linq;
    using System.Threading.Tasks;
    using ChillForum.Posts.Data;

    public abstract class DataService<TEntity> : IDataService<TEntity>
        where TEntity : class
    {
        protected DataService(PostsDbContext db)
        {
            this.Data = db;
        }

        protected PostsDbContext Data { get; }

        public async Task Save(TEntity entity)
        {
            this.Data.Update(entity);

            await this.Data.SaveChangesAsync();
        }

        protected IQueryable<TEntity> All() => this.Data.Set<TEntity>();
    }
}
