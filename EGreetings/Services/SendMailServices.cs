using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using MimeKit;
using System.Net.Sockets;
//using MimeKit.TextPart;
using System.Security.Authentication;

namespace EGreetings.Services
{
    public class MailSettings
    {
        public string? Mail { get; set; }
        public string? DisplayName { get; set; }
        public string? Password { get; set; }
        public string? Host { get; set; }
        public int Port { get; set; }
    }

    public class EmailSenderService : IEmailSender
    {
        private readonly MailSettings mailSettings;
        private readonly ILogger<EmailSenderService> _logger;

        // Constructor dùng để inject cài đặt mail và logger
        public EmailSenderService(IOptions<MailSettings> mailSettings, ILogger<EmailSenderService> logger)
        {
            this.mailSettings = mailSettings.Value;
            _logger = logger;
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            if (string.IsNullOrEmpty(mailSettings.Mail) || string.IsNullOrEmpty(mailSettings.Password) ||
                string.IsNullOrEmpty(mailSettings.Host) || string.IsNullOrEmpty(mailSettings.DisplayName))
            {
                throw new InvalidOperationException("Mail settings are not properly configured.");
            }

            var message = new MimeMessage();
            message.Sender = new MailboxAddress(mailSettings.DisplayName, mailSettings.Mail);
            message.From.Add(new MailboxAddress(mailSettings.DisplayName, mailSettings.Mail));
            message.To.Add(MailboxAddress.Parse(email));
            message.Subject = subject;

            var builder = new BodyBuilder();
            builder.HtmlBody = htmlMessage;
            message.Body = builder.ToMessageBody();

            // Create the SMTP client and connect
            using var smtp = new SmtpClient();
            try
            {
                // Connect to the SMTP server
                await smtp.ConnectAsync(mailSettings.Host, mailSettings.Port, MailKit.Security.SecureSocketOptions.StartTls);
                await smtp.AuthenticateAsync(mailSettings.Mail, mailSettings.Password);
                await smtp.SendAsync(message);
                _logger.LogInformation("Email sent successfully to {Email}", email);
            }
            catch (AuthenticationException authEx)
            {
                _logger.LogError(authEx, "Authentication failed.");
            }
            catch (SocketException socketEx)
            {
                _logger.LogError(socketEx, "Network error occurred while sending email.");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while sending the email.");
                // Save email message to a file for debugging
                Directory.CreateDirectory("mailsave");
                var emailSaveFile = $"mailsave/{Guid.NewGuid()}.eml";
                await message.WriteToAsync(emailSaveFile);
            }
            finally
            {
                await smtp.DisconnectAsync(true);
                smtp.Dispose();
            }
        }

        public async Task SendEmailWithInlineFilesAsync(string email, string subject, string htmlMessage, Dictionary<string, byte[]> inlineFiles = null)
        {
            var message = new MimeMessage();
            message.Sender = new MailboxAddress("EGreetings", "your-email@example.com");
            message.From.Add(new MailboxAddress("EGreetings", "your-email@example.com"));
            message.To.Add(MailboxAddress.Parse(email));
            message.Subject = subject;

            var builder = new BodyBuilder();
            builder.HtmlBody = htmlMessage;

            // Nếu có tệp inline (hình ảnh, video), thêm chúng vào email
            if (inlineFiles != null && inlineFiles.Count > 0)
            {
                foreach (var file in inlineFiles)
                {
                    var part = new MimePart("application", "octet-stream")
                    {
                        Content = new MimeContent(new MemoryStream(file.Value)),
                        ContentDisposition = new ContentDisposition(ContentDisposition.Inline),
                        ContentTransferEncoding = MimeKit.ContentEncoding.Base64,
                        FileName = file.Key,
                        ContentId = file.Key // CID để tham chiếu từ HTML
                    };

                    builder.Attachments.Add(part);
                }
            }

            message.Body = builder.ToMessageBody();

            using var smtp = new SmtpClient();
            try
            {
                await smtp.ConnectAsync(mailSettings.Host, 587, MailKit.Security.SecureSocketOptions.StartTls);
                await smtp.AuthenticateAsync(mailSettings.Mail, mailSettings.Password);
                await smtp.SendAsync(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi khi gửi email: {ex.Message}");
            }
            finally
            {
                await smtp.DisconnectAsync(true);
                smtp.Dispose();
            }
        }

    }
}
