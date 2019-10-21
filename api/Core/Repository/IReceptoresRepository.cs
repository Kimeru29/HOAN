using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using api.Models;

namespace api.Core.Repository
{
    public class IReceptoresRepository : IRepository<Receptor>
    {
        public Receptor Get()
        {
            throw new NotImplementedException();
        }

        public IQueryable GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save(Receptor TObject)
        {
            throw new NotImplementedException();
        }

        public void SaveRange(IEnumerable<Receptor> TlistEnumerable)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Receptor> Find(Expression<Func<Receptor, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<Receptor> Tenumerable)
        {
            throw new NotImplementedException();
        }
    }
}
