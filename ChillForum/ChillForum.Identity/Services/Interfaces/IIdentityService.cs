namespace ChillForum.Identity.Services.Interfaces
{
    using System.Threading.Tasks;

    using ChillForum.Common.Models;
    using ChillForum.Identity.Data.Models;
    using ChillForum.Identity.Models.Identity;

    public interface IIdentityService
    {
        Task<Result<User>> Register(UserInputModel userInput);

        Task<Result<UserOutputModel>> Login(UserInputModel userInput);

        Task<Result> ChangePassword(string userId, ChangePasswordInputModel changePasswordInput);
    }
}
