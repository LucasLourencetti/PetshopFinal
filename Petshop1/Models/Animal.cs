using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Petshop1.Models
{
    [Table("Animais")]
    public class Animal 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID")]
        public int idAnimal { get; set; }

        [Required(ErrorMessage = "Nome Obrigatório")]
        [Display(Name = "Nome do Animal")]
        [StringLength(30)]
        public string nome { get; set; }

        [Required(ErrorMessage = "Tipo do Animal Obrigatório")]
        [Display(Name = "Tipo do Animal")]
        public string tipoAnimal { get; set; }
    }
}
