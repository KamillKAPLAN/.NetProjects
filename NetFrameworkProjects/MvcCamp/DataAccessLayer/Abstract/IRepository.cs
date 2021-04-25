using System.Collections.Generic;

namespace DataAccessLayer.Abstract
{
    /* T : bir Entity 'i karşılar. SQL 'den gönderilecek Entity class'ı */
    public interface IRepository<T>
    {
        /* CRUD */
        List<T> GetCategories();
        void InsertCategory(T p);
        void UpdateCategory(T p);
        void DeleteCategory(T p);
    }
}
