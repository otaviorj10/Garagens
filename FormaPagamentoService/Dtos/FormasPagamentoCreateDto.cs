using System.ComponentModel.DataAnnotations;

namespace FormaPagamentoService.Dtos
{
    public class FormasPagamentoCreateDto
    {

        [Required]
        public string Codigo { get; set; }


        [Required]
        public string Descricao { get; set; }
    }
}