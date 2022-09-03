using Microsoft.EntityFrameworkCore;
using Presences.Domain;
using Presences.Logic.IRepositories;

namespace Presences.Infrastructure.Repositories;

internal class PresenceRepository : GenericRepository<Presence>, IPresenceRepository
{
    private PresencesContext _presencesContext;

    public PresenceRepository(PresencesContext context) : base(context)
    {
        _presencesContext = context ?? throw new ArgumentNullException(nameof(_presencesContext));
    }

    public async Task<IEnumerable<Presence>> GetPresencesForAStudentAsync(int studentId)
    {
        return await _presencesContext.Presences
            .Where(p => p.StudentId == studentId)
            .Include(p => p.Moment)
            .ToListAsync();
    }
}
