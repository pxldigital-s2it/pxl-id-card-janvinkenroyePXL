using Microsoft.AspNetCore.Mvc;
using Presences.Domain;
using Presences.Logic;

namespace Presences.Api.Controllers;

[Route("api/students")]
[ApiController]
public class StudentController : ControllerBase
{
    private IStudentRepository _studentRepository;

    public StudentController(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Student>>> GetAllStudents()
    {
        var students = await _studentRepository.GetStudentsAsync();
        return Ok(students);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<IEnumerable<Student>>> GetStudent(int id)
    {
        if (id <= 0)
        {
            return BadRequest();
        }
        var student = await _studentRepository.GetStudentByIDAsync(id, true);
        if (student != null)
        {
            return Ok(student);
        }
        else 
        {
            return NotFound();
        }
    }
}
