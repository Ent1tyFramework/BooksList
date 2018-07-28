using Data.Contexts;
using Data.Managers.Interfaces;
using Data.Repositories;
using Data.Repositories.Interfaces;

namespace Data.Managers
{
    public class RepositoryManager : IRepositoryManager
    {
        private DatabaseContext dbContext;

        public RepositoryManager(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IGenericRepository<TEntity> GenericRepository<TEntity>()
            where TEntity : class
        {
            return new GenericRepository<TEntity>(dbContext);
        }
    }
}
