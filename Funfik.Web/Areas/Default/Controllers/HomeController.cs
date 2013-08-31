using System.Web.Mvc;
using Funfik.Core.Interfaces.EntityServiceInterfaces;

namespace Funfik.Web.Areas.Default.Controllers
{
    public partial class HomeController : Controller
    {
        private IUserService _db;

        public HomeController(IUserService db)
        {
            _db = db;
        }

        public virtual ActionResult Index()
        {
            var users  = _db.GetUsers(10);    

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
