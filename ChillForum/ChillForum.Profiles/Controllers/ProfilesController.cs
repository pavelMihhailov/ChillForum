namespace ChillForum.Profiles.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using ChillForum.Common.Controllers;
    using ChillForum.Profiles.Data.Models;
    using ChillForum.Profiles.Models.Profile;
    using ChillForum.Profiles.Services.Profile;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class ProfilesController : ApiController
    {
        private readonly IProfileService profile;

        public ProfilesController(IProfileService profile)
        {
            this.profile = profile;
        }

        [HttpGet]
        public async Task<ActionResult<ProfileDetailsOutputModel>> Details(string username)
        {
            return await this.profile.Details(username);
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult> Create(CreateProfileInputModel inputModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            var profile = new Profile
            {
                UserId = inputModel.UserId,
                Username = inputModel.Username,
                Description = inputModel.Description,
                Image = inputModel.Image,
                BirthDate = inputModel.BirthDate,
                ProfileTrophies = new List<ProfileTrophy>(),
            };

            await this.profile.Save(profile);

            return this.Ok();
        }
    }
}
