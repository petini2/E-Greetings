using Microsoft.AspNetCore.Mvc;

namespace EGreetings.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            ViewData["IsDashboard"] = true;
            return View();
        }
    }
}
