using Microsoft.EntityFrameworkCore;
using Presences.Domain.Interfaces;
using Presences.Logic.IRepositories;

namespace Presences.Infrastructure.Repositories;

internal class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class, IEntity
{
    private PresencesContext _presencesContext;

    public GenericRepository(PresencesContext context)
    {
        _presencesContext = context ?? throw new ArgumentNullException(nameof(_presencesContext));
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _presencesContext.Set<TEntity>()
            .ToListAsync();
    }

    public async Task<TEntity?> GetByIDAsync(int id)
    {
        return await _presencesContext.Set<TEntity>()
            .Where(u => u.Id == id)
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

    public void Delete(int id)
    {
        var entity = _presencesContext.Admins.Find(id);
        if (entity != null)
        {
            _presencesContext.Admins.Remove(entity);
            Save();
        }
    }

    public async Task<bool> ExistsAsync(int id)
    {
        return await _presencesContext.Set<TEntity>().AnyAsync(a => a.Id == id);
    }

    public void Save()
    {
        _presencesContext.SaveChanges();
    }
}
