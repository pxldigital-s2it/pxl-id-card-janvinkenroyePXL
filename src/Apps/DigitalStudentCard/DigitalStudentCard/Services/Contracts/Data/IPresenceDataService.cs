using DigitalStudentCard.Core.Models;
using System.Threading.Tasks;

namespace DigitalStudentCard.Core.Services.Contracts.Data
{
    public interface IPresenceDataService
    {
        Task<Presence> AddPresence(Presence presence);
    }
}
