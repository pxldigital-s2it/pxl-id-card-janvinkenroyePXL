using DigitalStudentCard.Core.Bootstrap;
using DigitalStudentCard.Core.ViewModels.LectorMoment;
using Xamarin.Forms;

namespace DigitalStudentCard.Core.Views.LectorMoment
{
    public partial class LectorMomentDetailPage : ContentPage
    {
        private readonly LectorMomentDetailViewModel _viewModel;

        public LectorMomentDetailPage()
        {
            InitializeComponent();

            BindingContext = _viewModel =
                (LectorMomentDetailViewModel)AppContainer.Instance.Resolve(typeof(LectorMomentDetailViewModel));
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}