using Hangfire;
using System.Linq.Expressions;

namespace EGreetings.Services
{
    public class HangfireJobConfiguration
    {
        private readonly IRecurringJobManager _recurringJobManager;

        public HangfireJobConfiguration(IRecurringJobManager recurringJobManager)
        {
            _recurringJobManager = recurringJobManager;
        }

        public void ConfigureRecurringJobs()
        {
            // Biểu thức lambda cho phương thức cần gọi
            Expression<Action<EmailJobServices>> methodCall = job => job.SendEmailWithHardcodedData();

            // Tạo RecurringJobOptions với múi giờ cụ thể
            var options = new RecurringJobOptions
            {
                TimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time") // Múi giờ Việt Nam
                //TimeZone=TimeZoneInfo.Local
            };

            // Lên lịch công việc chạy mỗi ngày vào lúc 4:05 AM (giờ Việt Nam)
            _recurringJobManager.AddOrUpdate(
                "SendEmailWithHardcodedData",  // Job identifier (unique name)
                methodCall,  // Sử dụng biểu thức lambda (Expression<Action<T>>)
                "0 0 * * *", // Cron expression chạy vào lúc 4:05 AM mỗi ngày
                options // Thêm RecurringJobOptions tại đây
            );
        }
    }
}
