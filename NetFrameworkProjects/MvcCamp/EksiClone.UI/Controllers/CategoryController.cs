using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System.Web.Mvc;
using FluentValidation.Results;

namespace EksiClone.UI.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());

        // GET: Category
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCategoryList()
        {
            var categoryValues = cm.CategoryListBL();
            return View(categoryValues); /* categoryValues içindeki değerler View'e aktarılmış oldu. */
        }

        [HttpGet] /* sayfa yüklendiği zaman çalışacak `Attribute` */
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost] /* sayfada bir butona tıklandığında, sayfada bir şeyler post edildiği zaman çalışacak. */
        public ActionResult AddCategory(Category category)
        {
            CategoryValidator categoryValidator = new CategoryValidator();
            /* CategoryValidator sınıfında olan değerlere göre doğruluk kontrolünü gerçekçeleştirilecek değer `category` */
            ValidationResult validationResult = categoryValidator.Validate(category);

            if (validationResult.IsValid)
            {
                cm.CategoryAddBL(category);
                return RedirectToAction("GetCategoryList"); /* Ekleme işlemi gerçekleştirildikten sonra yönlendirilecek View */
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}