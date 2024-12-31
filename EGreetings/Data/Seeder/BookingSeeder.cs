using EGreetings.Models;

namespace EGreetings.Data.Seeder
{
    public class BookingSeeder
    {
        public static void Seed(EGreetingsDbContext dbContext)
        {
            //var booking = new Booking[]
            //{
            //    new Booking
            //    {
            //         UserID = "8dc296b8-93f7-4e33-a9a1-8feb2d8e21ae",
            //        TemplateID = 1,
            //        Subject = "Pending Booking",
            //        ReceivedEmail = null,
            //        BookingDate = DateTime.Parse("2024-12-20 18:40"),
            //        PriceTemplate = null,
            //        SubTotal = null,
            //        Discount = null,
            //        Total = 1000,
            //        Status = "Complete",
            //        CreatedDate = DateTime.Now,
            //        SubcribesSub = null
            //    }
            //};
            //dbContext.Bookings.AddRange(booking);

            // Lưu các thay đổi vào cơ sở dữ liệu
            //dbContext.SaveChanges();
            if (!dbContext.Bookings.Any()) // Nếu không có dữ liệu trong bảng Bookings, ta mới tiến hành seeding
            {
                //var existingBookings = dbContext.Bookings.ToList();
                //dbContext.Bookings.RemoveRange(existingBookings);
                // Dữ liệu mẫu cho bảng Bookings
                var bookings = new Booking[]
            {
                new Booking
                {
                    UserID = "028b357b-a576-4594-ae1f-526bb2d7bda6",
                    TemplateID = 1,
                    Subject = "Complete Booking with feedback",
                    ReceivedEmail = null,
                    BookingDate = DateTime.Parse("2024-12-20"),
                    PriceTemplate = null,
                    SubTotal = null,
                    Discount = null,
                    Total = 1000,
                    Status = "Complete",
                    CreatedDate = DateTime.Parse("2024-12-20"),
                    SubcribesSub = null
                },
                new Booking
                {
                    UserID = "028b357b-a576-4594-ae1f-526bb2d7bda6",
                    TemplateID = 1,
                    Subject = "Complete Booking with no feedback",
                    ReceivedEmail = null,
                    BookingDate = DateTime.Parse("2024-12-22"),
                    PriceTemplate = null,
                    SubTotal = null,
                    Discount = null,
                    Total = 1000,
                    Status = "Complete",
                    CreatedDate = DateTime.Parse("2024-12-20"),
                    SubcribesSub = null
                },
                new Booking
                {
                    UserID = "028b357b-a576-4594-ae1f-526bb2d7bda6",
                    TemplateID = 1,
                    Subject = "Complete Booking able feedback",
                    ReceivedEmail = null,
                    BookingDate = DateTime.Parse("2024-12-30"),
                    PriceTemplate = null,
                    SubTotal = null,
                    Discount = null,
                    Total = 1000,
                    Status = "Complete",
                    CreatedDate = DateTime.Parse("2024-12-22"),
                    SubcribesSub = null
                },
                new Booking
                {
                    UserID = "028b357b-a576-4594-ae1f-526bb2d7bda6",
                    TemplateID = 1,
                    Subject = "Pending Booking",
                    ReceivedEmail = null,
                    BookingDate = DateTime.Parse("2024-12-30 11:00"),
                    PriceTemplate = null,
                    SubTotal = null,
                    Discount = null,
                    Total = 1000,
                    Status = "Pending",
                    CreatedDate = DateTime.Parse("2024-12-30"),
                    SubcribesSub = null
                },
                new Booking
                {
                    UserID = "028b357b-a576-4594-ae1f-526bb2d7bda6",
                    TemplateID = 1,
                    Subject = "On Going Booking",
                    ReceivedEmail = null,
                    BookingDate = DateTime.Parse("2024-12-31"),
                    PriceTemplate = null,
                    SubTotal = null,
                    Discount = null,
                    Total = 1000,
                    Status = "OnGoing",
                    CreatedDate = DateTime.Parse("2024-12-30"),
                    SubcribesSub = null
                },
                new Booking
                {
                    UserID = "028b357b-a576-4594-ae1f-526bb2d7bda6",
                    TemplateID = 1,
                    Subject = "Fail Booking",
                    ReceivedEmail = null,
                    BookingDate = DateTime.Parse("2024-12-31"),
                    PriceTemplate = null,
                    SubTotal = null,
                    Discount = null,
                    Total = 1000,
                    Status = "Fail",
                    CreatedDate = DateTime.Parse("2024-12-30"),
                    SubcribesSub = null
                }
            };


                // Thêm các booking vào DbContext
                dbContext.Bookings.AddRange(bookings);

                // Lưu các thay đổi vào cơ sở dữ liệu
                dbContext.SaveChanges();
            }
        }
    }
}
