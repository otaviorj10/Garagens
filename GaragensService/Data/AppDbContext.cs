using GaragensService.Models;
using Microsoft.EntityFrameworkCore;

namespace GaragensService.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Garagens> Garagens { get; set; }
    }
}
