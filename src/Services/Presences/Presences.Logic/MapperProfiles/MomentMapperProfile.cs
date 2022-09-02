using AutoMapper;
using Presences.DataTransfer;
using Presences.Domain;

namespace Presences.Logic.MapperProfiles;

internal class MomentMapperProfile : Profile
{
    public MomentMapperProfile()
    {
        CreateMap<Student, StudentDto>().IncludeMembers(s => s.User);
        CreateMap<User, StudentDto>();
        CreateMap<Presence, PresenceDto>()
            .ForMember(dest => dest.Student, act => act.MapFrom(src => src.Student));
        CreateMap<Moment, MomentDto>()
            .ForMember(dest => dest.Presences, act => act.MapFrom(src => src.Presences));
    }
}
