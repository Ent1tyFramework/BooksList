using Data.Contexts;
using Data.Managers;
using Data.Managers.Interfaces;
using Ninject.Modules;
using Services.Managers;
using Services.Managers.Interfaces;

namespace WebApplication2.Util
{ 
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            var dbContext = new DataDbContext();

            Bind<IServiceManager>().To<ServiceManager>().WithConstructorArgument("repository", new RepositoryManager(dbContext));
            Bind<IRepositoryManager>().To<RepositoryManager>().WithConstructorArgument("dbContext", dbContext);
        }
    }
}