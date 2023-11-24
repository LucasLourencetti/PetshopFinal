using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Petshop1.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int idCliente { get; set; }

        [Required(ErrorMessage = "Nome Obrigatório")]
        [Display(Name = "Nome do Cliente")]
        [StringLength(35)]
        public string nome { get; set; }

        [Required(ErrorMessage = "Cidade OBRIGATÓRIO")]
        [Display(Name = "Cidade do Cliente")]
        [StringLength(30)]
        public string cidade { get; set; }
    }
}
