using AutoSmart.Application.AppService;
using AutoSmart.Application.Interfaces;
using AutoSmart.Domain.Interfaces.Repositories;
using AutoSmart.Domain.Interfaces.Services;
using AutoSmart.Domain.Services;
using AutoSmart.Infrastructure.Data.Repositories;
using SimpleInjector;

namespace AutoSmart.Infrastructure.CrossCutting.IoC
{
    public class Bootstrapper
    {
        public static void RegisterServices(Container container)
        {
            // App Services
            container.Register(typeof(IAppServiceBase<>), typeof(AppServiceBase<>), Lifestyle.Scoped);
            container.Register<IClienteAppService, ClienteAppService>(Lifestyle.Scoped);

            // Services
            container.Register(typeof(IServiceBase<>), typeof(ServiceBase<>), Lifestyle.Scoped);
            container.Register<IClienteService, ClienteService>(Lifestyle.Scoped);

            // Repositories
            container.Register(typeof(IRepositoryBase<>), typeof(RepositoryBase<>), Lifestyle.Scoped);
            container.Register<IClienteRepository, ClienteRepository>(Lifestyle.Scoped);
        }
    }
}