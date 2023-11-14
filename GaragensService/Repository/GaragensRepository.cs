using GaragensService.Data;
using GaragensService.Models;

namespace GaragensService.Repository
{
    public class GaragensRepository : IGaragensRepository
    {
        private readonly AppDbContext _contexto;

        public GaragensRepository(AppDbContext context)
        {
            _contexto = context;
        }

        public void CreateGaragens(Garagens garagens)
        {
            if (garagens == null)
            {
                throw new ArgumentNullException(nameof(garagens));
            }

            _contexto.Garagens.Add(garagens);
        }

        public IEnumerable<Garagens> GetAllGaragens()
        {
            return _contexto.Garagens.ToList();
        }

        public Garagens GetGaragensById(int id) => _contexto.Garagens.FirstOrDefault(c => c.IdGaragens == id);

        public void SaveChanges()
        {
            _contexto.SaveChanges();
        }
    }
}
