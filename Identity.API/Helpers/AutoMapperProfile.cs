using AutoMapper;
using Identity.API.Dtos;
using Identity.API.Entities;

namespace Identity.API.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}