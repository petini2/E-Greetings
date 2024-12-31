using EGreetings.Data;

using EGreetings.Models.ViewModelAccount;
using Microsoft.AspNetCore.Mvc;
//var userIdCookie = HttpContext.Request.Cookies["UserID"];
namespace EGreetings.Controllers
{

    using EGreetings.Models;
    public class ECardController : Controller
    {
        
        private readonly EGreetingsDbContext db;
        private const int PageSize = 6;  // Số lượng items mỗi trang

        public ECardController(EGreetingsDbContext context)
        {
            db = context;
        }
        public IActionResult Index(string? priceFilter, string? searchQuery, List<int>? selectedCategories, List<string>? selectedGroupCategories, int page = 1)
        {
            // Retrieve your data source (e.g., from a database)
            var templates = db.Templates.AsQueryable();
            var categories = db.Categories.ToList(); // Fetch categories from the database
            templates = templates.Where(t => t.Status == true);
            // Apply price filter
            if (!string.IsNullOrEmpty(priceFilter))
            {
                switch (priceFilter)
                {
                    case "lowestToHighest":
                        // Apply discount if exists and sort by the price after discount
                        templates = templates.OrderBy(t => t.Price - (t.Discount ?? 0));
                        break;
                    case "highestToLowest":
                        // Apply discount if exists and sort by the price after discount (descending)
                        templates = templates.OrderByDescending(t => t.Price - (t.Discount ?? 0));
                        break;
                }
            }

            // Apply category filter
            if (selectedCategories != null && selectedCategories.Count > 0)
            {
                templates = templates.Where(t => selectedCategories.Contains(t.CategoryID));
            }

            // Apply group category filter
            if (selectedGroupCategories != null && selectedGroupCategories.Count > 0)
            {
                templates = templates.Where(t => selectedGroupCategories.Contains(t.Category.GroupCate)); // Adjust according to your model
            }

            // Apply search query
            if (!string.IsNullOrWhiteSpace(searchQuery))
            {
                templates = templates.Where(t => t.TemplateName.Contains(searchQuery));
            }

            // Ensure an OrderBy operation before pagination (required for Skip/Take)
            // If no price filter, apply default ordering
            if (string.IsNullOrEmpty(priceFilter))
            {
                templates = templates.OrderBy(t => t.TemplatesID);  // Use a default ordering (you can change this based on your requirements)
            }

            // Pagination logic
            int pageSize = 6; // Set page size to 6
            var totalTemplates = templates.Count(); // Count before pagination
            var paginatedTemplates = templates.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = (int)Math.Ceiling(totalTemplates / (double)pageSize);

            var model = new ECardViewModel
            {
                Templates = paginatedTemplates,
                Categories = categories,
                SearchQuery = searchQuery,
                SelectedCategories = selectedCategories ?? new List<int>(),
                SelectedGroupCategories = selectedGroupCategories ?? new List<string>(),
                PriceFilter = priceFilter,
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(totalTemplates / (double)pageSize)
            };

            return View("ECards", model);
        }



        public IActionResult ECardDesign( int templateId, string imgVer, string imgHoz, string orientation, string? userId)
        {
            //var userIdCookie = Request.Cookies["UserID"];
            var template = db.Templates
                             .Where(t => t.TemplatesID == templateId)
                             .FirstOrDefault();

            if (template == null)
            {
                // Nếu không tìm thấy template, trả về lỗi NotFound
                return NotFound("Template không tồn tại.");
            }
            ViewBag.Price = template.Price;
            ViewBag.Discount = template.Discount;
            ViewBag.UserID = userId;

            var viewModel = new ECardViewModel
            {
                TemplateID = templateId,
                Templates = new List<Template> { template },
                ImgVer = orientation == "Ver" ? imgVer : null,
                ImgHoz = orientation == "Hoz" ? imgHoz : null,
                SVGVer = orientation == "Ver" ? template.SvgVer : null,
                SVGHoz = orientation == "Hoz" ? template.SvgHoz : null
            };

            return View(viewModel);
        }

        //public IActionResult ECardDesign()
        //{
        //    return View();
        //}

        [HttpGet]
        public IActionResult GetTemplateDetails(int id)
        {
            var template = db.Templates
                             .Where(t => t.TemplatesID == id)
                             .FirstOrDefault();

            if (template == null)
            {
                return NotFound("Template không tồn tại.");
            }

            var templateDetails = new
            {
                id = template.TemplatesID,
                name = template.TemplateName,
                imgVer = template.ImgVer,
                imgHoz = template.ImgHoz
            };

            return Json(templateDetails);
        }


        // Action để xử lý khi người dùng xác nhận lựa chọn template
        [HttpGet]
        public IActionResult SubmitTemplate(int templateId, string imgVer, string imgHoz)
        {
            var template = db.Templates.FirstOrDefault(t => t.TemplatesID == templateId);
            ViewBag.Price = template.Price;
            ViewBag.Discount = template.Discount;

            return RedirectToAction("ECardDesign", "ECard", new { templateId = templateId, imgVer = imgVer, imgHoz = imgHoz });
        }

        public IActionResult FilterByPrice(string priceFilter, string searchQuery, int page = 1, int pageSize = 10)
        {
            // Lọc sản phẩm theo giá
            IQueryable<Template> filteredTemplates = db.Templates;

            // Áp dụng tìm kiếm nếu có
            if (!string.IsNullOrEmpty(searchQuery))
            {
                filteredTemplates = filteredTemplates.Where(t => t.TemplateName.Contains(searchQuery));
            }

            // Lọc theo giá
            if (priceFilter == "lowestToHighest")
            {
                filteredTemplates = filteredTemplates.OrderBy(t => t.Price); // Lọc giá từ thấp đến cao
            }
            else if (priceFilter == "highestToLowest")
            {
                filteredTemplates = filteredTemplates.OrderByDescending(t => t.Price); // Lọc giá từ cao đến thấp
            }

            // Lấy tổng số sản phẩm sau khi lọc
            int totalCount = filteredTemplates.Count();

            // Phân trang
            var templatesForPage = filteredTemplates
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            // Lấy danh sách các categories
            var categories = db.Categories.ToList();

            // Tạo ViewModel
            var viewModel = new ECardViewModel
            {
                Categories = categories,
                Templates = templatesForPage,
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize), // Tính số trang
                SearchQuery = searchQuery,
                PriceFilter = priceFilter
            };

            // Trả về view với ViewModel
            return View("ECards", viewModel);
        }

        [HttpPost]
        public IActionResult SendToBooking(priceInfo priceData, int templateId)
        {
            if (priceData == null)
            {
                return NotFound("Không tìm được thông tin của card !");
            }
            priceData.TemplateId = templateId;
            return RedirectToAction("Booking", "Booking", priceData);
        }

    }

}

