using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Presences.DataTransfer;
using Presences.Domain;
using Presences.Infrastructure.Repositories;
using Presences.Logic.IRepositories;

namespace Presences.Api.Controllers;

[Route("api/moments")]
[ApiController]
public class MomentController : ControllerBase
{
    private readonly IMomentRepository _momentRepository;
    private readonly IStudentRepository _studentRepository;

    public MomentController(IMomentRepository momentRepository,
        IStudentRepository studentRepository)
    {
        _momentRepository = momentRepository;
        _studentRepository = studentRepository;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Moment>> GetMoment(int id)
    {
        if (id <= 0)
        {
            return BadRequest();
        }
        var moment = await _momentRepository.GetByIDAsync(id);
        if (moment != null)
        {
            return Ok(moment);
        }
        else
        {
            return NotFound();
        }
    }

    [HttpGet("{id}/absent-students")]
    public async Task<ActionResult<List<Student>>> GetAbsentStudentsForMoment(int id)
    {
        if (id <= 0)
        {
            return BadRequest();
        }
        if (!await _momentRepository.ExistsAsync(id))
        {
            return NotFound();
        }
        var students = await _studentRepository.GetAbsentStudentsByMomentID(id);
        return Ok(students);
    }
}
