using EGreetings.Data;

using EGreetings.Models.ViewModelAccount;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EGreetings.Controllers
{
    using EGreetings.Models;
    public class SubsController : Controller
    {
        private readonly EGreetingsDbContext _context;
        //private const int PageSize = 6;
        private readonly ILogger<SubsController> _logger;

        public SubsController(EGreetingsDbContext context, ILogger<SubsController> logger)
        {
            _context = context;
            _logger = logger;
        }

        //public SubsController(EGreetingsDbContext context)
        //{
        //    _context = context;
        //}

        public IActionResult Index()
        {

            var subscriptions = _context.Subscriptions.ToList();

            return View("Subs", subscriptions);
        }
        public IActionResult SubMonth(string searchQuery, int page = 1, int pageSize = 6)
        {
            //Get UserID from Cookie
            string userId = Request.Cookies["UserID"];
            if (userId != null)
            {
                // Fetch categories only once
                var categories = _context.Categories.Where(c => c.Status).ToList();

                // Start with the base query for templates
                var templatesQuery = _context.Templates.Where(t => t.Status);

                // If searchQuery is provided, apply the filter
                if (!string.IsNullOrEmpty(searchQuery))
                {
                    templatesQuery = templatesQuery.Where(t => t.TemplateName.ToLower().Contains(searchQuery.ToLower()));
                }

                // Get the total number of templates matching the filters
                var totalTemplates = templatesQuery.Count();

                // Calculate the total number of pages
                var totalPages = (int)Math.Ceiling(totalTemplates / (double)pageSize);

                // Apply sorting, pagination, and fetch the results
                var templates = templatesQuery
                    .OrderByDescending(t => t.CreatedDate)  // Ensure templates are ordered by created date
                    .Skip((page - 1) * pageSize)            // Skip the templates for the previous pages
                    .Take(pageSize)                         // Take the number of templates as per the page size
                    .ToList();

                // Create the ViewModel with necessary information
                var viewModel = new ECardViewModel
                {
                    Categories = categories,
                    Templates = templates,
                    CurrentPage = page,
                    TotalPages = totalPages,
                    SearchQuery = searchQuery // Pass the search query to the ViewModel
                };

                // Return the view with the ViewModel
                return View(viewModel);
            }
            else
            {
                // Ask to login page
                return RedirectToAction("Login", "Account");
            }
        }


        [HttpPost]
        public IActionResult NextPage(string selectedTemplates)
        {
            if (string.IsNullOrEmpty(selectedTemplates))
            {
                return RedirectToAction("Index");
            }

            _logger.LogInformation($"Selected templates JSON: {selectedTemplates}");

            // Deserialize the selected templates into a list of Template objects
            var templatesList = JsonConvert.DeserializeObject<List<SmallTemplate>>(selectedTemplates);

            // Kiểm tra xem templatesList có hợp lệ không
            if (templatesList == null || !templatesList.Any())
            {
                _logger.LogWarning("No valid templates found in selectedTemplates.");
                return RedirectToAction("Index");
            }

            // Lưu vào session
            HttpContext.Session.SetString("SelectedTemplates", JsonConvert.SerializeObject(templatesList));

            return RedirectToAction("NextPageView");
        }
        public IActionResult NextPageView()
        {
            var selectedTemplatesJson = HttpContext.Session.GetString("SelectedTemplates");

            if (string.IsNullOrEmpty(selectedTemplatesJson))
            {
                _logger.LogWarning("No selected templates found in session.");
                return RedirectToAction("Index");
            }

            // Deserialize JSON trở lại thành List<Template>
            var selectedTemplates = JsonConvert.DeserializeObject<List<SmallTemplate>>(selectedTemplatesJson);

            // Ghi log thông tin của các mẫu
            foreach (var template in selectedTemplates)
            {
                _logger.LogInformation($"Template ID: {template.id}, Template Name: {template.TemplateName}");
            }

            // Pass the selected templates to the view
            return View(selectedTemplates);
        }

        public IActionResult SubFillMail()
        {
            return View();
        }

        public IActionResult SubTemplate(string groupCate)
        {
            if (string.IsNullOrEmpty(groupCate))
            {
                return RedirectToAction("Subs", "Subs");
            }

            Console.WriteLine($"groupCate: {groupCate}"); // Print or log for debugging

            var templates = _context.Templates
                .Where(t => t.Status && t.Category.GroupCate == groupCate)
                .Take(10)  // Only get the first 10 templates
                .Select(t => new TemplateInfo
                {
                    TemplateName = t.TemplateName,
                    ImgVer = t.ImgVer
                })
                .ToList();

            if (templates.Count == 0)
            {
                Console.WriteLine("No templates found for this category.");
            }

            var viewModel = new SubTemplateViewModel
            {
                Templates = templates
            };

            return View(viewModel);
        }
        public async Task<IActionResult> SendTime(int id)
        {
            //Get UserID from Cookie
            string userId = Request.Cookies["UserID"];
            if (userId != null)
            {
                // Retrieve the selected templates from session
                HttpContext.Session.SetInt32("SubId", id);
                //Return to payment page
                return RedirectToAction("Index", "Payment");
            }
            return RedirectToAction("Login", "Account");
        }
    }
}
