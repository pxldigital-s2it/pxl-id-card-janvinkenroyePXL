using Presences.Domain;
using Presences.Logic;

namespace Presences.Infrastructure;

public class StudentRepository : GenericUserClassRepository<Student>, IStudentRepository
{
    public StudentRepository(PresencesContext context) : base(context)
    {
    }
    
    public async Task<IEnumerable<Presence>> GetPresencesForAStudentAsync(int studentId)
    {
        var student = await GetByIDAsync(studentId);
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
