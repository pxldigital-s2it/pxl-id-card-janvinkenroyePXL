using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Presences.DataTransfer;
using Presences.Domain;
using Presences.Logic.IRepositories;

namespace Presences.Api.Controllers;

[Route("api/students")]
[ApiController]
public class StudentController : ControllerBase
{
    private readonly IStudentRepository _studentRepository;
    private readonly IPresenceRepository _presenceRepository;
    private readonly IMomentRepository _momentRepository;
    private readonly IMapper _mapper;

    public StudentController(IStudentRepository studentRepository, 
        IPresenceRepository presenceRepository,
        IMomentRepository momentRepository,
        IMapper mapper)
    {
        _studentRepository = studentRepository;
        _presenceRepository = presenceRepository;
        _momentRepository = momentRepository;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<StudentDto>>> GetAllStudents()
    {
        var students = await _studentRepository.GetAllAsync();
        return Ok(_mapper.Map<IEnumerable<StudentDto>>(students));
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<StudentDto>> GetStudent(int id)
    {
        if (id <= 0)
        {
            return BadRequest();
        }
        var student = await _studentRepository.GetByIDAsync(id);
        if (student != null)
        {
            return Ok(_mapper.Map<StudentDto>(student));
        }
        else
        {
            return NotFound();
        }
    }

    [HttpGet("{id}/presences")]
    public async Task<ActionResult<IEnumerable<PresenceDto>>> GetPresences(int id)
    {
        if (id <= 0)
        {
            return BadRequest();
        }
        if (! await _studentRepository.ExistsAsync(id))
        {
            return NotFound();
        }
        var presences = await _presenceRepository.GetPresencesForAStudentAsync(id);
        var presenceDtos = new List<PresenceDto>();
        foreach (var presence in presences)
        {
            presenceDtos.Add(_mapper.Map<PresenceDto>(presence));
        }
        return Ok(presenceDtos);
    }

    [HttpPost("{id}/presences")]
    public async Task<IActionResult> AddPresence(int id, [FromBody] PresenceRequestBody presence)
    {
        if (id <= 0)
        {
            return BadRequest();
        }
        if (!await _studentRepository.ExistsAsync(id))
        {
            return NotFound();
        }
        if (ModelState.IsValid &&
            await _momentRepository.ExistsAsync(presence.MomentId))
        {
            Presence newPresence = new Presence()
            {
                MomentId = presence.MomentId,
                IsBlanco = presence.IsBlanco
            };
            await _studentRepository.AddPresenceForAStudentAsync(id, newPresence);


            return Ok(_mapper.Map<PresenceDto>(_presenceRepository.Insert(newPresence)));
        }
        return BadRequest();
    }

    [HttpGet("{id}/moments")]
    public async Task<ActionResult<IEnumerable<MomentDto>>> GetStudentMoments(int id)
    {
        if (id <= 0)
        {
            return BadRequest();
        }
        if (!await _studentRepository.ExistsAsync(id))
        {
            return NotFound();
        }
        var moments = await _momentRepository.GetMomentsForAStudentAsync(id);
        var momentDtos = new List<MomentDto>();
        foreach (var moment in moments)
        {
            momentDtos.Add(_mapper.Map<MomentDto>(moment));
        }
        return Ok(momentDtos);
    }
}

public class PresenceRequestBody
{
    public int MomentId { get; set; }
    public bool IsBlanco { get; set; }
}
