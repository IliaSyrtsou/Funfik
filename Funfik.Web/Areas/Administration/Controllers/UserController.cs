using System;
using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using Funfik.Core.Entities;
using Funfik.Core.Interfaces.EntityServiceInterfaces;
using Funfik.Web.Areas.Administration.Models;
using WebMatrix.WebData;

namespace Funfik.Web.Areas.Administration.Controllers
{
    public partial class UserController : Controller
    {
        private IUserService UserService { get; set; }

        public UserController(IUserService userService)
        {
            UserService = userService;
        }
        //
        // GET: /Administration/User/

        public virtual ActionResult Index()
        {
            return View();
        }

        public virtual ActionResult SearchUsers(string searchString)
        {
            var users = UserService.SearchUserWithUsername(searchString);
            Mapper.CreateMap<User, UserModel>();
            var viewModelList = Mapper.Map<IEnumerable<User>, IEnumerable<UserModel>>(users);

            return PartialView(MVC.Administration.User.Views._ShowUsersListPartial, viewModelList);
        }

        public virtual ActionResult DeleteUser(int userId)
        {
            UserService.DeleteUserById(userId);
            var users = UserService.GetUsers(UserService.UserCount);
            Mapper.CreateMap<User, UserModel>();
            var viewModelList = Mapper.Map<IEnumerable<User>, IEnumerable<UserModel>>(users);

            return PartialView(MVC.Administration.User.Views._ShowUsersListPartial, viewModelList);
        }


        public virtual ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public virtual ActionResult Register(String username, String email, String password)
        {
            WebSecurity.CreateUserAndAccount(username, email, new { Email = email });
            var users = UserService.GetUsers(10);
            Mapper.CreateMap<User, UserModel>();
            var viewModelList = Mapper.Map<IEnumerable<User>, IEnumerable<UserModel>>(users);
            return PartialView("_ShowUsersListPartial", viewModelList);
        }
    }
}
