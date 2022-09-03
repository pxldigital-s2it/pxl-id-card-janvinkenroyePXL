using System.Threading.Tasks;
using Xamarin.Forms;

namespace DigitalStudentCard.Core.Services.Contracts.General
{
    public interface IQRCodeService
    {
        ImageSource GenerateQRCode(string plainText);
        Task<string> ScanQRCode();
    }
}