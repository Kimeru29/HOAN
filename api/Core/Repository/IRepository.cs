namespace api.Core.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Linq.Expressions;

    [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:ElementsMustBeDocumented", Justification = "Reviewed. Suppression is OK here.")]
    public interface IRepository<T> where T : class
    {
        T Get(string celular, string contraseña);

        IQueryable GetAll();

        void Save(T tObject);

        void SaveRange(IEnumerable<T> tlistEnumerable);

        IQueryable<T> Find(Expression<Func<T, bool>> predicate);

        void Remove(T entidad);

        void RemoveRange(IEnumerable<T> tEnumerable);
    }
}
