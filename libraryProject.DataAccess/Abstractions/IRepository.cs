using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace libraryProject.DataAccess.Abstractions
{
    public interface IRepository<T> where T : class
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(Guid id);
        T GetByID(Guid id);
        IEnumerable<T> GetAll();
        // IEnumerable kısmı şunu yapar: T türündeki tüm varlıkları döner.

        //?? duruma göre kullanım değişkiliği olucak
        bool IfEntityExists(Expression<Func<T, bool>> filter);
    }
}
