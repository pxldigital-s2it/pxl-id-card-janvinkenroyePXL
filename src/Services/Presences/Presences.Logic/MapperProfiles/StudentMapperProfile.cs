using AutoMapper;
using Presences.Domain;
using Presences.Dto;

namespace Presences.Logic.MapperProfiles;

internal class StudentMapperProfile : Profile
{
    public StudentMapperProfile()
    {
        CreateMap<Student, StudentDto>().IncludeMembers(s => s.User).ReverseMap();
        CreateMap<User, StudentDto>();
    }
}
