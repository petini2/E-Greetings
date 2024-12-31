using EGreetings.Data;
using EGreetings.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace EGreetings.Controllers
{
    public class BookingController : Controller
    {
        private string connectionString = "Server=tcp:egreetingsdbserver.database.windows.net,1433;Initial Catalog=EGreetings;Persist Security Info=False;User ID=sadmin;Password=EGreetings2024;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        private readonly EGreetingsDbContext _context;

        //public BookingController(string connectionString, EGreetingsDbContext context)
        //{
        //    this.connectionString = connectionString;
        //    _context = context;
        //}
        public BookingController(EGreetingsDbContext context)
        {
            _context = context;
        }

        public void GetDatabase(string UserID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Lấy SubscriptionID từ bảng Subscriptions
                SqlCommand command = new SqlCommand("SELECT SubscriptionID FROM [dbo].[Subscriptions] WHERE SubCate = 'Sends'", connection);
                SqlDataReader reader = command.ExecuteReader();

                List<int> subscriptionIds = new List<int>();

                // Đọc SubscriptionID
                while (reader.Read())
                {
                    subscriptionIds.Add(reader.GetInt32(0)); // Giả sử SubscriptionID là kiểu int
                }
                reader.Close(); // Đóng SqlDataReader sau khi đọc xong

                // Gán giá trị mặc định cho Quantity
                ViewBag.Quantity10 = 0;
                ViewBag.Quantity15 = 0;
                ViewBag.Quantity20 = 0;

                // Nếu có SubscriptionID, tìm Quantity trong bảng UserSubs
                if (subscriptionIds.Count > 0)
                {
                    // Chuyển danh sách SubscriptionID thành chuỗi
                    string subscriptionIdList = string.Join(",", subscriptionIds);
                    SqlCommand quantityCommand = new SqlCommand($"SELECT SubscriptionID, Quantity FROM [dbo].[UserSubs] WHERE UserID = @UserID AND SubscriptionID IN ({subscriptionIdList})", connection);
                    quantityCommand.Parameters.AddWithValue("@UserID", UserID); // Sử dụng tham số để bảo mật

                    SqlDataReader quantityReader = quantityCommand.ExecuteReader();

                    // Đọc và xử lý Quantity
                    while (quantityReader.Read())
                    {
                        int subscriptionID = quantityReader.GetInt32(0); // SubscriptionID
                        int quantity = quantityReader.GetInt32(1); // Quantity

                        // Gán giá trị vào ViewBag theo SubscriptionID
                        switch (subscriptionID)
                        {
                            case 10:
                                ViewBag.Quantity10 = quantity;
                                break;
                            case 11:
                                ViewBag.Quantity15 = quantity;
                                break;
                            case 12:
                                ViewBag.Quantity20 = quantity;
                                break;
                        }
                    }
                }

                // In ra để kiểm tra (nếu cần)
                Console.WriteLine($"Quantity10: {ViewBag.Quantity10}");
                Console.WriteLine($"Quantity15: {ViewBag.Quantity15}");
                Console.WriteLine($"Quantity20: {ViewBag.Quantity20}");
            }
        }

        public IActionResult Booking(priceInfo priceData)
        {
            if (priceData == null)
            {
                return NotFound("Không tìm được thông tin của card !");
            }
            if (priceData.UserID == null)
            {
                return NotFound("Không tìm được thông tin của user !");
            }
            GetDatabase(priceData.UserID);

            return View(priceData);
        }
        public IActionResult PaymentDetails()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Send(priceInfo model)
        //{
        //    if (model == null)
        //    {
        //        return NotFound("Không tìm được thông tin của card !");
        //    }
        //    model.BillTotal = model.PriceTemplate + model.SendingFee - model.SubFree - model.Discount;
        //    return RedirectToAction("ShowPayment", "Payment", model);
        //    //return View("ShowPayment", model); // Trả về view payment với dữ liệu mới
        //}
        [HttpPost]
        public async Task<IActionResult> Send(priceInfo model, int templateId)
        {
            if (model == null)
            {
                return NotFound("Không tìm được thông tin của card !");
            }
            model.TemplateId = templateId;
            model.UserID = Request.Cookies["UserID"];
            model.BillTotal = model.PriceTemplate + model.SendingFee - model.SubFree - model.Discount;


            Booking itemBooking = new Booking
            {
                UserID = Request.Cookies["UserID"],
                TemplateID = templateId,
                Subject = "Send you a nice gift!",
                ReceivedEmail = "xxx.xxx@gmail.com",
                BookingDate = DateTime.MinValue,
                PriceTemplate = (float)model.PriceTemplate,
                SubTotal = (float)model.SendingFee,
                Discount = (float)model.Discount,
                Total = (float)model.BillTotal,
                Status = "OnGoing",
                CreatedDate = DateTime.Now,
                SubcribesSub = (float)model.SubFree,
            };
            _context.Add(itemBooking); await _context.SaveChangesAsync();
            var bookingId = itemBooking.BookingID;
            var itemBookingFromDb = await _context.Bookings.FindAsync(bookingId);

            TemplateHistory itemTemplateHistory = new TemplateHistory
            {
                TemplateID = templateId,
                BookingID = bookingId,
                SvgUrl = model.TemplateHistorySvgUrl,
                VideoUrl = model.VideoUrl,
                TemplateStatus = true,
                CreatedDate = DateTime.Now
            };
            _context.Add(itemTemplateHistory); await _context.SaveChangesAsync();


            EGreetings.Models.Transaction itemTransaction = new EGreetings.Models.Transaction
            {
                UserID = Request.Cookies["UserID"],
                BookingID = bookingId,
                Amount = (float)model.BillTotal,
                TransactionDate = DateTime.Now,
                TransactionMethods = "paypal",
                TransactionStatus = "Pending",
                CreatedDate = DateTime.Now
            };
            _context.Add(itemTransaction); await _context.SaveChangesAsync();


            // TempData["ItemBooking"] = JsonConvert.SerializeObject(itemBooking);
            // TempData["ItemTemplateHistory"] = JsonConvert.SerializeObject(itemTemplateHistory);

            return RedirectToAction("ShowPayment", "Payment", model);
            //return View("ShowPayment", model); // Trả về view payment với dữ liệu mới
        }

        [HttpPost]
        public IActionResult UpdateQuantities(int userID, int quan10, int quan15, int quan20)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Cập nhật giá trị Quantity trong bảng UserSubs
                string updateQuery = @"
            UPDATE [dbo].[UserSubs]
            SET Quantity = CASE 
                WHEN SubscriptionID = 10 THEN @Quan10 
                WHEN SubscriptionID = 11 THEN @Quan15 
                WHEN SubscriptionID = 12 THEN @Quan20 
            END
            WHERE UserID = @UserID AND SubscriptionID IN (10, 11, 12)";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@Quan10", quan10);
                    command.Parameters.AddWithValue("@Quan15", quan15);
                    command.Parameters.AddWithValue("@Quan20", quan20);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Cập nhật thành công
                        return RedirectToAction("Success"); // Chuyển hướng đến trang thành công
                    }
                    else
                    {
                        // Không tìm thấy người dùng hoặc không có thay đổi nào
                        return NotFound("Không tìm thấy thông tin cần cập nhật.");
                    }
                }
            }
        }
    }

}
