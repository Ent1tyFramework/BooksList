using Services.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Managers.Interfaces
{
    public interface IServiceManager
    {
        IGenericService<TEntity> GenericService<TEntity>() where TEntity : class;
    }
}
