
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using MimeKit;
using System.Security.Authentication;

namespace EGreetings_Project.Services
{
    public class SendMailServices
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
            readonly MailSettings mailSettings;
            private readonly ILogger<EmailSenderService> _logger;

            public EmailSenderService(IOptions<MailSettings> mailSettings, ILogger<EmailSenderService> logger)
            {
                this.mailSettings = mailSettings.Value;
                this._logger = logger;
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

                using var smtp = new MailKit.Net.Smtp.SmtpClient();
                try
                {
                    await smtp.ConnectAsync(mailSettings.Host, mailSettings.Port, MailKit.Security.SecureSocketOptions.StartTls);
                    await smtp.AuthenticateAsync(mailSettings.Mail, mailSettings.Password);
                    await smtp.SendAsync(message);
                    _logger.LogInformation("Email sent successfully to {Email}", email);
                }
                catch (AuthenticationException authEx)
                {
                    _logger.LogError(authEx, "Authentication failed.");
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "An error occurred while sending the email.");
                    // Save email message to a file for debugging
                    System.IO.Directory.CreateDirectory("mailsave");
                    var emailSaveFile = $"mailsave/{Guid.NewGuid()}.eml";
                    await message.WriteToAsync(emailSaveFile);
                }
                finally
                {
                    await smtp.DisconnectAsync(true);
                }
            }
        }
    }
}
