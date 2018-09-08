using AutoSmart.Domain.Entities;
using AutoSmart.Domain.Interfaces.Repositories;

namespace AutoSmart.Infrastructure.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    { }
}