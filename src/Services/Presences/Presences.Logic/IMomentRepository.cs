using Presences.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Presences.Logic
{
    public interface IMomentRepository
    {
        Task<List<Moment>> GetAllAsync();
        Task<Moment> GetByIdAsync(int id);
        Task<Moment> AddAsync(Moment moment);
    }
}
