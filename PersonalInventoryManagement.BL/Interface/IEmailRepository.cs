using PersonalInventoryManagement.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInventoryManagement.BL.Interface
{
    public interface IEmailRepository
    {
        /// <summary>
        /// Asynchronously sends an email using the provided authentication details.
        /// </summary>
        /// <returns>
        /// A task representing the asynchronous operation, containing a string indicating the status of the email sending process.
        /// </returns>
        /// <remarks>
        /// This method performs the following steps:
        /// 1. Validates the SMTP server configuration.
        /// 2. Creates an email message based on the provided authentication details.
        /// 3. Connects to the SMTP server using the configured settings.
        /// 4. Authenticates with the SMTP server using the provided credentials.
        /// 5. Sends the email message.
        /// 6. Handles any exceptions that occur during the email sending process and logs them for troubleshooting.
        /// </remarks>
        Task<int> SendEmailAsync(User user);
    }
}
