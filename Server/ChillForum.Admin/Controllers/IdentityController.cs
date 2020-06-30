namespace ChillForum.Admin.Controllers
{
    using System;
    using System.Threading.Tasks;

    using AutoMapper;
    using ChillForum.Admin.Models.Identity;
    using ChillForum.Admin.Services.Identity;
    using ChillForum.Common.Infrastructure;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    using static ChillForum.Common.Infrastructure.InfrastructureConstants;

    public class IdentityController : AdministrationController
    {
        private readonly IIdentityService identityService;
        private readonly IMapper mapper;

        public IdentityController(IIdentityService identityService, IMapper mapper)
        {
            this.identityService = identityService;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return this.View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginFormModel model)
            => await this.Handle(
                async () =>
                {
                    var result = await this.identityService
                        .Login(this.mapper.Map<UserInputModel>(model));

                    this.Response.Cookies.Append(
                        AuthenticationCookieName,
                        result.Token,
                        new CookieOptions
                        {
                            HttpOnly = true,
                            Secure = true,
                            MaxAge = TimeSpan.FromDays(1),
                        });
                },
                success: this.RedirectToAction(nameof(PostsController.Index), "Posts"),
                failure: this.View("../Home/Index", model));

        [HttpGet]
        public IActionResult Register()
        {
            return this.View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterFormModel model)
            => await this.Handle(
                async () =>
                {
                    var result = await this.identityService
                        .Register(this.mapper.Map<RegisterUserInputModel>(model));
                },
                success: this.RedirectToAction(nameof(this.Login)),
                failure: this.View(model));

        [AuthorizeAdministrator]
        public IActionResult Logout()
        {
            this.Response.Cookies.Delete(AuthenticationCookieName);

            return this.RedirectToAction(nameof(HomeController.Index), "Home");
        }
    }
}
