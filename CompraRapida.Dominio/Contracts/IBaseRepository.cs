using System;
using System.Collections.Generic;

namespace CompraRapida.Dominio.Contracts
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
    {

        void Insert(TEntity entity);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity entity);
        void Remove(TEntity entity);



    }
}
