﻿using DigitalStudentCard.Core.Core.ViewModels;
using DigitalStudentCard.Core.ViewModels;
using Xamarin.Forms;

namespace DigitalStudentCard.Core.Views.Item
{
    public partial class ItemsPage : ContentPage
    {
        readonly ItemsViewModel _viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ItemsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}