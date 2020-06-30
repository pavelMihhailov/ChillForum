namespace ChillForum.Profiles.Services.Profile
{
    using System.Linq;
    using System.Threading.Tasks;

    using AutoMapper;
    using ChillForum.Profiles.Data;
    using ChillForum.Profiles.Models.Profile;
    using Microsoft.EntityFrameworkCore;

    public class ProfileService : DataService<Data.Models.Profile>, IProfileService
    {
        private readonly IMapper mapper;

        public ProfileService(ProfilesDbContext dbContext, IMapper mapper)
            : base(dbContext)
        {
            this.mapper = mapper;
        }

        public async Task<T> GetByProfileId<T>(int id)
        {
            return await this.mapper
                .ProjectTo<T>(
                        this.All()
                        .Where(x => x.Id == id))
                .FirstOrDefaultAsync();
        }

        public async Task<T> GetByUserId<T>(string id)
        {
            return await this.mapper
                .ProjectTo<T>(
                        this.All()
                        .Where(x => x.UserId == id))
                .FirstOrDefaultAsync();
        }

        public async Task<ProfileDetailsOutputModel> Details(string username)
        {
            return await this.mapper
                .ProjectTo<ProfileDetailsOutputModel>(
                        this.All()
                        .Where(x => x.Username == username))
                .FirstOrDefaultAsync();
        }
    }
}
