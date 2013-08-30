using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Funfik.Core.Interfaces.DataAccessInterfaces;

namespace Funfik.Web.Areas.Default.Controllers
{
    public partial class HomeController : Controller
    {
        private IDataSource _db;

        public HomeController(IDataSource db)
        {
            _db = db;
        }

        public virtual ActionResult Index()
        {
            var users  = _db.Users;    

            return View(users);
        }

        public virtual ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public virtual ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
