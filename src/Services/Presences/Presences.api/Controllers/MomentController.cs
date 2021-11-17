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
    public class MomentController : ControllerBase
    {
        private IMomentRepository _momentRepository;

        public MomentController(IMomentRepository momentRepository)
        {
            _momentRepository = momentRepository;
        }

        // GET api/<MomentController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Moment>>> GetAllMoments()
        {
            var moments = await _momentRepository.GetAllAsync();
            return Ok(moments);
        }

        // GET api/<MomentController>/<id>
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Moment>>> GetMoment(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }
            var moment = await _momentRepository.GetByIdAsync(id);
            if (moment != null)
            {
                return Ok(moment);
            }
            else
            {
                return NotFound();
            }
        }

        // POST api/<MomentController>
        [HttpPost]
        public async Task<ActionResult<IEnumerable<Moment>>> PostMoment([FromBody] Moment moment)
        {
            var newMoment = new Moment
            {
                Name = moment.Name,
                MomentType = moment.MomentType,
                MomentStudents = new List<MomentStudent>()
            };
            await _momentRepository.AddAsync(newMoment);
            return CreatedAtAction(nameof(GetMoment), new { moment.Id }, null);
        }
    }
}
