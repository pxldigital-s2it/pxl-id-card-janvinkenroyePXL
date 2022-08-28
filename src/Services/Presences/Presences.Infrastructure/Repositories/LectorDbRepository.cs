using Microsoft.EntityFrameworkCore;
using Presences.Domain;
using Presences.Logic;

namespace Presences.Infrastructure;

public class LectorDbRepository : ILectorRepository
{
    private readonly PresencesContext _presencesContext;

    public LectorDbRepository(PresencesContext context)
    {
        this._presencesContext = context;
    }

    public async Task<IEnumerable<Lector>> GetLectorsAsync()
    {
        return await _presencesContext.Lectors
            .Include(l => l.User)
            .ToListAsync();
    }

    public async Task<Lector?> GetLectorByIDAsync(int id, bool includeMoments)
    {
        if (includeMoments)
        {
            return await _presencesContext.Lectors
            .Where(l => l.UserId == id)
            .Include(l => l.User)
            .Include(l => l.OwnedMoments)
            .SingleOrDefaultAsync();
        }
        else
        {
            return await _presencesContext.Lectors
            .Where(l => l.UserId == id)
            .Include(l => l.User)
            .SingleOrDefaultAsync();
        }

    }

    public Lector InsertLector(Lector newLector)
    {
        var addedLector = _presencesContext.Lectors.Add(newLector).Entity;
        Save();
        return addedLector;
    }

    public void UpdateLector(Lector lector)
    {
        _presencesContext.Entry(lector).State = EntityState.Modified;
        Save();
    }

    public void DeleteLector(int lectorId)
    {
        var lector = _presencesContext.Lectors.Find(lectorId);
        if (lector != null)
        {
            _presencesContext.Lectors.Remove(lector);
            Save();
        }
    }

    public async Task<IEnumerable<Moment>> GetMomentsForALectorAsync(int lectorId)
    {
        var lector = await GetLectorByIDAsync(lectorId, true);
        if (lector != null)
        {
            return lector.OwnedMoments;
        }
        else
        {
            return new List<Moment>();
        }
    }

    public void Save()
    {
        _presencesContext.SaveChanges();
    }
}
