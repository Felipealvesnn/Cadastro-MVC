using Cadastro.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Dominio.Interfaces.Servicos
{
    public interface IUsuarioServico
    {
        void Adicionar(Usuario Usuario);
        void Alterar(Usuario Usuario);
        void Remover(Usuario Usuario);
        Usuario RetornaPorId(int id);
        IEnumerable<Usuario> RetornaTodos();
    }
}
