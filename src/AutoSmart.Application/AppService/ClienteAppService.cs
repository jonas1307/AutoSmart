using AutoSmart.Application.Interfaces;
using AutoSmart.Domain.Entities;
using AutoSmart.Domain.Interfaces.Services;

namespace AutoSmart.Application.AppService
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        public ClienteAppService(IServiceBase<Cliente> serviceBase)
            : base(serviceBase)
        { }
    }
}
