using EGreetings.Data;
using EGreetings.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EGreetings.Controllers
{
    public class TransactionController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly EGreetingsDbContext _context;
        public TransactionController(UserManager<User> userManager, EGreetingsDbContext context, IWebHostEnvironment hostEnvironment)
        {
            this.userManager = userManager;
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            string userId = Request.Cookies["UserID"];

            var trans = await _context.Transactions
                                           .Where(x => x.UserID == userId)
                                           .ToListAsync();
            return View(trans);
        }
    }
}
