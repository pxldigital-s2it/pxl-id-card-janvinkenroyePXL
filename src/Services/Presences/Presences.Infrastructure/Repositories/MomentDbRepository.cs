using Microsoft.EntityFrameworkCore;
using Presences.Domain;
using Presences.Logic;

namespace Presences.Infrastructure;

public class MomentDbRepository : IMomentRepository
{
    private PresencesContext _presencesContext;

    public MomentDbRepository(PresencesContext context)
    {
        this._presencesContext = context;
    }
    
    public async Task<IEnumerable<Moment>> GetMomentsAsync()
    {
        return await _presencesContext.Moments
            .ToListAsync();
    }

    public async Task<Moment?> GetMomentByIDAsync(int id)
    {
        var moment = await _presencesContext.Moments.Where(m => m.Id == id).SingleOrDefaultAsync();
        return moment;
    }

    public Moment InsertMoment(Moment newMoment)
    {
        var addedMoment = _presencesContext.Moments.Add(newMoment).Entity;
        Save();
        return addedMoment;
    }

    public void UpdateMoment(Moment moment)
    {
        _presencesContext.Entry(moment).State = EntityState.Modified;
        Save();
    }

    public void DeleteMoment(int momentId)
    {
        var moment = _presencesContext.Moments.Find(momentId);
        if (moment != null)
        {
            _presencesContext.Moments.Remove(moment);
            Save();
        }
    }

    public async Task<IEnumerable<Student>> GetPresentStudentsForAMomentAsync(int momentId)
    {
        var moment = await GetMomentByIDAsync(momentId);
        if (moment != null)
        {
            return moment.PresentStudents;
        }
        else
        {
            return new List<Student>();
        }
    }

    public void Save()
    {
        _presencesContext.SaveChanges();
    }
}
