using FormaPagamentoService.Models;

namespace FormaPagamentoService.Repository
{
    public interface IFormasPagamentoRepository
    {
        void SaveChanges();
        IEnumerable<FormasPagamento> GetAllFormasPagamento();
        FormasPagamento GetFormasPagamentoById(int id);
        void CreateFormasPagamento(FormasPagamento formasPagamento);
    }
}
