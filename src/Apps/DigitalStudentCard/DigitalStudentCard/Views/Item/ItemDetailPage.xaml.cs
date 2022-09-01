using DigitalStudentCard.Core.Core.ViewModels;
using DigitalStudentCard.Core.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace DigitalStudentCard.Core.Views.Item
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}