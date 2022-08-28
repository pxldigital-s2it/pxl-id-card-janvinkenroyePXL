using Presences.Domain;
using Presences.Logic;

namespace Presences.Infrastructure;

public class MomentRepository : GenericRepository<Moment>, IMomentRepository
{
    public MomentRepository(PresencesContext context) : base(context)
    {
    }
}
