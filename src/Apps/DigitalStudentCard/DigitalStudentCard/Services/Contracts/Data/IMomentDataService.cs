using DigitalStudentCard.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DigitalStudentCard.Core.Services.Contracts.Data
{
    public interface IMomentDataService
    {
        Task<IEnumerable<Moment>> GetLectorMomentsAsync(int lectorId);
        Task<IEnumerable<Moment>> GetStudentMomentsAsync(int studentId);
    }
}
