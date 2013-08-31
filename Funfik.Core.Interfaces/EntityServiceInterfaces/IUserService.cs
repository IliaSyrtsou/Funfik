using System.Collections.Generic;
using Funfik.Core.Entities;

namespace Funfik.Core.Interfaces.EntityServiceInterfaces
{
    /// <summary>
    /// An interface which provides user-related functionality.
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Deletes a user from database by user name.
        /// </summary>
        void DeleteUserByUserName(string Username);

        /// <summary>
        /// Deletes a user from database by id.
        /// </summary>
        void DeleteUserById(int id);

        /// <summary>
        /// Adds user to database.
        /// </summary>
        void AddUser(User user);

        /// <summary>
        /// Gets specific number of users from database.
        /// </summary>
        /// <param name="quantity">Number of users to get.</param>
        IEnumerable<User> GetUsers(int quantity);

    }
}
