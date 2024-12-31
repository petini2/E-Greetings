using EGreetings.Constants;
using EGreetings.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EGreetings.Areas.Admin.Controllers
{
    using EGreetings.Models;
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly EGreetingsDbContext _context;
        private readonly ILogger<CategoryController> _logger;

        public CategoryController(EGreetingsDbContext context, ILogger<CategoryController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var groupCounts = await _context.Categories
                                            .GroupBy(itemGroup => itemGroup.GroupCate)
                                            .Select(item => new
                                            {
                                                GroupCate = item.Key,
                                                Count = item.Count()
                                            })
                                            .ToListAsync();

            var groupNames = groupCounts.ToDictionary(
                                          item => item.GroupCate ?? "Unknown",
                                          item =>
                                          {
                                              var groupKey = item.GroupCate ?? "Unknown";
                                              return GroupCategory.GroupCategoryList.ContainsKey(groupKey)
                                                   ? GroupCategory.GroupCategoryList[groupKey]
                                                   : "Unknown";
                                          });

            var counts = groupCounts.Select(item => item.Count).ToList();
            var combinedData = new Tuple<Dictionary<string, string>, List<int>>(groupNames, counts);

            ViewData["IsCategory"] = true;
            return View(combinedData);
        }


        public IActionResult CreateSubCategory(string groupCategory)
        {
            ViewData["IsCategory"] = true;
            ViewData["HasCreateSubCategory"] = true;
            ViewData["GroupCategoryKey"] = groupCategory;
            ViewData["GroupCategoryValue"] = GroupCategory.GroupCategoryList[groupCategory];

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateSubCategory(Category category, string groupCategory)
        {
            _logger.LogInformation("Group Category: " + groupCategory);
            _logger.LogInformation("Category Name: " + category.CategoryName);

            // Kiểm tra ModelState
            if (!ModelState.IsValid)
            {
                _logger.LogInformation("ModelState không hợp lệ!");
            }

            if (string.IsNullOrEmpty(category.CategoryName))
            {
                ModelState.AddModelError("CategoryName", "Category Name is required.");
            }
            if (category.CategoryName?.Length < 3 || category.CategoryName?.Length > 50)
            {
                ModelState.AddModelError("CategoryName", "It is between 3 and 50 characters long.");
            }
            if (ModelState.IsValid)

            {
                if (category.Templates == null) { category.Templates = new List<Template>(); }

                category.CreatedDate = DateTime.Now;
                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(SubCategoryList), new { groupCategory = category.GroupCate });
            }

            // Kiểm tra ViewData đã được điền đầy đủ chưa
            _logger.LogInformation("GroupCategoryKey: " + ViewData["GroupCategoryKey"]);
            _logger.LogInformation("GroupCategoryValue: " + ViewData["GroupCategoryValue"]);

            ViewData["IsCategory"] = true;
            ViewData["HasCreateSubCategory"] = true;
            ViewData["GroupCategoryKey"] = groupCategory;
            ViewData["GroupCategoryValue"] = GroupCategory.GroupCategoryList[groupCategory];

            return View(category);
        }



        public async Task<IActionResult> SubCategoryList(string groupCategory)
        {
            var categories = await _context.Categories
                                           .Where(itemCategory => itemCategory.GroupCate == groupCategory)
                                           .OrderByDescending(itemCategory => itemCategory.CreatedDate)
                                           .ToListAsync();

            ViewData["IsCategory"] = true;
            ViewData["IsSubCategoryList"] = true;
            ViewData["GroupCategoryKey"] = groupCategory;
            ViewData["GroupCategoryValue"] = GroupCategory.GroupCategoryList[groupCategory];

            return View(categories);
        }


        [HttpPost]
        public async Task<IActionResult> UpdateStatus(int categoryId, bool status, string groupCategory)
        {
            var category = await _context.Categories.FindAsync(categoryId);
            if (category != null)
            {
                category.Status = status;
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(SubCategoryList), new { groupCategory = groupCategory });
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateCategoryName(int categoryId, string categoryName)
        {
            var category = await _context.Categories.FindAsync(categoryId);
            if (category == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                category.CategoryName = categoryName;
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(SubCategoryList), new { groupCategory = category.GroupCate });
        }
    }
}

