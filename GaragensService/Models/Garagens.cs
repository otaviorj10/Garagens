using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GaragensService.Models
{
    [Table("tbGaragens")]
    public class Garagens
    {
        [Key]
        public virtual int IdGaragens { get; set; }

        [Column("Codigo")]
        [MaxLength(10)]
        [Required]
        public virtual string Codigo { get; set; }

        [Column("Nome")]
        [MaxLength(255)]
        [Required]
        public virtual string Nome { get; set; }

        [Column("Preco_1aHora")]
        [Required]
        public virtual decimal Preco_1aHora { get; set; }

        [Column("Preco_HorasExtra")]
        [Required]
        public virtual decimal Preco_HorasExtra { get; set; }


        [Column("Preco_Mensalista")]
        [Required]
        public virtual decimal Preco_Mensalista { get; set; }
    }
}
