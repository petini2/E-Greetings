using System.Diagnostics;
using EGreetings_Project.Data;
using EGreetings_Project.Models;
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


        public IActionResult Index()
        {
            // Lấy tất cả các category từ database
            var categories = db.Categories.ToList();

            // Truyền danh sách category vào ViewData
            ViewData["Categories"] = categories;

            return View();
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
