using Microsoft.EntityFrameworkCore;
using Presences.Domain;
using Presences.Domain.Interfaces;
using Presences.Logic.IRepositories;

namespace Presences.Infrastructure.Repositories;

internal class MomentRepository : GenericRepository<Moment>, IMomentRepository
{
    private PresencesContext _presencesContext;

    public MomentRepository(PresencesContext context) : base(context)
    {
        _presencesContext = context ?? throw new ArgumentNullException(nameof(_presencesContext));
    }

    public async Task<IEnumerable<Moment>> GetMomentsForALectorAsync(int userNumber)
    {
        return await _presencesContext.Moments
            .Include(m => m.Lector)
            .Where(m => m.Lector != null && m.Lector.UserNumber == userNumber)
            .Include(m => m.Presences)
            .ThenInclude(p => p.Student)
            .OrderBy(m => m.Date)
            .ToListAsync();
    }

    public async Task<IEnumerable<Moment>> GetMomentsForAStudentAsync(int userNumber)
    {
        return await _presencesContext.Moments
            .Include(m => m.Presences.Where(p => p.Student != null && p.Student.UserNumber == userNumber))
            .OrderBy(m => m.Date)
            .ToListAsync();
    }

    public override async Task<Moment?> GetByIDAsync(int id)
    {
        return await _presencesContext.Moments
            .Where(m => m.Id == id)
            .Include(m => m.Presences)
            .ThenInclude(p => p.Student)
            .SingleOrDefaultAsync();
    }
}