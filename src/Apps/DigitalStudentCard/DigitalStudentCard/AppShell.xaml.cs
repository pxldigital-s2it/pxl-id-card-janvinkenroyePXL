using DigitalStudentCard.Core.Bootstrap;
using DigitalStudentCard.Core.ViewModels;
using DigitalStudentCard.Core.Views;
using DigitalStudentCard.Core.Views.LectorMoment;
using DigitalStudentCard.Core.Views.QRCode;
using DigitalStudentCard.Core.Views.StudentMoment;
using System;
using Xamarin.Forms;

namespace DigitalStudentCard.Core
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(LectorMomentDetailPage), typeof(LectorMomentDetailPage));
            Routing.RegisterRoute(nameof(QRCodePage), typeof(QRCodePage));
            Routing.RegisterRoute(nameof(LectorMomentsPage), typeof(LectorMomentsPage));
            Routing.RegisterRoute(nameof(StudentMomentsPage), typeof(StudentMomentsPage));
            Routing.RegisterRoute(nameof(QRScanningPage), typeof(QRScanningPage));
            Routing.RegisterRoute(nameof(AboutPage), typeof(AboutPage));
            Routing.RegisterRoute(nameof(AppShell), typeof(AppShell));

            BindingContext =
                (AppShellViewModel)AppContainer.Instance.Resolve(typeof(AppShellViewModel));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
