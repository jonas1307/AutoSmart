using AutoSmart.Domain.Entities;
using AutoSmart.Domain.Interfaces.Repositories;
using AutoSmart.Domain.Interfaces.Services;

namespace AutoSmart.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        public ClienteService(IRepositoryBase<Cliente> repository)
            : base(repository)
        { }
    }
}