using EGreetings.Models;

namespace EGreetings.Data.Seeder
{
    public class BookingDetailsSeeder
    {
        private readonly EGreetingsDbContext _context;

        // Constructor nhận vào DbContext để có thể truy cập cơ sở dữ liệu
        public BookingDetailsSeeder(EGreetingsDbContext context)
        {
            _context = context;
        }

        // Phương thức để thêm dữ liệu mẫu vào bảng BookingDetails
        public async Task Seed()
        {
            // Kiểm tra xem bảng BookingDetails có dữ liệu hay không
            if (!_context.BookingDetails.Any())
            {
                // Tạo các đối tượng BookingDetail
                var bookingDetails = new BookingDetail[]
                {
                    new BookingDetail
                    {
                        BookingID = 38, // ID của Booking có sẵn trong cơ sở dữ liệu
                        RecipientEmail = "ttntraam0101@gmail.com",
                        RecipientName = "Tram",
                        CreatedDate = DateTime.UtcNow
                    }
                };

                // Thêm các đối tượng vào DbContext
                await _context.BookingDetails.AddRangeAsync(bookingDetails);

                // Lưu thay đổi vào cơ sở dữ liệu
                await _context.SaveChangesAsync();
            }
        }
    }
}
