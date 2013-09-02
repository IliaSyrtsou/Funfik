using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funfik.Core.Interfaces.HelperServiceInterfaces
{
    /// <summary>
    /// An interface for mail-sending-related functionality.
    /// </summary>
    public interface IMailService
    {
        void SendConfirmationLetter(String message, String email);
    }
}
