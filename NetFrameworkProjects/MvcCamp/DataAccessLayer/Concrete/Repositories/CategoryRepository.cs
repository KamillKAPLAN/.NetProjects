using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccessLayer.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();
        DbSet<Category> _object;
        public void Delete(Category c)
        {
            _object.Remove(c);
            /* EF 'deki değişiklikleri kaydetmek için SaveChanges() metodu kullanılır. */
            this.c.SaveChanges();
        }

        public List<Category> GetById(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Category> Gets()
        {
            return _object.ToList();
        }

        public void Insert(Category c)
        {
            _object.Add(c);
            /* EF 'deki değişiklikleri kaydetmek için SaveChanges() metodu kullanılır. */
            this.c.SaveChanges(); 
        }

        public void Update(Category c)
        {
            this.c.SaveChanges();
        }
    }
}
