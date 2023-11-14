using System.ComponentModel.DataAnnotations;

namespace FormaPagamentoService.Dtos
{
    public class FormasPagamentoReadDto
    {
        public int IdFormasPagamento { get; set; }

        [Required]
        public string Codigo { get; set; }


        [Required]
        public string Descricao { get; set; }
    }
}
