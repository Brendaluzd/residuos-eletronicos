using Microsoft.EntityFrameworkCore;
using ResiduosEletronicos.Models;

namespace ResiduosEletronicos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<PontoDeColeta> PontosDeColeta { get; set; }
    }
}
