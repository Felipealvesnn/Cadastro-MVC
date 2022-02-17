using Cadastro.Dominio.Interfaces.Repositorios;
using Cadastro.Dominio.Interfaces.Servicos;
using Cadastro.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.Servico
{
    public class ClienteServico : IClienteServico
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ClienteServico(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public void Adicionar(Cliente cliente)
        {
            _clienteRepositorio.Adicionar(cliente);
        }

        public void Alterar(Cliente cliente)
        {
            _clienteRepositorio.Alterar(cliente);
        }

        public void Remover(Cliente cliente)
        {
            _clienteRepositorio.Remover(cliente);
        }

        public Cliente RetornaPorId(int id)
        {
            return _clienteRepositorio.RetornaPorId(id);
        }

        public IEnumerable<Cliente> RetornaTodos()
        {
            return _clienteRepositorio.RetornaTodos();
        }
    }
}
