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
   public class UsuarioServico : IUsuarioServico
    {
        private readonly IUsuarioRepositorio _UsuarioRepositorio;
        public UsuarioServico(IUsuarioRepositorio UsuarioRepositorio)
        {
            _UsuarioRepositorio = UsuarioRepositorio;
        }

        public void Adicionar(Usuario Usuario)
        {
            _UsuarioRepositorio.Adicionar(Usuario);
        }

        public void Alterar(Usuario Usuario)
        {
            _UsuarioRepositorio.Alterar(Usuario);
        }

        public void Remover(Usuario Usuario)
        {
            _UsuarioRepositorio.Remover(Usuario);
        }

        public Usuario RetornaPorId(int id)
        {
            return _UsuarioRepositorio.RetornaPorId(id);
        }

        public IEnumerable<Usuario> RetornaTodos()
        {
            return _UsuarioRepositorio.RetornaTodos();
        }
    }
}
