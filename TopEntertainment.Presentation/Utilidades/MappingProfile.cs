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
            CreateMap<Opinion, OpinionDto>().ReverseMap();
            CreateMap<Opinion, OpinionUpdateDto>().ReverseMap();
            CreateMap<Opinion, OpinionCreatedDto>().ReverseMap();
            CreateMap<Valuation, ValuationDto>().ReverseMap();
        }
    }
}
