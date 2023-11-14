using FormaPagamentoService.Models;
using Microsoft.EntityFrameworkCore;

namespace FormaPagamentoService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<FormasPagamento> FormasPagamentos { get; set; }
    }
}
