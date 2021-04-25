using EntityLayer.Concrete;
using System.Collections.Generic;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal
    {
        /* CRUD */
        List<Category> GetCategories();
        void InsertCategory(Category c);
        void UpdateCategory(Category c);
        void DeleteCategory(Category c);
    }
}