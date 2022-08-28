using AutoMapper;
using Presences.Logic.MapperProfiles;

namespace Presences.Logic;

public class MappingConfig
{
    public static IMapper CreateMapper()
    {
        var mappingConfig = new MapperConfiguration(mc =>
        {
            mc.AddProfile(new StudentMapperProfile());
        });

        return mappingConfig.CreateMapper();
    }
}
