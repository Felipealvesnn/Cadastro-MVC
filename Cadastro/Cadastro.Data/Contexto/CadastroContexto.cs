using Cadastro.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Data.Contexto
{
    public class CadastroContexto : DbContext
    {
        public CadastroContexto() : base("CadastroContexto")
        {

        }

        public virtual DbSet<Cliente> Clientes { get; set;}
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
