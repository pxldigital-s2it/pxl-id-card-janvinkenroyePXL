using Presences.Domain;
using Presences.Logic.IRepositories;

namespace Presences.Infrastructure.Repositories;

internal class MomentRepository : GenericRepository<Moment>, IMomentRepository
{
    public MomentRepository(PresencesContext context) : base(context)
    {
    }
}
