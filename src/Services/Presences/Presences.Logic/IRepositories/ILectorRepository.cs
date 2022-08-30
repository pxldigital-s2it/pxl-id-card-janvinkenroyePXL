using Presences.Domain;

namespace Presences.Logic.IRepositories;

public interface ILectorRepository : IGenericUserClassRepository<Lector>
{
    Task<IEnumerable<Moment>> GetMomentsForALectorAsync(int lectorId);
}