namespace ChillForum.Profiles.Services.Trophy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using AutoMapper;
    using ChillForum.Profiles.Data;
    using ChillForum.Profiles.Data.Models;
    using ChillForum.Profiles.Models.Trophey;

    public class TrophyService : DataService<Trophy>, ITrophyService
    {
        private readonly IMapper mapper;

        public TrophyService(ProfilesDbContext dbContext, IMapper mapper)
            : base(dbContext)
        {
            this.mapper = mapper;
        }

        public List<TrophyOutputModel> GetTrophiesOf(int profileId)
        {
            var trophiesIds = this.Data.ProfilesTrophies
                .Where(x => x.ProfileId == profileId)
                .Select(x => x.TrophyId)
                .ToList();

            var trophies = this.mapper.Map<List<TrophyOutputModel>>(
                    this.Data.Trophies
                    .Where(x => trophiesIds.Contains(x.Id)));

            return trophies;
        }
    }
}
