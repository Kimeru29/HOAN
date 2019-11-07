using api.Core.Repository;
using api.Core.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace api.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;
        public IEmisoresRepository EmisoresRepository { get; set; }
        public IReceptoresRepository ReceptoresRepository { get; set; }

        public UnitOfWork(DbContext context, IEmisoresRepository emisores, IReceptoresRepository receptores)
        {
            _context = context;
            EmisoresRepository = emisores;
            ReceptoresRepository = receptores;
        }
        public void Complete()
        {
            _context.SaveChanges();
        }

        public void Dispose() => _context.Dispose();

    }
}
