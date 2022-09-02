using DigitalStudentCard.Core.Bootstrap;
using DigitalStudentCard.Core.ViewModels.QRCode;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DigitalStudentCard.Core.Views.QRCode
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QRCodePage : ContentPage
    {
        private readonly QRCodeViewModel _viewModel;

        public QRCodePage()
        {
            InitializeComponent();

            BindingContext = _viewModel =
                (QRCodeViewModel)AppContainer.Instance.Resolve(typeof(QRCodeViewModel));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}