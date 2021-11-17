using Microsoft.AspNetCore.Mvc;
using Presences.Domain;
using Presences.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Presences.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentRepository _studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        // GET api/<StudentController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetAllStudents()
        {
            var students = await _studentRepository.GetAllAsync();
            return Ok(students);
        }

        // GET api/<StudentController>/<id>
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudent(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }
            var student = await _studentRepository.GetByIdAsync(id);
            if (student != null)
            {
                return Ok(student);
            }
            else
            {
                return NotFound();
            }
        }

        // POST api/<StudentController>
        [HttpPost]
        public async Task<ActionResult<IEnumerable<Student>>> PostStudent([FromBody] Student student)
        {
            var newStudent = new Student
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                MomentStudents = new List<MomentStudent>()
            };
            await _studentRepository.AddAsync(newStudent);
            return CreatedAtAction(nameof(GetStudent), new { student.Id }, null);
        }
    }
}
