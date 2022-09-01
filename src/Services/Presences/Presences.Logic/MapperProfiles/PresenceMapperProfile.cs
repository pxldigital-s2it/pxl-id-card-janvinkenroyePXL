using AutoMapper;
using Presences.DataTransfer;
using Presences.Domain;

namespace Presences.Logic.MapperProfiles;

internal class PresenceMapperProfile : Profile
{
    public PresenceMapperProfile()
    {
        CreateMap<Student, StudentDto>().IncludeMembers(s => s.User);
        CreateMap<User, StudentDto>();
        CreateMap<Presence, PresenceDto>()
            .ForMember(dest => dest.Student, act => act.MapFrom(src => src.Student));
    }
}
