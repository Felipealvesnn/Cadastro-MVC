using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Dominio.Models
{
    public class Cliente : EntityBase
    {
        [Required]
        [Display(Name = "Razão social")]
        public string Razsocial { get; set; }
        
        [Display(Name = "Nome fantasia")]
        public string NomeFan { get; set; }
        [Required]
        [Display(Name = "Cnpj")]
        public long Cnpj { get; set; }
        [Required]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
        [Display(Name = "Numero")]
        public int Numero { get; set; }
        [Display(Name = "Bairro")]
        public string Bairro { get; set; }
        [Display(Name = "Completo")]
        public string Complemento { get; set; }
        [Display(Name = "Municipio")]
        public string Municipio { get; set; }
        [Display(Name = "Cep")]
        public string Cep { get; set; }
    }
}
