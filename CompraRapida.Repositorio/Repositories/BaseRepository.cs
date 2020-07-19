using CompraRapida.Dominio.Contracts;
using CompraRapida.Repositorio.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompraRapida.Repositorio.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {

        protected readonly CompraRapidaContexto CompraRapidaContexto;
        public BaseRepository( CompraRapidaContexto compraRapidaContexto)
        {
            CompraRapidaContexto = compraRapidaContexto;  
        }

        public IEnumerable<TEntity> GetAll()
        {
            return CompraRapidaContexto.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return CompraRapidaContexto.Set<TEntity>().Find(id);
        }

        public void Insert(TEntity entity)
        {
            CompraRapidaContexto.Set<TEntity>().Add(entity);
            CompraRapidaContexto.SaveChanges();
        }

        public void Remove(TEntity entity)
        {
            CompraRapidaContexto.Set<TEntity>().Remove(entity);
            CompraRapidaContexto.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            CompraRapidaContexto.Set<TEntity>().Update(entity);
            CompraRapidaContexto.SaveChanges();
        }
        public void Dispose()
        {
            CompraRapidaContexto.Dispose();
        }
    }
}
