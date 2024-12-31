using Microsoft.AspNetCore.Mvc;

namespace EGreetings.Controllers
{
    public class PaymentController : Controller
    {

        private string _ClientId { get; set; } = "";
        private string _Secret { get; set; } = "";
        private string _BaseUrl { get; set; } = "";


        public PaymentController(IConfiguration configuration)
        {
            _ClientId = configuration["PaypalSandbox:ClientId"] ?? "";
            _Secret = configuration["PaypalSandbox:Secret"] ?? "";
            _BaseUrl = configuration["PaypalSandbox:BaseUrl"] ?? "";
        }

        public IActionResult Index()
        {
            ViewBag.ClientId = _ClientId;
            return View();
        }
        public IActionResult ShowPayment(priceInfo priceInfo)
        {
            if (priceInfo == null)
            {
                return NotFound("Not found the card !");
            }

            priceInfo.BillTotal = priceInfo.PriceTemplate + priceInfo.SendingFee - priceInfo.SubFree - priceInfo.Discount;
            ViewBag.ClientId = _ClientId;
            return View(priceInfo);
        }

        public IActionResult PaypalMethods()
        {
            return View();
        }

        public IActionResult Confirmation()
        {
            return View();
        }

        public IActionResult Failed()
        {
            return View();
        }

        public IActionResult Verification()
        {
            return View();
        }


    }

    public class priceInfo
    {
        public int? TemplateId { get; set; }
        public string? UserID { get; set; }
        public decimal PriceTemplate { get; set; }
        public decimal SendingFee { get; set; }
        public decimal SubFree { get; set; }
        public decimal Discount { get; set; }
        public decimal BillTotal { get; set; }
        public string? TemplateHistorySvgUrl { get; set; }
        public string? VideoUrl { get; set; }
    }
}
