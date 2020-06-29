namespace ChillForum.Admin.Controllers
{
    using System.Diagnostics;

    using ChillForum.Admin.Models;
    using ChillForum.Common.Infrastructure;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (this.User.IsAdministrator())
            {
                //return this.RedirectToAction(nameof(StatisticsController.Index), "Statistics");
            }

            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
            => this.View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier,
            });
    }
}
