using Cadastro.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Dominio.Interfaces.Repositorios
{
    public interface IRepositorioBase<T> where T : EntityBase
    {
        void Adicionar(T entity);
        void Alterar(T entity);
        void Remover(T entity);
        T RetornaPorId(int id);
        IEnumerable<T> RetornaTodos();
    }
}
