namespace ChillForum.Common.Infrastructure
{
    using Microsoft.AspNetCore.Authorization;

    using static ChillForum.Common.Infrastructure.InfrastructureConstants;

    public class AuthorizeAdministratorAttribute : AuthorizeAttribute
    {
        public AuthorizeAdministratorAttribute() => this.Roles = AdministratorRoleName;
    }
}
