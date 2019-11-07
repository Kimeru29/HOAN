using api.Core.Repository;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data.Repository
{
    public class ReceptoresRepository : Repository<Receptor>, IReceptoresRepository
    {
        private DbContext _context;
        public ReceptoresRepository(DbContext context) : base(context)
        {
            _context = context;
        }
        private HoanContext _hoanContext => _context as HoanContext;


    }
}