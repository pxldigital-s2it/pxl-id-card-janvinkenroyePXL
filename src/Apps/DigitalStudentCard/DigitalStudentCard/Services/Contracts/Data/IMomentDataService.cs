using DigitalStudentCard.Core.Models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace DigitalStudentCard.Core.Services.Contracts.Data
{
    public interface IMomentDataService
    {
        Task<ObservableCollection<Moment>> GetLectorMomentsAsync(int lectorId);
        Task<ObservableCollection<Moment>> GetStudentMomentsAsync(int studentId);
    }
}
