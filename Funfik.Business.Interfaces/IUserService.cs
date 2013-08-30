using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Funfik.Core.Entities;

namespace Funfik.Business.Interfaces
{
    /// <summary>
    /// An interface which provides the capability of CRUD and other specific functions for a user.
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Fetches a user from database by an id.
        /// </summary>
        User GetUserById(int id);

        /// <summary>
        /// Fetches all users from database.
        /// </summary>
        ICollection<User> GetAllUsers();

        /// <summary>
        /// Deteles user with a given id.
        /// </summary>
        void DeteleUserById(int id);

        /// <summary>
        /// Deletes a user from database by user name.
        /// </summary>
        void DeleteUserByUserName(string userName);

        /// <summary>
        /// Creates new user in database.
        /// </summary>
        void CreateUser(User newUser);

        /// <summary>
        /// Updates user in database.
        /// </summary>
        void UpdateUser(User newUser);
    }
}
