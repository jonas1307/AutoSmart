using AutoMapper;
using AutoSmart.Application.ViewModel;
using AutoSmart.Domain.Entities;

namespace AutoSmart.Application.AutoMapper.Profiles
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ClienteViewModel, Cliente>();
        }
    }
}
