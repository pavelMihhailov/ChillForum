namespace ChillForum.Posts
{
    using System.Reflection;

    using AutoMapper;
    using ChillForum.Common.Infrastructure;
    using ChillForum.Posts.Data;
    using ChillForum.Posts.Services.Post;
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
                    .AddWebService<PostsDbContext>(this.Configuration)
                    .AddAutoMapperProfile(Assembly.GetExecutingAssembly());

            services.AddTransient<IPostService, PostService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env) => app
                .UseWebService(env)
                .Initialize();
    }
}
