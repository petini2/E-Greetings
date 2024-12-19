using EGreetings_Project.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EGreetings_Project.Controllers
{
    public class ECardController : Controller
    {
        private readonly EGreetingsDbContext db;

        public ECardController(EGreetingsDbContext context)
        {
            db = context;
        }

        // Action to get all categories
        //public IActionResult Index()
        //{
        //    var allCategories = _context.GetAllCategories();  // Fetches all categories
        //    return View(allCategories);
        //}
        public IActionResult Index()
        {
            var categories = db.Categories.Where(c => c.Status).ToList();
            return View("ECards", categories);
        }

        // Action to get categories by group
        //public IActionResult ByGroup(GroupCateEnum groupCate)
        //{
        //    var categoriesByGroup = _context.GetCategoriesByGroupCate(groupCate);  // Fetches categories by GroupCate
        //    return View(categoriesByGroup);
        //}

        public IActionResult ECardDesign()
        {
            return View();
        }
    }
}
