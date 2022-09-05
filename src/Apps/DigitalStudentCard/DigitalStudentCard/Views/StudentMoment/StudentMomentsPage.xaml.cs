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

            BindingContext = _viewModel = 
                (StudentMomentsViewModel)AppContainer.Instance.Resolve(typeof(StudentMomentsViewModel));
        }

        
        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
        
    }
}