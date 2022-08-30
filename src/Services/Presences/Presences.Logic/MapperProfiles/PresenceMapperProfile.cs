using AutoMapper;
using Presences.DataTransfer;
using Presences.Domain;

namespace Presences.Logic.MapperProfiles;

internal class PresenceMapperProfile : Profile
{
    public PresenceMapperProfile()
    {
        CreateMap<Presence, PresenceDto>()
            .ForMember(dest => dest.Student, opt => opt.MapFrom(src => src.Student))
            .ForMember(dest => dest.Moment, opt => opt.MapFrom(src => src.Moment))
            .ReverseMap();

        CreateMap<Student, StudentDto>().IncludeMembers(s => s.User).ReverseMap();
        CreateMap<Moment, MomentDto>().ReverseMap();
    }
}
