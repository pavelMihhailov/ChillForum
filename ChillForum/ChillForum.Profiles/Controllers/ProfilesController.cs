namespace ChillForum.Profiles.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using ChillForum.Common.Controllers;
    using ChillForum.Common.Services.Identity;
    using ChillForum.Profiles.Data.Models;
    using ChillForum.Profiles.Models.Profile;
    using ChillForum.Profiles.Services.Profile;
    using ChillForum.Profiles.Services.Trophy;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    public class ProfilesController : ApiController
    {
        private readonly IProfileService profiles;
        private readonly ICurrentUserService currentUser;

        public ProfilesController(
            IProfileService profile,
            ITrophyService trophy,
            ICurrentUserService currentUser)
        {
            this.profiles = profile;
            this.currentUser = currentUser;
        }

        [HttpGet]
        public async Task<ActionResult<ProfileDetailsOutputModel>> Details(string username)
        {
            return await this.profiles.Details(username);
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult> Create(CreateProfileInputModel inputModel)
        {
            var profile = new Profile
            {
                UserId = inputModel.UserId,
                Username = inputModel.Username,
                Description = inputModel.Description,
                Image = inputModel.Image,
                BirthDate = inputModel.BirthDate,
                ProfileTrophies = new List<ProfileTrophy>(),
            };

            await this.profiles.Save(profile);

            return this.Ok();
        }

        [HttpPut]
        [Route(Id)]
        public async Task<ActionResult> Edit(int id, EditProfileInputModel inputModel)
        {
            var profile = await this.profiles.GetByUserId<Profile>(this.currentUser.UserId);

            if (id != profile.Id)
            {
                return this.BadRequest();
            }

            profile.Description = inputModel.Description;
            profile.Image = inputModel.Image;
            profile.BirthDate = inputModel.BirthDate;

            await this.profiles.Save(profile);

            return this.Ok();
        }
    }
}
