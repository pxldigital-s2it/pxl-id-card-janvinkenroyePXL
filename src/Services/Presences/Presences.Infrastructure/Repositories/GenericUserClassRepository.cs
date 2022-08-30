using Microsoft.EntityFrameworkCore;
using Presences.Domain.Interfaces;
using Presences.Logic.IRepositories;

namespace Presences.Infrastructure.Repositories;

internal class GenericUserClassRepository<TEntity> : IGenericUserClassRepository<TEntity> where TEntity : class, IUserClassEntity
{
    private PresencesContext _presencesContext;
     
    public GenericUserClassRepository(PresencesContext context)
    {
        _presencesContext = context ?? throw new ArgumentNullException(nameof(_presencesContext));
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _presencesContext.Set<TEntity>()
            .ToListAsync();
    }

    public async Task<TEntity?> GetByUserNumberAsync(int userNumber)
    {
        return await _presencesContext.Set<TEntity>()
            .Where(u => u.UserNumber == userNumber)
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

    public void DeleteByUserNumber(int userNumber)
    {
        var entity = _presencesContext.Set<TEntity>()
            .Where(u => u.UserNumber == userNumber)
            .SingleOrDefaultAsync().Result;
        if (entity != null)
        {
            _presencesContext.Set<TEntity>().Remove(entity);
            Save();
        }
    }

    public async Task<bool> ExistsByUserNumberAsync(int userNumber)
    {
        return await _presencesContext.Set<TEntity>().AnyAsync(a => a.UserNumber == userNumber);
    }

    public void Save()
    {
        _presencesContext.SaveChanges();
    }
}
