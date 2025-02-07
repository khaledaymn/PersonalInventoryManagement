using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MimeKit;
using PersonalInventoryManagement.BL.Interface;
using PersonalInventoryManagement.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInventoryManagement.BL.Repository
{
    public class EmailRepository : IEmailRepository
    {
        private readonly EmailConfiguration _email;

        public EmailRepository(EmailConfiguration email) => _email = email;
        public async Task<int> SendEmailAsync(User user)
        {
            int GeneratedCode;
            using var client = new MailKit.Net.Smtp.SmtpClient();
            try
            {
                // Create an email message based on the provided authentication details
                var mailMessage = CreateEmailMessage(user, out GeneratedCode);

                // Connect to the SMTP server using the configured settings
                await client.ConnectAsync(_email.SmtpServer, _email.Port, true);

                // Remove the XOAUTH2 authentication mechanism
                client.AuthenticationMechanisms.Remove("XOAUTH2");

                // Authenticate with the SMTP server using the provided credentials
                await client.AuthenticateAsync(_email.UserName, _email.Password);

                // Send the email message
                var a = await client.SendAsync(mailMessage);

                // If the email is sent successfully, return "success"
                return GeneratedCode;
            }
            catch (SmtpException ex)
            {
                // Return a meaningful error message
                throw new Exception("An SMTP error occurred while sending an email. Please try again later.");
            }
            catch (Exception ex)
            {
                // Return a generic error message
                throw new Exception("An error occurred while sending an email. Please try again later.");
            }
            finally
            {
                // Disconnect and dispose the client
                await client.DisconnectAsync(true);
                client.Dispose();
            }
        }


        private MimeMessage CreateEmailMessage(User user, out int GeneratedCode)
        {
            var random = new Random();
            GeneratedCode = random.Next(100000, 999999);

            var content = $@"
Hello {user.Name},

We received a request to reset the password for your Personal Inventory Management account.
To proceed with resetting your password, please use the following verification code:

🔢 Verification Code: {GeneratedCode}

If you did not request a password reset, please ignore this email or contact our support team if you have concerns.


Thank you.  
Best regards,  
Personal Inventory Management Team";

            var mailMessage = new MimeMessage();
            mailMessage.From.Add(new MailboxAddress("Personal Inventory Management", _email.From));
            mailMessage.To.Add(new MailboxAddress(user.Name, user.Email));
            mailMessage.Subject = "Password Reset Verification Code";

            mailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Plain)
            {
                Text = content
            };

            return mailMessage;
        }

    }
}
