using Microsoft.EntityFrameworkCore;
using Presences.Domain;
using Presences.Logic.IRepositories;

namespace Presences.Infrastructure.Repositories;

internal class LectorRepository : GenericRepository<Lector>, ILectorRepository
{
    public LectorRepository(PresencesContext context) : base(context)
    {
    }

}
