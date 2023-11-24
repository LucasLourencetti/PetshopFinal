using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Petshop1.Models
{
    [Table("Servicos")]
    public class Servico
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int idServico { get; set; }

        [Display(Name = "Cliente")]
        public int idCliente { get; set; }
        [ForeignKey("idCliente")]
        public Cliente Cliente { get; set; }

        [Display(Name = "Animal")]
        public int idAnimal { get; set; }
        [ForeignKey("idAnimal")]
        public Animal Animal { get; set; }

        [Display(Name = "TipoServico")]
        public int idTipoServico { get; set; }
        [ForeignKey("idTipoServico")]
        public TipoServico TipoServico { get; set; }

        [Display(Name = "Horário do Serviço")]
        public string horario { get; set; }

        [Display(Name = "Dia do Serviço")]
        public string data { get; set; }

        [Display(Name = "Valor Total")]
        public float valorTotal { get; set; }

        [Display(Name = "Quantidade do serviço")]
        public int qtde { get; set; }
    }
}
