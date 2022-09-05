using DigitalStudentCard.Core.Models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace DigitalStudentCard.Core.Services.Contracts.Data
{
    public interface IStudentDataService
    {
        Task<ObservableCollection<Student>> GetAbsentStudentsForMomentsAsync(int momentId);
    }
}
