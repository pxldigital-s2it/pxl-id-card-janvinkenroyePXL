using DigitalStudentCard.Core.Services;
using DigitalStudentCard.Core.Services.Data;
using Xamarin.Forms;

namespace DigitalStudentCard.Core
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockItemDataStore>();
            DependencyService.Register<MockPresenceDataStore>();
            DependencyService.Register<MockStudentDataStore>();
            DependencyService.Register<MockMomentDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
