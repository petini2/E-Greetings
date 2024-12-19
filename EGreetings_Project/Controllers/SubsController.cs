using EGreetings_Project.Data;
using Microsoft.AspNetCore.Mvc;

namespace EGreetings_Project.Controllers
{
    public class SubsController : Controller
    {
        private readonly EGreetingsDbContext _context;

        public SubsController(EGreetingsDbContext context)
        {
            _context = context;  
        }

        public IActionResult Index()
        {
           
            var subscriptions = _context.Subscriptions.ToList();  
         
            return View("Subs", subscriptions);
        }
    }
}
