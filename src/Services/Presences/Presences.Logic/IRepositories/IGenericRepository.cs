using Presences.Domain;

namespace Presences.Logic.IRepositories;

public interface IGenericRepository<T>
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T?> GetByIDAsync(int id);
    T Insert(T entity);
    void Delete(int id);
    void Update(T entity);
    Task<bool> ExistsAsync(int id);
    void Save();
}
