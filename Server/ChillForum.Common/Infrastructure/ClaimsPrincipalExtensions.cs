namespace ChillForum.Common.Infrastructure
{
    using System.Security.Claims;

    public static class ClaimsPrincipalExtensions
    {
        public static bool IsAdministrator(this ClaimsPrincipal user)
            => user.IsInRole(InfrastructureConstants.AdministratorRoleName);
    }
}
