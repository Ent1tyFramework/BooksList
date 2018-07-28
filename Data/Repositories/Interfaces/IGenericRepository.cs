using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Interfaces
{
    public interface IGenericRepository<TEntity> : IRepository
        where TEntity : class
    {
        void Create(TEntity entity);

        TEntity Get(Func<TEntity, bool> func);

        List<TEntity> GetAll();

        List<TEntity> Where(Func<TEntity, bool> func);

        void Update(TEntity entity);

        void Remove(TEntity entity);
    }
}
