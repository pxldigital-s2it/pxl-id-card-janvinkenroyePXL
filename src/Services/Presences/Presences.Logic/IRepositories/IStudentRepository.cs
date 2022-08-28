using Presences.Domain;
using Presences.Logic.IRepositories;

namespace Presences.Logic;

public interface IStudentRepository : IGenericRepository<Student>
{
    Task<IEnumerable<Presence>> GetPresencesForAStudentAsync(int studentId);
}