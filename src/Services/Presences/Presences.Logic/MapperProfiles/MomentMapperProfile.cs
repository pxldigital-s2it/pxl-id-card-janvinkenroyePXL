using AutoMapper;
using Presences.DataTransfer;
using Presences.Domain;

namespace Presences.Logic.MapperProfiles;

internal class MomentMapperProfile : Profile
{
    public MomentMapperProfile()
    {
        CreateMap<Moment, MomentDto>().ReverseMap();
    }
}
