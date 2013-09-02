using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using Funfik.Core.Entities;
using Funfik.Core.Interfaces.EntityServiceInterfaces;
using Funfik.Web.Areas.Administration.Models;

namespace Funfik.Web.Areas.Administration.Controllers
{
    [Authorize(Roles = "Administrator")]
    public partial class HomeController : Controller
    {

        public IUserService UserService { get; private set; }

        public HomeController(IUserService userService)
        {
            UserService = userService;
        }
        //
        // GET: /Admin/

        public virtual ActionResult Index()
        {
            return View();
        }

        public virtual ActionResult Users(int page = 1)
        {
            var users = UserService.GetUsers(10);
            Mapper.CreateMap<User, UserModel>();
            var viewModelList = Mapper.Map<IEnumerable<User>, IEnumerable<UserModel>>(users);
            int pageSize = 4;
            return View(viewModelList);
        }
        

    }
}
