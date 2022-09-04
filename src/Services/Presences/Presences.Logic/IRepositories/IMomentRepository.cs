using Presences.Domain;

namespace Presences.Logic.IRepositories;

public interface IMomentRepository : IGenericRepository<Moment>
{
    Task<IEnumerable<Moment>> GetMomentsForALectorAsync(int userNumber);
    Task<IEnumerable<Moment>> GetMomentsForAStudentAsync(int userNumber);
}