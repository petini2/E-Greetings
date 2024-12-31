using EGreetings.Constants;
using EGreetings.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EGreetings.Areas.Admin.Controllers
{
    using EGreetings.Models;
    [Area("Admin")]
    public class TemplateController : Controller
    {
        private readonly EGreetingsDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public TemplateController(EGreetingsDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }


        public async Task<IActionResult> Index(int id)
        {
            var templates = await _context.Templates
                                          .Where(itemTemplate => itemTemplate.CategoryID == id)
                                          .ToListAsync();

            var category = await _context.Categories
                                         .Where(itemCategory => itemCategory.CategoryID == id)
                                         .FirstOrDefaultAsync();
            if (category != null)
            {
                ViewData["CategoryName"] = category.CategoryName;
                ViewData["GroupCategory"] = category.GroupCate;
                if (category.GroupCate != null) ViewData["GroupCategoryValue"] = GroupCategory.GroupCategoryList[category.GroupCate];
                ViewData["CategoryID"] = category.CategoryID;
            }

            ViewData["IsCategory"] = true;
            ViewData["IsTemplateList"] = true;
            return View(templates);
        }



        public IActionResult Create(int id)
        {
            var category = _context.Categories
                                   .Where(itemCategory => itemCategory.CategoryID == id)
                                   .FirstOrDefault();
            if (category != null)
            {
                ViewData["CategoryID"] = category.CategoryID;
                ViewData["CategoryName"] = category.CategoryName;
                ViewData["GroupCategory"] = category.GroupCate;
            }
            else
            {
                ViewData["CategoryName"] = "Category not found";
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Template template,
                                                IFormFile imgVer, IFormFile imgHoz,
                                                IFormFile svgVer, IFormFile svgHoz)
        {
            var retainedCategory = await _context.Categories
                                           .Where(itemCategory => itemCategory.CategoryID == template.CategoryID)
                                           .FirstOrDefaultAsync();
            if (retainedCategory != null)
            {
                ViewData["CategoryID"] = retainedCategory.CategoryID;
                ViewData["CategoryName"] = retainedCategory.CategoryName;
                ViewData["GroupCategory"] = retainedCategory.GroupCate;
                template.Category = retainedCategory;
            }

            if (string.IsNullOrEmpty(template.TemplateName))
            {
                ModelState.AddModelError("TemplateName", "Template Name is required.");
            }
            if (template.TemplateName?.Length < 3 || template.TemplateName?.Length > 50)
            {
                ModelState.AddModelError("TemplateName", "It is between 3 and 50 characters long.");
            }

            if (string.IsNullOrEmpty(template.Price.ToString()))
            {
                ModelState.AddModelError("Price", "Price is required.");
            }
            if (string.IsNullOrEmpty(template.Discount.ToString()))
            {
                ModelState.AddModelError("Discount", "Discount is required.");
            }
            if (template.Price < 0)
            {
                ModelState.AddModelError("Price", "Price cannot be less than 0.");
            }
            if (template.Discount < 0)
            {
                ModelState.AddModelError("Discount", "Discount cannot be less than 0.");
            }
            if (template.Discount >= template.Price)
            {
                ModelState.AddModelError("Discount", "Discount must be less than Price");
            }

            if (imgVer == null || imgVer.Length == 0)
            {
                ModelState.AddModelError("imgVer", "Vertical image is required.");
            }
            if (imgHoz == null || imgHoz.Length == 0)
            {
                ModelState.AddModelError("imgHoz", "Horizontal image is required.");
            }
            if (svgVer == null || svgVer.Length == 0)
            {
                ModelState.AddModelError("svgVer", "Vertical SVG is required.");
            }
            if (svgHoz == null || svgHoz.Length == 0)
            {
                ModelState.AddModelError("svgHoz", "Horizontal SVG is required.");
            }

            if (imgVer != null && !IsValidImage(imgVer, "png"))
            {
                ModelState.AddModelError("imgVer", "Vertical image must be a PNG file.");
            }
            if (imgHoz != null && !IsValidImage(imgHoz, "png"))
            {
                ModelState.AddModelError("imgHoz", "Horizontal image must be a PNG file.");
            }
            if (svgVer != null && !IsValidImage(svgVer, "svg"))
            {
                ModelState.AddModelError("svgVer", "Vertical SVG must be an SVG file.");
            }
            if (svgHoz != null && !IsValidImage(svgHoz, "svg"))
            {
                ModelState.AddModelError("svgHoz", "Horizontal SVG must be an SVG file.");
            }


            if (!ModelState.IsValid)
            {
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    Console.WriteLine(error.ErrorMessage); // Replace with a logger in production
                }
            }

            if (ModelState.IsValid)
            {
                //if (template.Category == null && retainedCategory != null) {
                //template.Category = new Category();
                //}
                if (template.TemplateHistories == null) { template.TemplateHistories = new List<TemplateHistory>(); }
                if (template.Bookings == null) { template.Bookings = new List<Booking>(); }

                template.CreatedDate = DateTime.Now;

                string imageFolder = Path.Combine("wwwroot", "images/templates/img");
                if (imgVer != null) template.ImgVer = await SaveFileAsync(imgVer, imageFolder);
                if (imgHoz != null) template.ImgHoz = await SaveFileAsync(imgHoz, imageFolder);
                if (svgVer != null) template.SvgVer = await SaveFileAsync(svgVer, imageFolder);
                if (svgHoz != null) template.SvgHoz = await SaveFileAsync(svgHoz, imageFolder);

                try
                {
                    _context.Add(template);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index), new { id = template.CategoryID });
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message); // Replace with a logger
                    ModelState.AddModelError(string.Empty, "An error occurred while saving the template.");
                }
            }
            return View(template);
        }
        private bool IsValidImage(IFormFile file, string expectedExtension)
        {
            string fileExtension = Path.GetExtension(file.FileName).ToLowerInvariant();
            return fileExtension == $".{expectedExtension}";
        }
        private async Task<string> SaveFileAsync(IFormFile file, string folderPath)
        {
            if (file != null)
            {
                string fileExtension = Path.GetExtension(file.FileName);
                string uniqueFileName = Path.GetFileNameWithoutExtension(file.FileName) + "_" + Guid.NewGuid().ToString() + fileExtension;
                string filePath = Path.Combine(folderPath, uniqueFileName);
                Directory.CreateDirectory(folderPath);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
                return uniqueFileName;
            }
            return null;
        }



        [HttpPost]
        public async Task<IActionResult> UpdateStatus(int templateId, bool status, int categoryId)
        {
            var template = await _context.Templates.FindAsync(templateId);
            if (template != null)
            {
                template.Status = status;
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index), new { id = categoryId });
        }



        public async Task<IActionResult> Detail(int id, string categoryName)
        {
            var template = await _context.Templates.FirstOrDefaultAsync(itemTemplate => itemTemplate.TemplatesID == id);
            if (template == null)
            {
                return NotFound();
            }
            ViewData["CategoryName"] = categoryName;
            ViewData["CategoryID"] = template.CategoryID;
            return View(template);
        }



        public async Task<IActionResult> Edit(int id, string categoryName)
        {
            var template = await _context.Templates.FindAsync(id);
            if (template == null)
            {
                return NotFound();
            }

            ViewData["CategoryName"] = categoryName;
            ViewData["CategoryID"] = template.CategoryID;
            return View(template);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Template template)
        {
            if (id != template.TemplatesID)
            {
                return BadRequest();
            }

            var retainedCategory = await _context.Categories
                                                 .Where(itemCategory => itemCategory.CategoryID == template.CategoryID)
                                                 .FirstOrDefaultAsync();
            if (retainedCategory != null)
            {
                ViewData["CategoryID"] = retainedCategory.CategoryID;
                ViewData["CategoryName"] = retainedCategory.CategoryName;
            }
            ViewData["TemplateID"] = template.TemplatesID;


            if (string.IsNullOrEmpty(template.TemplateName))
            {
                ModelState.AddModelError("TemplateName", "Template Name is required.");
            }
            if (template.TemplateName?.Length < 3 || template.TemplateName?.Length > 50)
            {
                ModelState.AddModelError("TemplateName", "It is between 3 and 50 characters long.");
            }

            if (string.IsNullOrEmpty(template.Price.ToString()))
            {
                ModelState.AddModelError("Price", "Price is required.");
            }
            if (string.IsNullOrEmpty(template.Discount.ToString()))
            {
                ModelState.AddModelError("Discount", "Discount is required.");
            }
            if (template.Price < 0)
            {
                ModelState.AddModelError("Price", "Price cannot be less than 0.");
            }
            if (template.Discount < 0)
            {
                ModelState.AddModelError("Discount", "Discount cannot be less than 0.");
            }
            if (template.Discount >= template.Price)
            {
                ModelState.AddModelError("Discount", "Discount must be less than Price");
            }

            if (ModelState.IsValid)
            {
                var existingTemplate = await _context.Templates.FindAsync(id);
                if (existingTemplate == null)
                {
                    return NotFound();
                }

                existingTemplate.TemplateName = template.TemplateName;
                existingTemplate.Price = template.Price;
                existingTemplate.Discount = template.Discount;
                existingTemplate.Description = template.Description;

                _context.Update(existingTemplate);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index), new { id = template.CategoryID });
            }

            return View(template);
        }
    }
}



