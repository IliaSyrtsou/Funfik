using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Funfik.Web.Areas.Administration.Controllers
{
    [Authorize(Roles = "Administrator")]
    public partial class AdminController : Controller
    {
        //
        // GET: /Admin/

        public virtual ActionResult Index()
        {
            return View();
        }

        public virtual ActionResult Users()
        {
            return View();
        }

    }
}
