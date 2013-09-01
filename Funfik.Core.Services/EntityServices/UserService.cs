using System.Collections.Generic;
using System.Linq;
using Funfik.Core.DataAccess;
using Funfik.Core.Entities;
using Funfik.Core.Interfaces.EntityServiceInterfaces;

namespace Funfik.Core.Services.EntityServices
{
    /// <summary>
    /// A service which provides user-related functionality.
    /// </summary>
    public class UserService: IUserService
    {
        private FunfikDb Database { get; set; }

        private int pageSize = 10;

        public UserService()
        {
            Database = new FunfikDb();
        }

        void IUserService.DeleteUserByUserName(string username)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Deletes user with given id.
        /// </summary>
        void IUserService.DeleteUserById(int id)
        {
            Database.Users.Remove(Database.Users.Find(id));
            Database.SaveChanges();
        }

        void IUserService.AddUser(User user)
        {
            throw new System.NotImplementedException();
        }

        IEnumerable<User> IUserService.GetUsers(int quantity)
        {
            return Database.Users;
        }

        User IUserService.GetUserById(int id)
        {
            throw new System.NotImplementedException();
        }

        User IUserService.GetUserByUsername(string userName)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Searchs for users whose username contains a given string. Returns 10 first matches.
        /// </summary>
        IEnumerable<User> IUserService.SearchUserWithUsername(string searchString)
        {
            return (from user in Database.Users 
                    orderby user.Username 
                    where user.Username.Contains(searchString) || string.IsNullOrEmpty(searchString)
                    select user);
        }

        /// <summary>
        /// Fetches the number of users in database.
        /// </summary>
        int IUserService.UserCount
        {
            get { return Database.Users.Count(); }
        }
    }
}
