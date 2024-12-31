using EGreetings.Models.ViewModelAccount;
using Hangfire;

namespace EGreetings.Services
{
    public class EmailJobServices
    {
        private readonly EmailSenderService _emailSenderService;
        private readonly IEmailRepository _emailRepository;
        private readonly IBackgroundJobClient _backgroundJobClient;
        private readonly ILogger<EmailJobServices> _logger;

        public EmailJobServices(
            EmailSenderService emailSenderService,
            IEmailRepository emailRepository,
            IBackgroundJobClient backgroundJobClient,
            ILogger<EmailJobServices> logger)
        {
            _emailSenderService = emailSenderService;
            _emailRepository = emailRepository;
            _backgroundJobClient = backgroundJobClient;
            _logger = logger;
        }

        // Kiểm tra và lên lịch gửi email
        public async Task CheckAndScheduleEmails()
        {
            var emailsToSend = await _emailRepository.GetEmailsForTodayAsync(); // Lấy danh sách email cần gửi hôm nay

            foreach (var email in emailsToSend)
            {
                if (email.SendDateTime > DateTime.Now)
                {
                    var delayUntil = email.SendDateTime - DateTime.Now;

                    if (delayUntil > TimeSpan.Zero)
                    {
                        // Lên lịch gửi email sau khoảng thời gian delay
                        ScheduleEmailForSend(email, delayUntil.Value);
                    }
                }
                else
                {
                    _logger.LogWarning("Email đã quá hạn gửi: {EmailSubject}", email.Subject);
                }
            }
        }

        // Phương thức gửi email thông qua Hangfire
        private void ScheduleEmailForSend(Email email, TimeSpan delayUntil)
        {
            _backgroundJobClient.Schedule(() => SendEmailAsyncForHangfire(email), delayUntil);
        }

        // Phương thức bất đồng bộ gửi email trong Hangfire
        public async Task SendEmailAsyncForHangfire(Email email)
        {
            await _emailSenderService.SendEmailAsync(email.ToEmail, email.Subject, email.Body);
        }

        // Dữ liệu mẫu với thông tin email cứng
        public async Task SendEmailWithHardcodedData()
        {
            var email = new Email
            {
                ToEmail = "ttntraam0101@gmail.com",
                Subject = "Welcome to EGreetings",
                Body = "Hello, this is a test email!",
                SendDateTime = DateTime.Now.AddMinutes(1)  // Đặt thời gian gửi email 1 phút sau
            };

            if (email.SendDateTime > DateTime.Now)
            {
                var delayUntil = email.SendDateTime - DateTime.Now;

                if (delayUntil > TimeSpan.Zero)
                {
                    // Lên lịch gửi email sau khoảng thời gian delay
                    ScheduleEmailWithInlineFilesForSend(email, delayUntil.Value);
                }
            }
            else
            {
                _logger.LogWarning("Dữ liệu email mẫu đã qua hạn gửi: {EmailSubject}", email.Subject);
            }
        }

        // Lên lịch gửi email với inline files
        private void ScheduleEmailWithInlineFilesForSend(Email email, TimeSpan delayUntil)
        {
            _backgroundJobClient.Schedule(() => SendEmailWithInlineFilesForHangfire(email), delayUntil);
        }

        // Phương thức gửi email với inline files (dữ liệu inline như hình ảnh/video)
        public async Task SendEmailWithInlineFilesForHangfire(Email email)
        {
            var inlineFiles = await GetInlineFiles();
            await _emailSenderService.SendEmailWithInlineFilesAsync(email.ToEmail, email.Subject, GetHtmlBody(email), inlineFiles);
        }

        // Phương thức trả về HTML body với CID cho ảnh và video
        // Phương thức trả về HTML body với CID cho ảnh và video
        private string GetHtmlBody(Email email)
        {
            return $@"
        <html>
        <head>
            <style>
                body {{
                    font-family: Arial, sans-serif;
                }}
                h1 {{
                    color: #333;
                }}
            </style>
        </head>
        <body>
            <h1>Dear</h1>
            <p>This is the e-card that James send you to celerate Chrismast Holiday/p
        <p>Happy day!!</p>
            <img src='https://egreetings.blob.core.windows.net/templateimg/Fes_Christmas_SD1.png' alt='Inline Image' style='width: 100%; max-width: 600px;' />
            <p>Video mẫu:</p>
            <video width='320' height='240' controls>
                <source src='https://egreetings.blob.core.windows.net/videourl/funnyclip.mp4' type='video/mp4'>
            </video>
        </body>
        </html>";
        }


        // Lấy các tệp inline (hình ảnh/video) từ các URL hoặc tệp cục bộ
        private async Task<Dictionary<string, byte[]>> GetInlineFiles()
        {
            var inlineFiles = new Dictionary<string, byte[]>();

            try
            {
                // Tải hình ảnh SVG
                string imageUrl = "https://egreetings.blob.core.windows.net/templatesvg/Fes_Christmas_SD1.svg";
                var imageBytes = await DownloadFileAsync(imageUrl);
                if (imageBytes != null)
                {
                    inlineFiles.Add("image1", imageBytes);  // "image1" là Content-ID
                }
                else
                {
                    _logger.LogWarning("Không thể tải hình ảnh từ URL: " + imageUrl);
                }

                // Tải video MP4
                string videoUrl = "https://egreetings.blob.core.windows.net/videourl/funnyclip.mp4";
                var videoBytes = await DownloadFileAsync(videoUrl);
                if (videoBytes != null)
                {
                    inlineFiles.Add("video1", videoBytes);  // "video1" là Content-ID
                }
                else
                {
                    _logger.LogWarning("Không thể tải video từ URL: " + videoUrl);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Đã xảy ra lỗi khi tải các tệp inline.");
            }

            return inlineFiles;
        }

        // Phương thức tải tệp từ URL (hoặc từ hệ thống tệp cục bộ)
        private async Task<byte[]> DownloadFileAsync(string url)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        return await response.Content.ReadAsByteArrayAsync();
                    }
                    else
                    {
                        _logger.LogWarning($"Lỗi tải file từ URL {url}: {response.StatusCode}");
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Đã xảy ra lỗi khi tải file từ URL.");
                return null;
            }
        }
    }
}




// Phương thức kiểm tra và lên lịch gửi email
//public async Task CheckAndScheduleEmails()
//{
//    // 1. Lấy danh sách các email cần gửi trong ngày
//    var emailsToSend = await _emailRepository.GetEmailsForTodayAsync();

//    foreach (var email in emailsToSend)
//    {
//        // 2. Kiểm tra ngày và giờ gửi email
//        var sendTime = email.SendDateTime;  // Thời gian mà client muốn gửi (9:00, 15:00, v.v.)

//        // Kiểm tra nếu thời gian gửi đã qua
//        if (sendTime > DateTime.Now)
//        {
//            // 3. Tính toán khoảng thời gian delayUntil
//            var delayUntil = sendTime - DateTime.Now;

//            // Đảm bảo delayUntil là kiểu TimeSpan không nullable
//            if (delayUntil.HasValue && delayUntil.Value > TimeSpan.Zero)
//            {
//                // Lên lịch gửi email sau khoảng thời gian delay
//                _backgroundJobClient.Schedule(
//                    () => _emailSenderService.SendEmailAsync(email.ToEmail, email.Subject, email.Body),
//                    delayUntil.Value  // Lên lịch gửi email sau `delayUntil`
//                );
//            }
//        }
//    }
//}
// Để gửi email ngay lập tức, thay vì lập lịch định kỳ, bạn có thể enqueue một job ngay lập tức:




