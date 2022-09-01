using DigitalStudentCard.Core.ViewModels;
using DigitalStudentCard.Core.ViewModels.LectorMoment;
using Xamarin.Forms;

namespace DigitalStudentCard.Core.Views.LectorMoment
{
    public partial class LectorMomentDetailPage : ContentPage
    {
        public LectorMomentDetailPage()
        {
            InitializeComponent();
            BindingContext = new LectorMomentDetailViewModel();
        }
    }
}