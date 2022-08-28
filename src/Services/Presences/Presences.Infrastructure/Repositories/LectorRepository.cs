using Microsoft.EntityFrameworkCore;
using Presences.Domain;
using Presences.Logic;

namespace Presences.Infrastructure;

public class LectorRepository : GenericUserClassRepository<Lector>, ILectorRepository
{
    public LectorRepository(PresencesContext context) : base(context)
    {
    }
    public async Task<IEnumerable<Moment>> GetMomentsForALectorAsync(int userId)
    {
        var lector = await GetByIDAsync(userId);
        if (lector != null)
        {
            return lector.OwnedMoments;
        }
        else
        {
            return new List<Moment>();
        }
    }
}
