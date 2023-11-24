using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Petshop1.Models
{
    [Table("TipoServicos")]
    public class TipoServico
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int idTipoServico { get; set; }

        [Required(ErrorMessage = "Esse campo é OBRIGATÓRIO!")]
        [Display(Name = "Descrição do Serviço Feito")]
        [StringLength(55)]
        public string descricao { get; set; }

        [Display(Name = "Valor Unitário")]
        [Required(ErrorMessage = "Esse campo é OBRIGATÓRIO!")]
        public float valor { get; set; }

        public float calcular (int qtde ) 
        {
            float total = qtde * valor;
            return total;
        }
    }
}
