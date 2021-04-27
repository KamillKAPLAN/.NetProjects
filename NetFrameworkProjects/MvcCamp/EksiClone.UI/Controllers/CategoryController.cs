using BusinessLayer.Concrete;
using System.Web.Mvc;

namespace EksiClone.UI.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager();

        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCategoryList()
        {
            var categoryValues = cm.GetAllBL();
            return View(categoryValues); /* categoryValues içindeki değerler View'e aktarılmış oldu. */
        }
    }
}