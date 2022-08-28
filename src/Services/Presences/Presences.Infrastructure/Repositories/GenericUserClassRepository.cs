using Microsoft.EntityFrameworkCore;
using Presences.Domain;
using Presences.Domain.Interfaces;
using Presences.Logic.IRepositories;

namespace Presences.Infrastructure;

public class GenericUserClassRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, IUserClassEntity
{
    private PresencesContext _presencesContext;

    public GenericUserClassRepository(PresencesContext context)
    {
        this._presencesContext = context;
    }
    
    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _presencesContext.Set<TEntity>()
            .Include(u => u.User)
            .ToListAsync();
    }

    public async Task<TEntity?> GetByIDAsync(int userId)
    {
        return await _presencesContext.Set<TEntity>()
            .Where(u => u.UserId == userId)
            .Include(u => u.User)
            .SingleOrDefaultAsync();
    }

    public TEntity Insert(TEntity newEntity)
    {
        var addedEntity = _presencesContext.Set<TEntity>().Add(newEntity).Entity;
        Save();
        return addedEntity;
    }

    public void Update(TEntity entity)
    {
        _presencesContext.Entry(entity).State = EntityState.Modified;
        Save();
    }

    public void Delete(int userId)
    {
        var entity = _presencesContext.Set<TEntity>()
            .Where(u => u.UserId == userId)
            .SingleOrDefaultAsync().Result;
        if (entity != null)
        {
            _presencesContext.Set<TEntity>().Remove(entity);
            Save();
        }
    }

    public async Task<bool> ExistsAsync(int userId)
    {
        return await _presencesContext.Set<TEntity>().AnyAsync(a => a.UserId == userId);
    }

    public void Save()
    {
        _presencesContext.SaveChanges();
    }
}
