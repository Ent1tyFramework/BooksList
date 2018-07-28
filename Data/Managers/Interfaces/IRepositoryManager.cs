using Data.Repositories.Interfaces;

namespace Data.Managers.Interfaces
{
    public interface IRepositoryManager
    {
        IGenericRepository<TEntity> GenericRepository<TEntity>() where TEntity : class;
    }
}
