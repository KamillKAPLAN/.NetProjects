using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public List<Category> GetCategoryList()
        {
            throw new System.NotImplementedException();
        }

        //GenericRepository<Category> repo = new GenericRepository<Category>();

        //public List<Category> GetAllBL()
        //{
        //    return repo.Gets();
        //}

        //public void AddCategoryBL(Category p)
        //{
        //    if (p.CategoryName == "" || p.CategoryName.Length <= 3 || p.CategoryDescription == "" || p.CategoryName.Length > 51)
        //    {
        //        /* Hata Mesajı */
        //    }
        //    else
        //    {
        //        repo.Insert(p);
        //    }
        //}
    }
}
