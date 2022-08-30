using Presences.Domain;

namespace Presences.Logic.IRepositories;

public interface IStudentRepository : IGenericUserClassRepository<Student>
{
    Task<IEnumerable<Presence>> GetPresencesForAStudentAsync(int studentId);
}