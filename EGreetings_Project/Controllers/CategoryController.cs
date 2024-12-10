using Microsoft.AspNetCore.Mvc;

namespace EGreetings_Project.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
