using Cadastro.Data.Contexto;
using Cadastro.Dominio.Interfaces.Repositorios;
using Cadastro.Dominio.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Data.Repositorios
{
    public class RepositorioBase<T> : IRepositorioBase<T> where T : EntityBase
    {
        private readonly CadastroContexto _contexto;
        private readonly DbSet<T> DbSet;

        public RepositorioBase(CadastroContexto dbSet)
        {
            _contexto = dbSet;
            DbSet = dbSet.Set<T>();
        }

        public void Adicionar(T entity)
        {
            DbSet.Add(entity);
            _contexto.SaveChanges();
        }

        public void Alterar(T entity)
        {
            _contexto.Entry(entity).State = EntityState.Modified;
            _contexto.SaveChanges();
        }

        public void Remover(T entity)
        {
            _contexto.Entry(entity).State = EntityState.Deleted;
            _contexto.SaveChanges();
        }

        public T RetornaPorId(int id)
        {
            return DbSet.Find(id);
        }

        public IEnumerable<T> RetornaTodos()
        {
            return DbSet;
        }
    }
}
