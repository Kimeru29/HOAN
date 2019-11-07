using api.Core.Repository;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data.Repository
{
    public class EmisoresRepository : Repository<Emisor>, IEmisoresRepository
    {
        private DbContext _context;
        public EmisoresRepository(DbContext context) : base(context)
        {
            _context = context;
        }
        private HoanContext _hoanContext => _context as HoanContext;


    }
}