using AutoMapper;
using Presences.DataTransfer;
using Presences.Domain;

namespace Presences.Logic.MapperProfiles;

internal class StudentMapperProfile : Profile
{
    public StudentMapperProfile()
    {
        CreateMap<Student, StudentDto>().IncludeMembers(s => s.User);
        CreateMap<User, StudentDto>();
    }
}
