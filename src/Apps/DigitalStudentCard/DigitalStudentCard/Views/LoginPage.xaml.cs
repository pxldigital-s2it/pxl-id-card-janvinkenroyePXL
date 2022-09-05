using DigitalStudentCard.Core.Bootstrap;
using DigitalStudentCard.Core.ViewModels;
using DigitalStudentCard.Core.ViewModels.StudentMoment;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DigitalStudentCard.Core.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        private readonly LoginViewModel _viewModel;

        public LoginPage()
        {
            InitializeComponent();

            BindingContext = _viewModel =
                (LoginViewModel)AppContainer.Instance.Resolve(typeof(LoginViewModel));
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}