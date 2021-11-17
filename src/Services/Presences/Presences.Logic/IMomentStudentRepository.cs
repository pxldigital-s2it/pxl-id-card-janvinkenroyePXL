using Presences.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Presences.Logic
{
    public interface IMomentStudentRepository
    {
        Task<List<MomentStudent>> GetAllAsync();
        Task<MomentStudent> GetByIdsAsync(int studentId, int momentId);
        Task<MomentStudent> AddAsync(MomentStudent momentStudent);
    }
}
