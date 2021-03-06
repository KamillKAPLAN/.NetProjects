using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        /* Field */
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> CategoryListBL()
        {
            return _categoryDal.Gets();
        }

        public void CategoryAddBL(Category category)
        {
            _categoryDal.Insert(category);
        }
    }
}
