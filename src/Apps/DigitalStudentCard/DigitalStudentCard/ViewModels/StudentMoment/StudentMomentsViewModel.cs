using DigitalStudentCard.Core.Models;
using DigitalStudentCard.Core.Services.Contracts.Data;
using DigitalStudentCard.Core.ViewModels.QRCode;
using DigitalStudentCard.Core.Views.QRCode;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DigitalStudentCard.Core.ViewModels.StudentMoment
{
    public class StudentMomentsViewModel : BaseViewModel
    {
        private IMomentDataService _momentDataService;
        private ObservableCollection<Moment> _moments;
       
        public StudentMomentsViewModel(IMomentDataService momentDataService)
        {
            _momentDataService = momentDataService;
            Title = "Browse";
            Moments = new ObservableCollection<Moment>();
            LoadMomentsCommand = new Command(async () => await ExecuteLoadMomentsCommand());

            ShowQRCodeCommand = new Command<Moment>(OnShowQRCode);
        }
        public ObservableCollection<Moment> Moments
        {
            get => _moments;
            set => SetProperty(ref _moments, value);
        }
        public Command LoadMomentsCommand { get; }
        public Command ShowQRCodeCommand { get; }
        public Command<Moment> MomentTapped { get; }

        async Task ExecuteLoadMomentsCommand()
        {
            IsBusy = true;

            try
            {
                var userNumber = Preferences.Get("UserNumber", 0);
                Moments = await _momentDataService.GetStudentMomentsAsync(userNumber);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }

        private async void OnShowQRCode(object obj)
        {
            var userNumber = Preferences.Get("UserNumber", 0);
            await Shell.Current.GoToAsync($"{nameof(QRCodePage)}?{nameof(QRCodeViewModel.UserNumber)}={userNumber}");
        }
    }
}