using DigitalStudentCard.Core.ViewModels;
using DigitalStudentCard.Core.Views;
using DigitalStudentCard.Core.Views.Item;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace DigitalStudentCard.Core
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
