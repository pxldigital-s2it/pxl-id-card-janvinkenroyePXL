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
    public class MomentStudentController : ControllerBase
    {
        private IMomentStudentRepository _momentStudentRepository;
        private IStudentRepository _studentRepository;
        private IMomentRepository _momentRepository;

        public MomentStudentController(IStudentRepository studentRepository, IMomentRepository momentRepository, IMomentStudentRepository momentStudentRepository)
        {
            _studentRepository = studentRepository;
            _momentRepository = momentRepository;
            _momentStudentRepository = momentStudentRepository;
        }

        // GET api/<MomentStudentController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MomentStudent>>> GetAllMomentStudents()
        {
            var momentStudents = await _momentStudentRepository.GetAllAsync();
            return Ok(momentStudents);
        }

        // GET api/<MomentStudentController>/<studentId>/<momentId>
        [HttpGet("{studentId}/{momentId}")]
        public async Task<ActionResult<IEnumerable<MomentStudent>>> GetMomentStudent(int studentId, int momentId)
        {
            if (studentId <= 0 || momentId <= 0)
            {
                return BadRequest();
            }
            var momentStudent = await _momentStudentRepository.GetByIdsAsync(studentId, momentId);
            if (momentStudent != null)
            {
                return Ok(momentStudent);
            }
            else
            {
                return NotFound();
            }
        }

        // POST api/<MomentStudentController>/addpresence/<studentId>/<momentId>
        [HttpPost("addpresence/{studentId}/{momentId}")]
        public async Task<ActionResult<IEnumerable<MomentStudent>>> AddMomentStudent(int studentId, int momentId)
        {
            if (studentId <= 0 || momentId <= 0)
            {
                return BadRequest();
            }
            var student = await _studentRepository.GetByIdAsync(studentId);
            var moment = await _momentRepository.GetByIdAsync(momentId);
            if (student == null || moment == null)
            {
                return NotFound();
            }
            var newMomentStudent = new MomentStudent
            {
                StudentId = studentId,
                MomentId = momentId
            };
            await _momentStudentRepository.AddAsync(newMomentStudent);
            return CreatedAtAction(nameof(GetMomentStudent), new { studentId, momentId }, null);
        }
    }
}
