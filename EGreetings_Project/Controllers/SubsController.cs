using Microsoft.AspNetCore.Mvc;

namespace EGreetings_Project.Controllers
{
    public class SubsController : Controller
    {
        public IActionResult Index()
        {
            return View("Subs");
        }
    }
}
