using DigitalStudentCard.Core.ViewModels;
using DigitalStudentCard.Core.ViewModels.LectorMoment;
using Xamarin.Forms;

namespace DigitalStudentCard.Core.Views.LectorMoment
{
    public partial class LectorMomentsPage : ContentPage
    {
        private readonly LectorMomentsViewModel _viewModel;

        public LectorMomentsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new LectorMomentsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}