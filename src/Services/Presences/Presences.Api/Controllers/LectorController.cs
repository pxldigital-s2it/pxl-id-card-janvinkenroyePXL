using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Presences.Domain;
using Presences.Logic.IRepositories;

namespace Presences.Api.Controllers;

[Route("api/lectors")]
[ApiController]
public class LectorController : ControllerBase
{
    private readonly ILectorRepository _lectorRepository;
    private readonly IMomentRepository _momentRepository;
    private readonly IMapper _mapper;

    public LectorController(ILectorRepository lectorRepository, 
        IMomentRepository momentRepository, 
        IMapper mapper)
    {
        _lectorRepository = lectorRepository;
        _momentRepository = momentRepository;
        _mapper = mapper;
    }

    [HttpGet("{userNumber}/moments")]
    public async Task<ActionResult<IEnumerable<Moment>>> GetMomentsForALector(int userNumber)
    {
        if (userNumber <= 0)
        {
            return BadRequest();
        }
        if (!await _lectorRepository.ExistsUserNumberAsync(userNumber))
        {
            return NotFound();
        }
        var moments = await _momentRepository.GetMomentsForALectorAsync(userNumber);

        return Ok(moments);
    }
}
