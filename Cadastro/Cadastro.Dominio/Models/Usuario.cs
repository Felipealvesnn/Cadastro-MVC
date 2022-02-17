using System.ComponentModel.DataAnnotations;

namespace Cadastro.Dominio.Models
{
    public class Usuario : EntityBase
    {
        [Required]
        [Display(Name = "Nome ")]
        public string Nome { get; set; }
        [Required]
        [Display(Name = "Apelido")]
        public string Apelido { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        public string Telefone { get; set; }

    }
}
