using EGreetings.Models.ViewModelAccount;

namespace EGreetings.Services
{
    public interface IEmailRepository
    {
        Task<IEnumerable<Email>> GetEmailsForTodayAsync();  // Lấy tất cả email cần gửi trong ngày
        Task MarkAsSentAsync(int bookingID);                  // Đánh dấu email đã được gửi
    }

}
