using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace api.Data.Repository
{
    using api.Core.Repository;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq.Expressions;

    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:ElementsMustBeDocumented", Justification = "Reviewed. Suppression is OK here.")]
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _context;

        public Repository(DbContext context) => _context = context;

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public T Get(string celular, string contraseña) => _context.Set<T>().Find(celular, contraseña);

        public IQueryable GetAll() => _context.Set<T>().AsQueryable();

        public void Remove(T entidad) => _context.Set<T>().Remove(entidad);

        public void RemoveRange(IEnumerable<T> tEnumerable) => _context.Set<T>().RemoveRange(tEnumerable);

        public void Save(T tObject) => _context.Set<T>().Add(tObject);

        public void SaveRange(IEnumerable<T> tlistEnumerable) => _context.Set<T>().AddRange(tlistEnumerable);

    }
}
