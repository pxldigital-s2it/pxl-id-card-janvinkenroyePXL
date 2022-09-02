using DigitalStudentCard.Core.Core.ViewModels;
using Xamarin.Forms;

namespace DigitalStudentCard.Core.Views.Item
{
    public partial class NewItemPage : ContentPage
    {
        public Models.Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}