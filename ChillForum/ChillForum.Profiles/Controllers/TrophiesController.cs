namespace ChillForum.Profiles.Controllers
{
    using System.Collections.Generic;

    using ChillForum.Common.Controllers;
    using ChillForum.Profiles.Models.Trophey;
    using ChillForum.Profiles.Services.Trophy;
    using Microsoft.AspNetCore.Mvc;

    public class TrophiesController : ApiController
    {
        private readonly ITrophyService trophy;

        public TrophiesController(ITrophyService trophy)
        {
            this.trophy = trophy;
        }

        [HttpGet]
        public List<TrophyOutputModel> GetAll(int profileId) =>
            this.trophy.GetTrophiesOf(profileId);
    }
}
