using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataAccessLayer.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();
        DbSet<Category> _object;
        public void DeleteCategory(Category c)
        {
            _object.Remove(c);
            /* EF 'deki değişiklikleri kaydetmek için SaveChanges() metodu kullanılır. */
            this.c.SaveChanges();
        }

        public List<Category> GetCategories()
        {
            return _object.ToList();
        }

        public void InsertCategory(Category c)
        {
            _object.Add(c);
            /* EF 'deki değişiklikleri kaydetmek için SaveChanges() metodu kullanılır. */
            this.c.SaveChanges(); 
        }

        public void UpdateCategory(Category c)
        {
            this.c.SaveChanges();
        }
    }
}
