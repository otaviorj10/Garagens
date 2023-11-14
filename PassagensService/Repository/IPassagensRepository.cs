using PassagensService.Models;

namespace PassagensService.Repository
{
    public interface IPassagensRepository
    {
        void SaveChanges();
        IEnumerable<Passagens> GetAllPassagens();
        Passagens GetPassagensById(int id);
        void CreatePassagens(Passagens restaurante);
    }
}
