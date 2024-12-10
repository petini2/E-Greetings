using Microsoft.AspNetCore.Mvc;

namespace EGreetings_Project.Controllers
{
    public class SubController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
