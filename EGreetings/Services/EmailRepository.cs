using EGreetings.Data;
using EGreetings.Models.ViewModelAccount;
using EGreetings.Services;
using Microsoft.EntityFrameworkCore;

public class EmailRepository : IEmailRepository
{
    private readonly EGreetingsDbContext _context;

    public EmailRepository(EGreetingsDbContext context)
    {
        _context = context;
    }

    // Lấy tất cả email cần gửi trong ngày
    public async Task<IEnumerable<Email>> GetEmailsForTodayAsync()
    {
        var today = DateTime.Today;

        // Lấy tất cả các email cần gửi trong ngày từ bảng BookingDetails và TemplateHistory
        var emailsToSend = await _context.BookingDetails
            .Where(bd => bd.Booking.BookingDate == today && bd.Booking.Status == "Pending")
            .Join(
                _context.TemplateHistories,     // Liên kết với bảng TemplateHistory
                bd => bd.BookingID,            // Khóa ngoại TemplateId trong bảng BookingDetails
                th => th.VersionID,            // Khóa chính TemplateId trong bảng TemplateHistory
                (bd, th) => new
                {
                    bd.RecipientEmail,
                    bd.RecipientName,
                    th.SvgUrl,
                    th.VideoUrl,
                    bd.Booking.BookingDate
                })
            .ToListAsync();

        return emailsToSend.Select(x => new Email
        {
            ToEmail = x.RecipientEmail,    // Địa chỉ email người nhận
            Subject = x.RecipientName,     // Tiêu đề email
            Body = "Hello",                // Nội dung email, có thể cập nhật theo yêu cầu
            SvgUrl = x.SvgUrl,            // URL của SVG từ TemplateHistory
            VideoUrl = x.VideoUrl,        // URL của Video từ TemplateHistory
            SendDateTime = DateTime.Now.AddMinutes(1), // Thời gian gửi, có thể chỉnh theo logic của bạn
        }).ToList();
    }

    // Đánh dấu email là đã được gửi
    public async Task MarkAsSentAsync(int bookingId)
    {
        // Tìm BookingDetail theo ID
        var emailDetail = await _context.Bookings.FindAsync(bookingId);
        if (emailDetail != null)
        {
            // Đánh dấu email đã được gửi
            emailDetail.Status = "Complete";

            // Cập nhật trạng thái trong bảng BookingDetails
            _context.Bookings.Update(emailDetail);
            await _context.SaveChangesAsync();
        }
    }


}
