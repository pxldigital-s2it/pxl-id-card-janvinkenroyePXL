using Presences.Domain;

namespace Presences.Logic.IRepositories;

public interface IMomentRepository : IGenericRepository<Moment>
{
    Task<IEnumerable<Moment>> GetMomentsForALectorAsync(int lectorId);
    Task<IEnumerable<Moment>> GetMomentsForAStudentAsync(int studentId);
}