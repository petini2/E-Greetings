using System.Diagnostics;
using EGreetings_Project.Data;
using EGreetings_Project.Models;
using EGreetings_Project.Models.ViewModelAccount;
using EGreetings_Project.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EGreetings_Project.Controllers
{
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
            // Lấy 8 sản phẩm có discount, sắp xếp theo ngày tạo mới nhất
            var discountedTemplates = db.Templates
                .Where(t => t.Discount > 0)
                .OrderByDescending(t => t.CreatedDate)
                .Take(8)
                .ToList();

            // Khai báo biến newArrivalTemplates
            List<Template> newArrivalTemplates;

            // Lấy 8 sản phẩm mới nhất không cần discount
            if (string.IsNullOrEmpty(groupCate) || groupCate == "all")
            {
                newArrivalTemplates = db.Templates
                    .OrderByDescending(t => t.CreatedDate)
                    .Take(8)
                    .ToList();
            }
            else
            {
                // Lọc theo GroupCate (giả sử Template có thuộc tính GroupCate)
                newArrivalTemplates = db.Templates
                    .Where(t => t.Category.GroupCate.ToLower() == groupCate.ToLower())    // Lọc theo GroupCate
                    .OrderByDescending(t => t.CreatedDate)
                    .Take(8)
                    .ToList();
            }

            // Tạo một HomeViewModel
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
