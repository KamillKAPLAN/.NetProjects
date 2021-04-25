using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccessLayer.Abstract
{
    /* T : bir Entity 'i karşılar. SQL 'den gönderilecek Entity class'ı */
    public interface IRepository<T>
    {
        /* CRUD */
        List<T> Gets();
        void Insert(T p);
        void Update(T p);
        void Delete(T p);
        List<T> GetById(Expression<Func<T, bool>> filter);
    }
}