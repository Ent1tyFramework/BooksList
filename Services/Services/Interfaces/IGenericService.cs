using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services.Interfaces
{
    public interface IGenericService<TEntity> : IService
        where TEntity : class
    {
        bool Create(TEntity entity);
    }
}
