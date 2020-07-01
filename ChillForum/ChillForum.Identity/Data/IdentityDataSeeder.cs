namespace ChillForum.Identity.Data
{
    using System.Linq;
    using System.Threading.Tasks;

    using ChillForum.Common.Services;
    using ChillForum.Identity.Data.Models;
    using Microsoft.AspNetCore.Identity;

    using static ChillForum.Common.Infrastructure.InfrastructureConstants;

    public class IdentityDataSeeder : IDataSeeder
    {
        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public IdentityDataSeeder(
            UserManager<User> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        public void SeedData()
        {
            if (this.roleManager.Roles.Any())
            {
                return;
            }

            Task
                .Run(async () =>
                {
                    var adminRole = new IdentityRole(AdministratorRoleName);

                    await this.roleManager.CreateAsync(adminRole);

                    var adminUser = new User
                    {
                        UserName = "admin@pavel.com",
                        Email = "admin@pavel.com",
                        SecurityStamp = "RandomSecurityStamp",
                    };

                    await this.userManager.CreateAsync(adminUser, "paveladmin");

                    await this.userManager.AddToRoleAsync(adminUser, AdministratorRoleName);
                })
                .GetAwaiter()
                .GetResult();
        }
    }
}
