using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class HoanContext : DbContext
    {
        public HoanContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Emisor> Emisores { get; set; }
        public DbSet<Receptor> Receptores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }
    }
}
