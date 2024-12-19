using EGreetings_Project.Data;
using EGreetings_Project.Models;
using EGreetings_Project.Constants;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EGreetings_Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly EGreetingsDbContext _context;

        public CategoryController(EGreetingsDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewData["IsCategory"] = true;
            return View(GroupCategory.GroupCategoryList);
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
            if (string.IsNullOrEmpty(category.CategoryName))
            {
                ModelState.AddModelError("CategoryName", "Category Name is required.");
            }
            if (category.CategoryName?.Length < 3 || category.CategoryName?.Length > 50) {
                ModelState.AddModelError("CategoryName", "It is between 3 and 50 characters long.");
            }
 
            if (ModelState.IsValid)
            {
                // category.CreatedDate = DateTime.Now;
                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(SubCategoryList), new { groupCategory = category.GroupCate });
            }

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

          if (ModelState.IsValid) {
            category.CategoryName = categoryName;
            await _context.SaveChangesAsync();
          }

          return RedirectToAction(nameof(SubCategoryList), new { groupCategory = category.GroupCate });
        }
    }
}

