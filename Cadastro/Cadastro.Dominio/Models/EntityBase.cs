using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Dominio.Models
{
    public class EntityBase
    {
        public int Id { get; set; }
/*
        public override bool Equals(object obj)
        {
            return obj is EntityBase @base &&
                   Id == @base.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }
*/
    }
}
