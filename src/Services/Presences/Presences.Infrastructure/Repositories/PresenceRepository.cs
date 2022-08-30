using Presences.Domain;
using Presences.Logic.IRepositories;

namespace Presences.Infrastructure.Repositories;

internal class PresenceRepository : GenericRepository<Presence>, IPresenceRepository
{
    public PresenceRepository(PresencesContext context) : base(context)
    {
    }

}
