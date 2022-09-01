using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DigitalStudentCard.Core.DataStores.Contracts
{
    public interface IDataStore<T>
    {
        Task<bool> AddAsync(T item);
        Task<bool> UpdateAsync(T item);
        Task<bool> DeleteAsync(int id);
        Task<T> GetAsync(int id);
        Task<IEnumerable<T>> GetAllAsync(bool forceRefresh = false);
    }
}
