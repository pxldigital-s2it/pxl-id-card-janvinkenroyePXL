using Presences.Domain.Interfaces;

namespace Presences.Logic.IRepositories;

public interface IGenericUserClassRepository<TEntity> where TEntity : class, IUserClassEntity
{
    Task<IEnumerable<TEntity>> GetAllAsync();
    Task<TEntity?> GetByUserNumberAsync(int id);
    TEntity Insert(TEntity entity);
    void Update(TEntity entity);
    void DeleteByUserNumber(int userNumber);
    Task<bool> ExistsByUserNumberAsync(int id);
    void Save();
}