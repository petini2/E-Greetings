using EGreetings.Data;
using EGreetings.Models.ViewModelAccount;
using Microsoft.AspNetCore.Mvc;

namespace EGreetings.Controllers
{
    using EGreetings.Models;
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly EGreetingsDbContext db;
        //private readonly ICategoryService _categoryService;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;

        //}
        public HomeController(ILogger<HomeController> logger, EGreetingsDbContext db)
        {
            _logger = logger;
            this.db = db;
        }

        public IActionResult Index(string groupCate)
        {
            ViewBag.CurrentCategory = string.IsNullOrEmpty(groupCate) ? "all" : groupCate;
            // Get 8 discounted templates, sorted by latest created date and ensuring status is true
            var discountedTemplates = db.Templates
                .Where(t => t.Discount > 0 && t.Status == true)
                .OrderByDescending(t => t.CreatedDate)
                .Take(8)
                .ToList();

            // Initialize a list for new arrivals
            List<Template> newArrivalTemplates;

            // If no group category is selected or "all" is passed, get all templates that are active
            if (string.IsNullOrEmpty(groupCate) || groupCate == "all")
            {
                newArrivalTemplates = db.Templates
                    .Where(t => t.Status == true)  // Ensuring the status is true
                    .OrderByDescending(t => t.CreatedDate)
                    .Take(8)
                    .ToList();
            }
            else
            {
                // Filter templates by the selected group category (assuming GroupCate exists in Category model)
                newArrivalTemplates = db.Templates
                    .Where(t => t.Category.GroupCate.ToLower() == groupCate.ToLower() && t.Status == true)  // Filter by groupCate and ensure status is true
                    .OrderByDescending(t => t.CreatedDate)
                    .Take(8)
                    .ToList();
            }

            // Create a HomeViewModel to pass the data to the view
            var viewModel = new HomeViewModel
            {
                DiscountedTemplates = discountedTemplates,
                NewArrivals = newArrivalTemplates
            };

            return View(viewModel);
        }


        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        //public async Task<IActionResult> Index(string groupCate)
        //{
        //    if (string.IsNullOrEmpty(groupCate))
        //    {
        //        // If no groupCate is provided, you could handle it accordingly
        //        return View(new List<Category>());
        //    }

        //    // Get the list of categories based on groupCate
        //    var categories = await _categoryService.GetCategoriesByGroupCate(groupCate);

        //    // Pass the categories list to the view
        //    return View(categories);
        //}
    }
}
