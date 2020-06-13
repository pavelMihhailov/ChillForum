namespace ChillForum.Identity.Services.Interfaces
{
    using ChillForum.Identity.Data.Models;

    public interface ITokenGeneratorService
    {
        string GenerateToken(User user);
    }
}
