using StudentCardXamarinFormsApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace StudentCardXamarinFormsApp.Views
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