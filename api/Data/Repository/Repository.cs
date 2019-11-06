using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Data.Repository
{
    using System.Diagnostics.CodeAnalysis;
    using System.Linq.Expressions;
    using api.Core.Repository;

    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:ElementsMustBeDocumented", Justification = "Reviewed. Suppression is OK here.")]
    public class Repository<T> : IRepository<T> where T : class
    {
        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public T Get()
        {
            throw new NotImplementedException();
        }

        public IQueryable GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<T> tEnumerable)
        {
            throw new NotImplementedException();
        }

        public void Save(T tObject)
        {
            throw new NotImplementedException();
        }

        public void SaveRange(IEnumerable<T> tlistEnumerable)
        {
            throw new NotImplementedException();
        }
    }
}
