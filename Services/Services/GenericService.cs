using Data.Managers.Interfaces;
using Data.Repositories.Interfaces;
using Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class GenericService<TEntity> : IGenericService<TEntity>
        where TEntity : class
    {
        private IGenericRepository<TEntity> genRepository;

        public GenericService(IRepositoryManager repositoryManager)
        {
            this.genRepository = repositoryManager.GenericRepository<TEntity>();
        }

        public bool Create(TEntity entity)
        {
            try
            {
                genRepository.Create(entity);
            }
            catch(Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
