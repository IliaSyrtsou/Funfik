using System.Collections.Generic;
using Funfik.Core.Entities;

namespace Funfik.Core.Interfaces.EntityServiceInterfaces
{
    /// <summary>
    /// An interface which provides user-related functionality.
    /// </summary>
    public interface IUserService : IBusinessService<User>
    {
        /// <summary>
        /// Deletes a user from database by user name.
        /// </summary>
        void DeleteUserByUserName(string userName);
    }
}
