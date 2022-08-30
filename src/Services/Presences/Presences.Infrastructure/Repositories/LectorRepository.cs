using Microsoft.EntityFrameworkCore;
using Presences.Domain;
using Presences.Logic.IRepositories;

namespace Presences.Infrastructure.Repositories;

internal class LectorRepository : GenericUserClassRepository<Lector>, ILectorRepository
{
    public LectorRepository(PresencesContext context) : base(context)
    {
    }
    public async Task<IEnumerable<Moment>> GetMomentsForALectorAsync(int userNumber)
    {
        var lector = await GetByUserNumberAsync(userNumber);
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
