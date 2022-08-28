using Presences.Domain;
using Presences.Logic;

namespace Presences.Infrastructure;

public class PresenceRepository : GenericRepository<Presence>, IPresenceRepository
{
    public PresenceRepository(PresencesContext context) : base(context)
    {
    }
    
}
