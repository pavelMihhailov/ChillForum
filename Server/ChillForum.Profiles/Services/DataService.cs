namespace ChillForum.Profiles.Services
{
    using System.Linq;
    using System.Threading.Tasks;
    using ChillForum.Profiles.Data;

    public abstract class DataService<TEntity> : IDataService<TEntity>
        where TEntity : class
    {
        protected DataService(ProfilesDbContext db)
        {
            this.Data = db;
        }

        protected ProfilesDbContext Data { get; }

        public async Task Save(TEntity entity)
        {
            this.Data.Update(entity);

            await this.Data.SaveChangesAsync();
        }

        protected IQueryable<TEntity> All() => this.Data.Set<TEntity>();
    }
}
