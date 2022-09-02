using Presences.Domain;

namespace Presences.Logic.IRepositories;

public interface IPresenceRepository : IGenericRepository<Presence>
{
    Task<IEnumerable<Presence>> GetPresencesForAStudentAsync(int studentId);
}