using AutoMapper;
using TopEntertainment.Domain.DTOs;
using TopEntertainment.Domain.Entities;

namespace TopEntertainment.Presentation.Utilidades
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
