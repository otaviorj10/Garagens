using System.ComponentModel.DataAnnotations;

namespace PassagensService.Dtos
{
    public class PassagensReadDto
    {
        public virtual int IdPassagens { get; set; }


        [Required]
        public virtual string CarroPlaca { get; set; }

        [Required]
        public virtual string CarroMarca { get; set; }

        [Required]
        public virtual string CarroModelo { get; set; }


        [Required]
        public virtual DateTime DataHoraEntrada { get; set; }


        [Required]
        public virtual DateTime DataHoraSaida { get; set; }

        [Required]
        public virtual decimal PrecoTotal { get; set; }

        [Required]
        public virtual int idFormasPagamento { get; set; }

        [Required]
        public virtual int IdGaragens { get; set; }
    }
}
