using Presences.Domain;

namespace Presences.Logic;

public interface ILectorRepository
{
    Task<IEnumerable<Lector>> GetLectorsAsync();
    Task<Lector?> GetLectorByIDAsync(int lectorId, bool includeMoments);
    Lector InsertLector(Lector lector);
    void DeleteLector(int lectorId);
    void UpdateLector(Lector lector);
    Task<IEnumerable<Moment>> GetMomentsForALectorAsync(int lectorId);
    void Save();
}