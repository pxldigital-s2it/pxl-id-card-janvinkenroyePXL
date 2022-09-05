using DigitalStudentCard.Core.Enums;
using Xamarin.Essentials;

namespace DigitalStudentCard.Core.ViewModels
{
    public class AppShellViewModel : BaseViewModel
    {
        public bool IsStudent => Preferences.Get("Role", "Unknown") == Role.Student.ToString();
        public bool IsLector => Preferences.Get("Role", "Unknown") == Role.Lector.ToString();
    }
}
