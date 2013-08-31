using System.Collections.Generic;
using Funfik.Core.DataAccess;
using Funfik.Core.Entities;
using Funfik.Core.Interfaces.EntityServiceInterfaces;

namespace Funfik.Core.Services.EntityServices
{
    public class UserService: IUserService
    {
        public FunfikDb Database { get; private set; }

        public UserService()
        {
            Database = new FunfikDb();
        }

        void IUserService.DeleteUserByUserName(string Username)
        {
            throw new System.NotImplementedException();
        }

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
    }
}
