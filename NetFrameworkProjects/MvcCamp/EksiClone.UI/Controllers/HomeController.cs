using System.Web.Mvc;

namespace EksiClone.UI.Controllers
{
    public class HomeController : Controller
    {
        /* Index : Listeleme için kullanılır. */
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Test()
        {
            return View();
        }
    }
}