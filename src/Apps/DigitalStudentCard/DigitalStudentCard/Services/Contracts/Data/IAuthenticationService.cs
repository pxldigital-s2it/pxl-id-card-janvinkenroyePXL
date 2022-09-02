using DigitalStudentCard.Core.Models;
using System.Threading.Tasks;

namespace DigitalStudentCard.Core.Services.Contracts.Data
{
    internal interface IAuthenticationService
    {
        // Task<AuthenticationResponse> Register(string firstName, string lastName, string email, string userName, string password);
        Task<AuthenticationResponse> Authenticate(string userName, string password);
        bool IsUserAuthenticated();
    }
}
