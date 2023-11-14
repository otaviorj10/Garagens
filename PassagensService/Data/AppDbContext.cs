using Microsoft.EntityFrameworkCore;
using PassagensService.Models;

namespace PassagensService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Passagens> Passagens { get; set; }
    }
}
