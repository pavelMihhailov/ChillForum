namespace ChillForum.Identity
{
    using ChillForum.Common.Infrastructure;
    using ChillForum.Common.Services;
    using ChillForum.Identity.Data;
    using ChillForum.Identity.Infrastructure;
    using ChillForum.Identity.Services;
    using ChillForum.Identity.Services.Interfaces;

    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services
                    .AddWebService<IdentityDbContext>(this.Configuration)
                    .AddUserStorage()
                    .AddTransient<IDataSeeder, IdentityDataSeeder>()
                    .AddTransient<IIdentityService, IdentityService>()
                    .AddTransient<ITokenGeneratorService, TokenGeneratorService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
            => app
                .UseWebService(env)
                .Initialize();
    }
}
