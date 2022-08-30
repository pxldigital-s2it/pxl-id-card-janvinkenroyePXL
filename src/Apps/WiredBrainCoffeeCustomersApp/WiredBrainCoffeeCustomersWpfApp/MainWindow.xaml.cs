﻿using System.Windows;
using WiredBrainCoffee.AppWpf.ViewModel;
using WiredBrainCoffee.CustomersApp.Data;

namespace WiredBrainCoffee.CustomersApp
{
    public partial class MainWindow : Window
  {
    private readonly MainViewModel _viewModel;

    public MainWindow(MainViewModel viewModel)
    {
      InitializeComponent();
      _viewModel = viewModel;
      DataContext = _viewModel;
      Loaded += MainWindow_Loaded;
    }

    private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
    {
      await _viewModel.LoadAsync();
    }
  }
}
