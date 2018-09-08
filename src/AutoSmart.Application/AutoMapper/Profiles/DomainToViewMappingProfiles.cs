using AutoMapper;
using AutoSmart.Application.ViewModel;
using AutoSmart.Domain.Entities;

namespace AutoSmart.Application.AutoMapper.Profiles
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Cliente, ClienteViewModel>();
        }
    }
}
