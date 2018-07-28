using Data.Managers.Interfaces;
using Data.Repositories.Interfaces;
using Services.Managers.Interfaces;
using Services.Services;
using Services.Services.Interfaces;

namespace Services.Managers
{
    public class ServiceManager : IServiceManager
    {
        public IRepositoryManager repositoryManager;

        public ServiceManager(IRepositoryManager repositoryManager)
        {
            this.repositoryManager = repositoryManager;
        }

        public IGenericService<TEntity> GenericService<TEntity>()
            where TEntity : class
        {
            return new GenericService<TEntity>(repositoryManager);
        }
    }
}
