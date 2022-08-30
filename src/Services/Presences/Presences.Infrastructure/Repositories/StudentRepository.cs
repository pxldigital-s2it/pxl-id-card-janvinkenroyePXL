using Presences.Domain;
using Presences.Logic.IRepositories;

namespace Presences.Infrastructure.Repositories;

internal class StudentRepository : GenericUserClassRepository<Student>, IStudentRepository
{
    public StudentRepository(PresencesContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Presence>> GetPresencesForAStudentAsync(int userNumber)
    {
        var student = await GetByUserNumberAsync(userNumber);
        if (student != null)
        {
            return student.Presences;
        }
        else
        {
            return new List<Presence>();
        }
    }
}
