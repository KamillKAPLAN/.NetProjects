using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccessLayer.Concrete.Repositories
{
    /* 
     * <T> -> GenericRepository bir tane T değeri alacak
     * IRepository<T> -> GenericRepository'nin interface olarak değerlerini IRepository'den alır.
     * where T : class -> GenericRepository'nin şartı T bir class olmalı.
     */
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context c = new Context();
        DbSet<T> _object;

        /*
         * T değerine karşılık olarak gelecek sınıfı `constructor` - yapıcı metot ile bulacazki, _object 'e değer atalım.
         */
        public GenericRepository()
        {
            _object = c.Set<T>();
        }

        public void Delete(T p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public List<T> GetById(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public List<T> Gets()
        {
            return _object.ToList();
        }

        public void Insert(T p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public void Update(T p)
        {
            c.SaveChanges();
        }
    }
}
