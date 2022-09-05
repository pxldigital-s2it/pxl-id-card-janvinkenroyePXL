using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DigitalStudentCard.Core.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://github.com/pxldigital-s2it/pxl-id-card-janvinkenroyePXL"));
        }

        public ICommand OpenWebCommand { get; }
    }
}