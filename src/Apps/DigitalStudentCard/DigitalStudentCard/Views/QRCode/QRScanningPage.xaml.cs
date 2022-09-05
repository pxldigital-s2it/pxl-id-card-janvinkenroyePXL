using DigitalStudentCard.Core.Bootstrap;
using DigitalStudentCard.Core.ViewModels.QRCode;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing;
using ZXing.Net.Mobile.Forms;

namespace DigitalStudentCard.Core.Views.QRCode
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QRScanningPage : ZXingScannerPage
    {
        private readonly QRScanningViewModel _viewModel;
        public QRScanningPage()
        {
            InitializeComponent();

            BindingContext = _viewModel =
                (QRScanningViewModel)AppContainer.Instance.Resolve(typeof(QRScanningViewModel));
        }

        public void Handle_OnScanResult(Result result)
        {
            // await _viewModel.HandleScanResult(result);
        }
    }
}