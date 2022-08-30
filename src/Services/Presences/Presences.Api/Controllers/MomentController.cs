using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Presences.DataTransfer;
using Presences.Domain;
using Presences.Logic.IRepositories;

namespace Presences.Api.Controllers;

[Route("api/moments")]
[ApiController]
public class MomentController : ControllerBase
{
    private readonly ILectorRepository _lectorRepository;
    private readonly IMapper _mapper;

    public MomentController(ILectorRepository lectorRepository, IMapper mapper)
    {
        _lectorRepository = lectorRepository;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<MomentDto>>> GetMomentsForALector(int userId)
    {
        var moments = await _lectorRepository.GetMomentsForALectorAsync(userId);
        return Ok(_mapper.Map<IEnumerable<MomentDto>>(moments));
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
