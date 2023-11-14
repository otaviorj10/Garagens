using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FormaPagamentoService.Models
{
    [Table("tbFormasPagamento")]
    public class FormasPagamento
    {
        [Key]
        public int IdFormasPagamento { get; set; }

        [Column("Codigo")]
        [MaxLength(10)]
        [Required]
        public string Codigo { get; set; }


        [Column("Descricao")]
        [MaxLength(50)]
        [Required]
        public string Descricao { get; set; }
    }
}
