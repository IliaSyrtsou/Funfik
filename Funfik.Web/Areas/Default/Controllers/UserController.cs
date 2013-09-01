using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Funfik.Core.Entities;
using Funfik.Core.Interfaces.EntityServiceInterfaces;
using Funfik.Web.Areas.Default.Models;

namespace Funfik.Web.Areas.Default.Controllers
{
    public partial class UserController : Controller
    {
        private IUserService UserService { get; set; }

        public UserController(IUserService userService)
        {
            UserService = userService;
        }
        //
        // GET: /Default/User/

        public virtual ActionResult Index()
        {
            return View();
        }

    }
}
