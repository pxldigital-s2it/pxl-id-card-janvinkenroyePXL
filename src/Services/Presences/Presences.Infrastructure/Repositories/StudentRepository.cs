using Microsoft.EntityFrameworkCore;
using Presences.Domain;
using Presences.Domain.Interfaces;
using Presences.Logic.IRepositories;

namespace Presences.Infrastructure.Repositories;

internal class StudentRepository : GenericRepository<Student>, IStudentRepository
{
    private PresencesContext _presencesContext;

    public StudentRepository(PresencesContext context) : base(context)
    {
        _presencesContext = context ?? throw new ArgumentNullException(nameof(_presencesContext));
    }

    public override async Task<IEnumerable<Student>> GetAllAsync()
    {
        return await _presencesContext.Students
            .Include(s => s.User)
            .ToListAsync();
    }

    public override async Task<Student?> GetByIDAsync(int id)
    {
        return await _presencesContext.Students
            .Where(u => u.Id == id)
            .Include(s => s.User)
            .SingleOrDefaultAsync();
    }

    public async Task AddPresenceForAStudentAsync(int id, Presence newPresence)
    {
        var student = await GetByIDAsync(id);
        if (student != null)
        {
            _presencesContext.Presences.Add(newPresence);
        }
    }
}
