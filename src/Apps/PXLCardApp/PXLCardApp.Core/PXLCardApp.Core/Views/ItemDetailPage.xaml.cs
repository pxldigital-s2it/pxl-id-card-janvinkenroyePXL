using PXLCardApp.Core.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace PXLCardApp.Core.Views
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