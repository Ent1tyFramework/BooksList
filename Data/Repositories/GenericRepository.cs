using Data.Contexts;
using Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>
        where TEntity : class
    {
        private DatabaseContext dbContext;

        public GenericRepository(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(TEntity entity)
        {
            using (dbContext = dbContext.Get())
            {
                dbContext.Set<TEntity>().Add(entity);
                dbContext.SaveChanges();
            }
        }

        public TEntity Get(Func<TEntity, bool> func)
        {
            using (dbContext = dbContext.Get())
            {
                return dbContext.Set<TEntity>().Find(func);
            }
        }

        public List<TEntity> GetAll()
        {
            using (dbContext = dbContext.Get())
            {
                return dbContext.Set<TEntity>().ToList();
            }
        }


        public List<TEntity> Where(Func<TEntity, bool> func)
        {
            using (dbContext = dbContext.Get())
            {
                return dbContext.Set<TEntity>().Where(func).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (dbContext = dbContext.Get())
            {
                dbContext.Entry(entity).State = EntityState.Modified;
                dbContext.SaveChanges();
            }
        }

        public void Remove(TEntity entity)
        {
            using (dbContext = dbContext.Get())
            {
                dbContext.Set<TEntity>().Remove(entity);
                dbContext.SaveChanges();
            }
        }
    }
}
