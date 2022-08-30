using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Presences.Domain;
using Presences.Logic.IRepositories;

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

    [HttpPost]
    public IActionResult Post([FromBody] PresenceRequestBody presence)
    {
        if (ModelState.IsValid)
        {
            Presence newPresence = new Presence()
            {
                StudentId = presence.StudentId,
                MomentId = presence.MomentId,
                IsBlanco = presence.IsBlanco
            };

            return Ok(_presenceRepository.Insert(newPresence));
        }

        return BadRequest();
    }
}

public class PresenceRequestBody
{
    public int MomentId { get; set; }
    public int StudentId { get; set; }
    public bool IsBlanco { get; set; }
}
