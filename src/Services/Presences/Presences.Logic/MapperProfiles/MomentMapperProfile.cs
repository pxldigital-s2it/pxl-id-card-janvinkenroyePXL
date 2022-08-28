using AutoMapper;
using Presences.Domain;
using Presences.Dto;

namespace Presences.Logic.MapperProfiles;

internal class MomentMapperProfile : Profile
{
    public MomentMapperProfile()
    {
        CreateMap<Moment, MomentDto>().ReverseMap();
    }
}
