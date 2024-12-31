using EGreetings.Models;

namespace EGreetings.Data.Seeder
{
    public class TemplateHistorySeeder
    {
        private readonly EGreetingsDbContext _context;

        // Constructor nhận vào DbContext để có thể truy cập cơ sở dữ liệu
        public TemplateHistorySeeder(EGreetingsDbContext context)
        {
            _context = context;
        }

        // Phương thức để thêm dữ liệu mẫu vào bảng TemplateHistory
        public async Task Seed()
        {
            if (!_context.TemplateHistories.Any())
            {
                // Tạo các đối tượng TemplateHistory
                var templateHistory = new TemplateHistory
                {
                    TemplateID = 1,
                    BookingID = 38,
                    SvgUrl = "Fes_Christmas_SD1.svg",  // Đảm bảo rằng bạn có giá trị hợp lệ cho SvgUrl nếu cần
                    VideoUrl = "", // Đảm bảo rằng bạn có giá trị hợp lệ cho VideoUrl nếu cần
                };

                // Thêm đối tượng vào DbContext
                await _context.TemplateHistories.AddAsync(templateHistory);

                // Lưu thay đổi vào cơ sở dữ liệu
                await _context.SaveChangesAsync();
            }
        }
    }
}
