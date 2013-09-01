using System;
using System.Collections.Generic;
using Funfik.Core.Entities;

namespace Funfik.Core.Interfaces.EntityServiceInterfaces
{
    /// <summary>
    /// An interface for user-related functionality.
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Deletes a user from database by user name.
        /// </summary>
        void DeleteUserByUserName(String Username);

        /// <summary>
        /// Deletes user from database by id.
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

        /// <summary>
        /// Gets user from database by id.
        /// </summary>
        User GetUserById(int id);

        /// <summary>
        /// Gets user from database by username.
        /// </summary>
        User GetUserByUsername(String userName);

        /// <summary>
        /// Searchs for users whose username contains a given string.
        /// </summary>
        IEnumerable<User> SearchUserWithUsername(String username);

        /// <summary>
        /// Fetches the number of users in database.
        /// </summary>
        int UserCount { get; }
    }
}
