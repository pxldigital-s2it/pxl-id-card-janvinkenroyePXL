using DigitalStudentCard.Core.Models;
using DigitalStudentCard.Core.Services.Contracts.Data;
using DigitalStudentCard.Core.ViewModels.QRCode;
using DigitalStudentCard.Core.Views.QRCode;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
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

            MomentTapped = new Command<Moment>(OnShowQRCode);
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
                Moments = await _momentDataService.GetStudentMomentsAsync(1);
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
            await Shell.Current.GoToAsync($"{nameof(QRCodePage)}?{nameof(QRCodeViewModel.UserNumber)}=1");
        }
    }
}