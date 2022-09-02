using System.Threading.Tasks;

namespace DigitalStudentCard.Core.Services.Contracts.General
{
    public interface IAlertService
    {
        Task ShowAsync(string message);
    }
}
