using PassagensService.Data;
using PassagensService.Models;

namespace PassagensService.Repository
{
    public class PassagensRepository : IPassagensRepository
    {
        private readonly AppDbContext _context;

        public PassagensRepository(AppDbContext context)
        {
            _context = context;
        }

        public void CreatePassagens(Passagens passagens)
        {
            if (passagens == null)
            {
                throw new ArgumentNullException(nameof(passagens));
            }

            _context.Passagens.Add(passagens);
        }

        public IEnumerable<Passagens> GetAllPassagens()
        {
            return _context.Passagens.ToList();
        }

        public Passagens GetPassagensById(int id) => _context.Passagens.FirstOrDefault(c => c.IdPassagens == id);

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
