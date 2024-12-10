using Microsoft.AspNetCore.Mvc;

namespace EGreetings_Project.Controllers
{
    public class SpecialController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
