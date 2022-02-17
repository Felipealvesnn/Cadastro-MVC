using Cadastro.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Dominio.Interfaces.Servicos
{
    public interface IClienteServico
    {
        void Adicionar(Cliente cliente);
        void Alterar(Cliente cliente);
        void Remover(Cliente cliente);
        Cliente RetornaPorId(int id);
        IEnumerable<Cliente> RetornaTodos();
    }
}
