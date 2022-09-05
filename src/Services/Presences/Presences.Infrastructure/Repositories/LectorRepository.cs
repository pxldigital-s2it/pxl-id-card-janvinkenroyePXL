using Microsoft.EntityFrameworkCore;
using Presences.Domain;
using Presences.Domain.Interfaces;
using Presences.Logic.IRepositories;

namespace Presences.Infrastructure.Repositories;

internal class LectorRepository : GenericRepository<Lector>, ILectorRepository
{
    private PresencesContext _presencesContext;
    public LectorRepository(PresencesContext context) : base(context)
    {
        _presencesContext = context ?? throw new ArgumentNullException(nameof(_presencesContext));
    }

    public async Task<bool> ExistsUserNumberAsync(int userNumber)
    {
        return await _presencesContext.Lectors.AnyAsync(a => a.UserNumber == userNumber);
    }

}
