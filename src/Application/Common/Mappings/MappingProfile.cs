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
            CreateMap<TestDto, Test>();

            CreateMap<User, UserDto>();

            CreateMap<UserDto, User>()
                .ForMember(dest => dest.Nickname, opt => opt.MapFrom(src => src.FirstName));
        }
    }
}
