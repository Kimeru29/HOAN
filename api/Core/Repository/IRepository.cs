using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace api.Core.Repository
{
    public interface IRepository<T> where T : class
    {
        T Get();
        IQueryable GetAll();

        void Save(T TObject);
        void SaveRange(IEnumerable<T> TlistEnumerable);
        IQueryable<T> Find(Expression<Func<T, bool>> predicate);

        void Remove(int id);
        void RemoveRange(IEnumerable<T> Tenumerable);
    }
}
