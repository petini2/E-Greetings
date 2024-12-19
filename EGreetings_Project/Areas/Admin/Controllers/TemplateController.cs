using EGreetings_Project.Data;
using EGreetings_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EGreetings_Project.Areas.Admin.Controllers
{
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
                                          .Where(itemTemplate => itemTemplate.CategoryId == id)
                                          .ToListAsync();

            var category = await _context.Categories
                                         .Where(itemCategory => itemCategory.CategoryId == id)
                                         .FirstOrDefaultAsync();
            if (category != null)
            {
                ViewData["CategoryName"] = category.CategoryName;
                ViewData["GroupCategory"] = category.GroupCate;
                ViewData["CategoryId"] = category.CategoryId;
            }
            return View(templates);
        }



        public IActionResult Create(int id)
        {
            var category = _context.Categories
                                   .Where(itemCategory => itemCategory.CategoryId == id)
                                   .FirstOrDefault();
            if (category != null)
            {
                ViewData["CategoryId"] = category.CategoryId;
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
                                                IFormFile imgVerFile, IFormFile imgHozFile,
                                                IFormFile svgVerFile, IFormFile svgHozFile)
        {
            var retainedCategory = await _context.Categories
                                           .Where(itemCategory => itemCategory.CategoryId == template.CategoryId)
                                           .FirstOrDefaultAsync();
            if (retainedCategory != null) {
              ViewData["CategoryId"] = retainedCategory.CategoryId;
              ViewData["CategoryName"] = retainedCategory.CategoryName;
              ViewData["GroupCategory"] = retainedCategory.GroupCate;
            }

            if (string.IsNullOrEmpty(template.TemplateName))
            {
                ModelState.AddModelError("TemplateName", "Template Name is required.");
            }
            if (template.TemplateName?.Length < 3 || template.TemplateName?.Length > 50) {
                ModelState.AddModelError("TemplateName", "It is between 3 and 50 characters long.");
            }

            if (string.IsNullOrEmpty(template.Price.ToString())) {
                ModelState.AddModelError("Price", "Price is required.");
            }
            if (string.IsNullOrEmpty(template.Discounts.ToString())) {
                ModelState.AddModelError("Discounts", "Discounts is required.");
            }           
            if (template.Price < 0) {
                ModelState.AddModelError("Price", "Price cannot be less than 0.");
            }
            if (template.Discounts < 0) {
                ModelState.AddModelError("Discounts", "Discounts cannot be less than 0.");
            }
            if (template.Discounts >= template.Price) {
                ModelState.AddModelError("Discounts", "Discounts must be less than Price");
            }

            if (imgVerFile == null || imgVerFile.Length == 0)
            {
                ModelState.AddModelError("imgVerFile", "Vertical image is required.");
            }
            if (imgHozFile == null || imgHozFile.Length == 0)
            {
                ModelState.AddModelError("imgHozFile", "Horizontal image is required.");
            }
            if (svgVerFile == null || svgVerFile.Length == 0)
            {
                ModelState.AddModelError("svgVerFile", "Vertical SVG is required.");
            }
            if (svgHozFile == null || svgHozFile.Length == 0)
            {
                ModelState.AddModelError("svgHozFile", "Horizontal SVG is required.");
            }

            if (imgVerFile != null && !IsValidImage(imgVerFile, "png"))
            {
                ModelState.AddModelError("imgVerFile", "Vertical image must be a PNG file.");
            }
            if (imgHozFile != null && !IsValidImage(imgHozFile, "png"))
            {
                ModelState.AddModelError("imgHozFile", "Horizontal image must be a PNG file.");
            }
            if (svgVerFile != null && !IsValidImage(svgVerFile, "svg"))
            {
                ModelState.AddModelError("svgVerFile", "Vertical SVG must be an SVG file.");
            }
            if (svgHozFile != null && !IsValidImage(svgHozFile, "svg"))
            {
                ModelState.AddModelError("svgHozFile", "Horizontal SVG must be an SVG file.");
            }

            if (ModelState.IsValid)
            {
                template.CreatedDate = DateTime.Now;

                string imageFolder = Path.Combine("wwwroot", "templates");
                template.ImgVer = await SaveFileAsync(imgVerFile, imageFolder);
                template.ImgHoz = await SaveFileAsync(imgHozFile, imageFolder);
                template.SvgVer = await SaveFileAsync(svgVerFile, imageFolder);
                template.SvgHoz = await SaveFileAsync(svgHozFile, imageFolder);

                _context.Add(template);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index), new { id = template.CategoryId });
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
                return "/templates/" + uniqueFileName;
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
            var template = await _context.Templates.FirstOrDefaultAsync(itemTemplate => itemTemplate.TemplateId == id);
            if (template == null)
            {
                return NotFound();
            }
            ViewData["CategoryName"] = categoryName;
            ViewData["CategoryId"] = template.CategoryId;
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
            ViewData["CategoryId"] = template.CategoryId;
            return View(template);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Template template)
        {
            if (id != template.TemplateId)
            {
                return BadRequest();
            }

            var retainedCategory = await _context.Categories
                                                 .Where(itemCategory => itemCategory.CategoryId == template.CategoryId)
                                                 .FirstOrDefaultAsync();
            if (retainedCategory != null) {
              ViewData["CategoryId"] = retainedCategory.CategoryId;
              ViewData["CategoryName"] = retainedCategory.CategoryName;
            }
            ViewData["TemplateId"] = template.TemplateId;


            if (string.IsNullOrEmpty(template.TemplateName))
            {
                ModelState.AddModelError("TemplateName", "Template Name is required.");
            }
            if (template.TemplateName?.Length < 3 || template.TemplateName?.Length > 50) {
                ModelState.AddModelError("TemplateName", "It is between 3 and 50 characters long.");
            }

            if (string.IsNullOrEmpty(template.Price.ToString())) {
                ModelState.AddModelError("Price", "Price is required.");
            }
            if (string.IsNullOrEmpty(template.Discounts.ToString())) {
                ModelState.AddModelError("Discounts", "Discounts is required.");
            }           
            if (template.Price < 0) {
                ModelState.AddModelError("Price", "Price cannot be less than 0.");
            }
            if (template.Discounts < 0) {
                ModelState.AddModelError("Discounts", "Discounts cannot be less than 0.");
            }
            if (template.Discounts >= template.Price) {
                ModelState.AddModelError("Discounts", "Discounts must be less than Price");
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
                existingTemplate.Discounts = template.Discounts;
                existingTemplate.Description = template.Description;

                _context.Update(existingTemplate);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index), new { id = template.CategoryId });
            }

            return View(template);
        }        
    }
}


