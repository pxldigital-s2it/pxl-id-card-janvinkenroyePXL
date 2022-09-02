using DigitalStudentCard.Core.Bootstrap;
using DigitalStudentCard.Core.ViewModels;
using DigitalStudentCard.Core.ViewModels.LectorMoment;
using DigitalStudentCard.Core.ViewModels.StudentMoment;
using Xamarin.Forms;

namespace DigitalStudentCard.Core.Views.LectorMoment
{
    public partial class LectorMomentsPage : ContentPage
    {
        private readonly LectorMomentsViewModel _viewModel;

        public LectorMomentsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel =
                (LectorMomentsViewModel)AppContainer.Instance.Resolve(typeof(LectorMomentsViewModel));
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}