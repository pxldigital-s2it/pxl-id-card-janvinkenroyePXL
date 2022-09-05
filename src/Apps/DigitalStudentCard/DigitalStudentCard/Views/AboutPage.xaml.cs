using DigitalStudentCard.Core.Bootstrap;
using DigitalStudentCard.Core.ViewModels;
using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DigitalStudentCard.Core.Views
{
    public partial class AboutPage : ContentPage
    {
        private readonly AboutViewModel _viewModel;

        public AboutPage()
        {
            InitializeComponent();

            BindingContext = _viewModel =
                (AboutViewModel)AppContainer.Instance.Resolve(typeof(AboutViewModel));
        }
    }
}