namespace ChillForum.Admin.Models.Identity
{
    using ChillForum.Common.Infrastructure.AutoMapper;

    public class RegisterUserInputModel : IMapFrom<RegisterFormModel>
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }
}
