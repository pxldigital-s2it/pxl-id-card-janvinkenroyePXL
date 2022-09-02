namespace Presences.Logic.IRepositories;

public interface IGenericRepository<TEntity>
{
    Task<IEnumerable<TEntity>> GetAllAsync();
    Task<TEntity?> GetByIDAsync(int id);
    TEntity Insert(TEntity entity);
    void Delete(int id);
    void Update(TEntity entity);
    Task<bool> ExistsAsync(int id);
    void Save();
}
