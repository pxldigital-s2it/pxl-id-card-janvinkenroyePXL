using DigitalStudentCard.Core.Bootstrap;
using DigitalStudentCard.Core.ViewModels;
using DigitalStudentCard.Core.ViewModels.StudentMoment;
using Xamarin.Forms;

namespace DigitalStudentCard.Core.Views.StudentMoment
{
    public partial class StudentMomentsPage : ContentPage
    {
        private readonly StudentMomentsViewModel _viewModel;

        public StudentMomentsPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new StudentMomentsViewModel();

            // BindingContext = AppContainer.Instance.Resolve(_viewModel.GetType());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}