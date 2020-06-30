namespace ChillForum.Admin.Models.Identity
{
    using ChillForum.Common.Infrastructure.AutoMapper;

    public class UserInputModel : IMapFrom<LoginFormModel>
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }
}
