using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Presences.DataTransfer;
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

    [HttpGet("{id}/moments")]
    public async Task<ActionResult<IEnumerable<MomentDto>>> GetMomentsForALector(int id)
    {
        if (id <= 0)
        {
            return BadRequest();
        }
        if (!await _lectorRepository.ExistsAsync(id))
        {
            return NotFound();
        }
        var moments = await _momentRepository.GetMomentsForALectorAsync(id);
        var momentDtos = new List<MomentDto>();
        foreach (var moment in moments)
        {
            momentDtos.Add(_mapper.Map<MomentDto>(moment));
        }
        return Ok(momentDtos);
    }



    /*
    [HttpPost]
    public ActionResult<void> PostPresence(int userId)
    {
        var moments = await _lectorRepository.GetMomentsForALectorAsync(userId);
        return Ok(_mapper.Map<IEnumerable<MomentDto>>(moments));
    }
    */
}
