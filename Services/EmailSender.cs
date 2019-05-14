using System;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using Services.Resolvers;

namespace Services
{
    public class EmailSender : IEmailSender
    {
        public EmailSender(IOptions<EmailResolver> optionsAccessor)
        {
            Options = optionsAccessor.Value;
        }


        // Properties are set with Configuration from secret manager
        public EmailResolver Options { get; }

        public Task SendEmailAsync(string email, string subject, string message)
        {
            return Execute(Options.SendGridKey, subject, message, email);
        }

        public Task Execute(string apiKey, string subject, string message, string email)
        {
            var client = new SendGridClient(apiKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress("webmaster.hamelot@outlook.com", "Web Master"),
                Subject = subject,
                PlainTextContent = message,
                HtmlContent = message
            };

            msg.AddTo(new EmailAddress(email));
            msg.SetClickTracking(false, false);
            return client.SendEmailAsync(msg);
        }
    }
}


