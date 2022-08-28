using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Presences.Domain;
using Presences.Dto;
using Presences.Logic;

namespace Presences.Api.Controllers;

[Route("api/presences")]
[ApiController]
public class PresenceController : ControllerBase
{
    private readonly IPresenceRepository _presenceRepository;
    private readonly IStudentRepository _studentRepository;
    private readonly IMapper _mapper;

    public PresenceController(IPresenceRepository presenceRepository, 
        IStudentRepository studentRepository, 
        IMapper mapper)
    {
        _presenceRepository = presenceRepository;
        _studentRepository = studentRepository;
        _mapper = mapper;
    }

}
