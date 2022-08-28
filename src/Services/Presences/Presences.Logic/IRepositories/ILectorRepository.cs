using Presences.Domain;
using Presences.Logic.IRepositories;

namespace Presences.Logic;

public interface ILectorRepository : IGenericRepository<Lector>
{
    Task<IEnumerable<Moment>> GetMomentsForALectorAsync(int lectorId);
}