using Microsoft.AspNetCore.Mvc;
using EGreetings_Project.Data;
using EGreetings_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace EGreetings_Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SlideshowController : Controller
    {
        private readonly EGreetingsDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public SlideshowController(EGreetingsDbContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
        }
      
        public async Task<IActionResult> Index()
        {
            var sliders = await _context.Sliders.ToListAsync();

            return View(sliders);
        }
 


        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slider slider, IFormFile svgImage)
        {
            if (string.IsNullOrEmpty(slider.SliderTitle))
            {
                ModelState.AddModelError("SliderTitle", "Slider Title is required.");
            }
            if (slider.SliderTitle?.Length < 3 || slider.SliderTitle?.Length > 50) {
                ModelState.AddModelError("SliderTitle", "It is between 3 and 50 characters long.");
            }

            if (string.IsNullOrEmpty(slider.SliderContent))
            {
                ModelState.AddModelError("SliderContent", "SliderContent is required.");
            }
            if (slider.SliderContent?.Length < 3 || slider.SliderContent?.Length > 50) {
                ModelState.AddModelError("SliderContent", "It is between 3 and 50 characters long.");
            }            

            if (svgImage == null || svgImage.Length == 0)
            {
                ModelState.AddModelError("svgImage", "Svg image is required.");
            }
              
            if (svgImage != null && !IsValidImage(svgImage, "svg"))
            {
                ModelState.AddModelError("svgImage", "Image must be an SVG file.");
            }
 
            if (ModelState.IsValid)
            {
                string imageFolder = Path.Combine("wwwroot", "sliders");
                slider.SliderImage = await SaveFileAsync(svgImage, imageFolder);

                _context.Add(slider);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(slider);
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
                return "/sliders/" + uniqueFileName;
            }
            return null;
        }



        public async Task<IActionResult> Detail(int id)
        {
            var slider = await _context.Sliders.FirstOrDefaultAsync(itemSlider => itemSlider.SliderId == id);
            if (slider == null)
            {
                return NotFound();
            }
            return View(slider);
        }



        [HttpPost]
        public async Task<IActionResult> UpdateStatus(int sliderId, bool status)
        {
            var slider = await _context.Sliders.FindAsync(sliderId);
            if (slider != null)
            {
                slider.IsActive = status;
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

    }
}


