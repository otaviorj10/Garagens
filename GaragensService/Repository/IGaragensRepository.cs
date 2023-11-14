using GaragensService.Models;

namespace GaragensService.Repository
{
    public interface IGaragensRepository
    {
        void SaveChanges();
        IEnumerable<Garagens> GetAllGaragens();
        Garagens GetGaragensById(int id);
        void CreateGaragens(Garagens restaurante);
    }
}
