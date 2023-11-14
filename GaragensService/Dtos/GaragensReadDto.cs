using System.ComponentModel.DataAnnotations;

namespace GaragensService.Dtos
{
    public class GaragensReadDto
    {
        [Key]
        public virtual int IdGaragens { get; set; }

        [Required]
        public virtual string Codigo { get; set; }

        [Required]
        public virtual string Nome { get; set; }

        [Required]
        public virtual decimal Preco_1aHora { get; set; }

        [Required]
        public virtual decimal Preco_HorasExtra { get; set; }


        [Required]
        public virtual decimal Preco_Mensalista { get; set; }
    }
}
