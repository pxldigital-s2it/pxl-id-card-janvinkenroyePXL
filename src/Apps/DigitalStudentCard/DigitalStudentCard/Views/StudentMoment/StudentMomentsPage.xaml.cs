using DigitalStudentCard.Core.ViewModels;
using DigitalStudentCard.Core.ViewModels.StudentMoment;
using Xamarin.Forms;

namespace DigitalStudentCard.Core.Views.StudentMoment
{
    public partial class StudentMomentsPage : ContentPage
    {
        StudentMomentsViewModel _viewModel;

        public StudentMomentsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new StudentMomentsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}