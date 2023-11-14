using FormaPagamentoService.Data;
using FormaPagamentoService.Models;

namespace FormaPagamentoService.Repository
{
    public class FormasPagamentoRepository : IFormasPagamentoRepository
    {
        private readonly AppDbContext _contexto;

        public FormasPagamentoRepository(AppDbContext contexto)
        {
            _contexto = contexto;
        }

        public void CreateFormasPagamento(FormasPagamento formasPagamento)
        {
            if (formasPagamento == null)
            {
                throw new ArgumentNullException(nameof(formasPagamento));
            }

            _contexto.FormasPagamentos.Add(formasPagamento);
        }

        public IEnumerable<FormasPagamento> GetAllFormasPagamento()
        {
            return _contexto.FormasPagamentos.ToList();
        }

        public FormasPagamento GetFormasPagamentoById(int id) => _contexto.FormasPagamentos.FirstOrDefault(c => c.IdFormasPagamento == id);

        public void SaveChanges()
        {
            _contexto.SaveChanges();
        }
    }
}
