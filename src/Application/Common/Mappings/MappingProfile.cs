using Application.Common.Dtos;
using AutoMapper;
using Domain.Entites;

namespace Application.Common.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Test, TestDto>();
                //.ForMember(dest => dest.Id, opt => opt.MapFrom(src => 5));

            CreateMap<TestDto, Test>();
        }
    }
}
