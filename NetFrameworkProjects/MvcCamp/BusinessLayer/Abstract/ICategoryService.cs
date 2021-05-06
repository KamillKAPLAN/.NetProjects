using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        List<Category> CategoryListBL();

        void CategoryAddBL(Category category);
    }
}
