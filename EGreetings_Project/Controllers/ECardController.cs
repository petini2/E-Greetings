using Microsoft.AspNetCore.Mvc;

namespace EGreetings_Project.Controllers
{
    public class ECardController : Controller
    {
        public IActionResult Index()
        {
            return View("ECards");
        }
    }
}
