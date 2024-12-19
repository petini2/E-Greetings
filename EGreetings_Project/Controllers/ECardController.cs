using EGreetings_Project.Data;
using EGreetings_Project.Models;
using EGreetings_Project.Models.ViewModelAccount;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EGreetings_Project.Controllers
{
    public class ECardController : Controller
    {
        private readonly EGreetingsDbContext db;
        private const int PageSize = 6;  // Số lượng items mỗi trang

        public ECardController(EGreetingsDbContext context)
        {
            db = context;
        }

        public IActionResult Index(int page = 1)
        {
            // Lấy tất cả các categories có Status là true
            var categories = db.Categories.Where(c => c.Status).ToList();

            // Lấy tổng số lượng Templates có Status là true
            var totalTemplates = db.Templates.Where(t => t.Status).Count();

            // Tính tổng số trang
            var totalPages = (int)Math.Ceiling(totalTemplates / (double)PageSize);

            // Lấy các template cho trang hiện tại
            var templates = db.Templates
                .Where(t => t.Status)
                .OrderByDescending(t => t.CreatedDate)  // Sắp xếp theo ngày tạo
                .Skip((page - 1) * PageSize)  // Bỏ qua các items trước đó
                .Take(PageSize)  // Lấy PageSize items
                .ToList();

            // Tạo ViewModel với thông tin phân trang
            var viewModel = new ECardViewModel
            {
                Categories = categories,
                Templates = templates,
                CurrentPage = page,
                TotalPages = totalPages
            };

            return View("ECards", viewModel);  // Trả về View với ViewModel chứa dữ liệu
        }

        public IActionResult ECardDesign(int templateId, string imgVer, string imgHoz, string orientation)
        {
            // Lấy template dựa trên ID
            var template = db.Templates
                             .Where(t => t.TemplatesID == templateId)
                             .FirstOrDefault();

            if (template == null)
            {
                return NotFound();
            }

            // Tạo ViewModel cho trang thiết kế
            var viewModel = new ECardViewModel
            {
                Templates = new List<Template> { template },
                ImgVer = orientation == "Ver" ? imgVer : null,  // Chọn hình ảnh Vertical nếu orientation là "Ver"
                ImgHoz = orientation == "Hoz" ? imgHoz : null   // Chọn hình ảnh Horizontal nếu orientation là "Hoz"
            };

            return View(viewModel);  // Trả về View với thông tin template và ảnh đã chọn
        }

        [HttpGet]
        public IActionResult GetTemplateDetails(int id)
        {
            var template = db.Templates
                             .Where(t => t.TemplatesID == id)
                             .FirstOrDefault();

            if (template == null)
            {
                return NotFound();
            }

            // Trả về thông tin template dưới dạng JSON
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
            // Lưu thông tin template hoặc xử lý theo yêu cầu
            // Ví dụ: Lưu vào database, ghi vào session, v.v.

            // Chuyển hướng đến trang thiết kế với template đã chọn
            return RedirectToAction("ECardDesign", "ECard", new { templateId = templateId, imgVer = imgVer, imgHoz = imgHoz });
        }
    }
}
