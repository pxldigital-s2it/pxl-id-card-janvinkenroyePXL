using Presences.Domain;

namespace Presences.Logic.IRepositories;

public interface IStudentRepository : IGenericRepository<Student>
{
    Task AddPresenceForAStudentAsync(int id, Presence newPresence);
    Task<bool> ExistsUserNumberAsync(int userNumber);
}