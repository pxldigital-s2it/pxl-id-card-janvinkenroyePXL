using Microsoft.EntityFrameworkCore;
using Presences.Domain;
using Presences.Logic.IRepositories;

namespace Presences.Infrastructure.Repositories;

internal class MomentRepository : GenericRepository<Moment>, IMomentRepository
{
    private PresencesContext _presencesContext;

    public MomentRepository(PresencesContext context) : base(context)
    {
        _presencesContext = context ?? throw new ArgumentNullException(nameof(_presencesContext));
    }

    public async Task<IEnumerable<Moment>> GetMomentsForALectorAsync(int lectorId)
    {
        return await _presencesContext.Moments
            .Where(m => m.LectorId == lectorId)
            .Include(m => m.Presences)
            .ThenInclude(p => p.Student)
            .OrderBy(m => m.Date)
            .ToListAsync();
    }

    public async Task<IEnumerable<Moment>> GetMomentsForAStudentAsync(int studentId)
    {
        return await _presencesContext.Moments
            .Include(m => m.Presences.Where(p => p.StudentId == studentId))
            .OrderBy(m => m.Date)
            .ToListAsync();
    }
}
