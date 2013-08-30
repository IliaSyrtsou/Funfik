using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Funfik.Core.DataAccess;
using Funfik.Core.Interfaces.DataAccessInterfaces;

namespace Funfik.Web.Areas.Administration.Controllers
{
    [Authorize(Roles = "Administrator")]
    public partial class HomeController : Controller
    {

        IDataSource _db = new FunfikDb();
        //
        // GET: /Admin/

        public virtual ActionResult Index()
        {
            return View();
        }

        public virtual ActionResult Users()
        {
            var users = _db.Users;
            return View(users);
        }

    }
}
