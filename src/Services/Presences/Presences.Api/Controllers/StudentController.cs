using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Presences.DataTransfer;
using Presences.Logic.IRepositories;

namespace Presences.Api.Controllers;

[Route("api/students")]
[ApiController]
public class StudentController : ControllerBase
{
    private readonly IStudentRepository _studentRepository;
    private readonly IMapper _mapper;

    public StudentController(IStudentRepository studentRepository, IMapper mapper)
    {
        _studentRepository = studentRepository;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<StudentDto>>> GetAllStudents()
    {
        var students = await _studentRepository.GetAllAsync();
        return Ok(_mapper.Map<IEnumerable<StudentDto>>(students));
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<StudentDto>> GetStudent(int userNumber)
    {
        if (userNumber <= 0)
        {
            return BadRequest();
        }
        var student = await _studentRepository.GetByUserNumberAsync(userNumber);
        if (student != null)
        {
            return Ok(_mapper.Map<StudentDto>(student));
        }
        else
        {
            return NotFound();
        }
    }
}
