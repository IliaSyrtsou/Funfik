using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Funfik.Core.Interfaces.HelperServiceInterfaces;
using Postal;

namespace Funfik.Core.Services.HelperServices
{
    public class MailService : IMailService
    {

        void IMailService.SendConfirmationLetter(string confirmationToken, string email)
        {

            dynamic Email = new Email("RegEmail");
            Email.To = email;
            Email.ConfirmationToken = confirmationToken;
            Email.Send();
        }
    }
}
