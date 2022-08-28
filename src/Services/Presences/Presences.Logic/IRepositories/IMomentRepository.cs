using Presences.Domain;

namespace Presences.Logic;

public interface IMomentRepository
{
    Task<IEnumerable<Moment>> GetMomentsAsync();
    Task<Moment?> GetMomentByIDAsync(int momentId);
    Moment InsertMoment(Moment moment);
    void DeleteMoment(int momentId);
    void UpdateMoment(Moment moment);
    Task<IEnumerable<Student>> GetPresentStudentsForAMomentAsync(int momentId);
    void Save();
}