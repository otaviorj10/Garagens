using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PassagensService.Models
{
    [Table("tbPassagens")]
    public class Passagens
    {
        [Key]
        public virtual int IdPassagens { get; set; }


        [Column("CarroPlaca")]
        [MaxLength(10)]
        [Required]
        public virtual string CarroPlaca { get; set; }



        [Column("CarroMarca")]
        [MaxLength(50)]
        [Required]
        public virtual string CarroMarca { get; set; }

        [Column("CarroModelo")]
        [MaxLength(50)]
        [Required]
        public virtual string CarroModelo { get; set; }


        [Column("DataHoraEntrada")]
        [MaxLength(50)]
        [Required]
        public virtual DateTime DataHoraEntrada { get; set; }


        [Column("DataHoraSaida")]
        [MaxLength(50)]
        [Required]
        public virtual DateTime DataHoraSaida { get; set; }

        [Column("PrecoTotal")]
        [MaxLength(50)]
        [Required]
        public virtual decimal PrecoTotal { get; set; }

        [Column("idFormasPagamento")]
        [Required]
        public virtual int idFormasPagamento { get; set; }

        [Column("IdGaragens")]
        [Required]
        public virtual int IdGaragens { get; set; }
    }
}
