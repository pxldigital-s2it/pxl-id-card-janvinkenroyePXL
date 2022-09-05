using DigitalStudentCard.Core.Bootstrap;
using DigitalStudentCard.Core.DataStores;
using Xamarin.Forms;

namespace DigitalStudentCard.Core
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            AppContainer.Instance.RegisterDependencies();
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
