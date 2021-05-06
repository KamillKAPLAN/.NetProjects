using BusinessLayer.Concrete;
using EntityLayer.Concrete;
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

        [HttpGet] /* sayfa yüklendiği zaman çalışacak `Attribute` */
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost] /* sayfada bir butona tıklandığında, sayfada bir şeyler post edildiği zaman çalışacak. */
        public ActionResult AddCategory(Category cat)
        {
            cm.AddCategoryBL(cat);
            return RedirectToAction("GetCategoryList"); /* Ekleme işlemi gerçekleştirildikten sonra yönlendirilecek View */
        }
    }
}