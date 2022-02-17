using Cadastro.Data.Contexto;
using Cadastro.Dominio.Interfaces.Repositorios;
using Cadastro.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Data.Repositorios
{
    public class UsuarioRepositorio : RepositorioBase<Usuario>, IUsuarioRepositorio
    {
        private readonly CadastroContexto _contexto;
        public UsuarioRepositorio(CadastroContexto dbSet) : base(dbSet)
        {
            _contexto = dbSet;
        }
    }
}
