using DigitalStudentCard.Core.Models;
using DigitalStudentCard.Core.Services.Contracts.Data;
using DigitalStudentCard.Core.Views.LectorMoment;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace DigitalStudentCard.Core.ViewModels.LectorMoment
{
    public class LectorMomentsViewModel : BaseViewModel
    {
        private IMomentDataService _momentDataService;
        private Moment _selectedMoment;
        private ObservableCollection<Moment> _moments;
       
        public LectorMomentsViewModel(IMomentDataService momentDataService)
        {
            _momentDataService = momentDataService;
            Title = "Browse";
            Moments = new ObservableCollection<Moment>();
            LoadMomentsCommand = new Command(async () => await ExecuteLoadMomentsCommand());

            MomentTapped = new Command<Moment>(OnMomentSelected);
        }
        public ObservableCollection<Moment> Moments
        {
            get => _moments;
            set => SetProperty(ref _moments, value);
        }
        public Command LoadMomentsCommand { get; }
        
        public Command<Moment> MomentTapped { get; }

        async Task ExecuteLoadMomentsCommand()
        {
            IsBusy = true;

            try
            {
                var userNumber = Preferences.Get("UserNumber", 0);
                Moments = await _momentDataService.GetLectorMomentsAsync(userNumber);
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
            SelectedMoment = null;
        }

        public Moment SelectedMoment
        {
            get => _selectedMoment;
            set
            {
                SetProperty(ref _selectedMoment, value);
                OnMomentSelected(value);
            }
        }
        
        async void OnMomentSelected(Moment moment)
        {
            if (moment == null)
                return;

            await Shell.Current.GoToAsync($"{nameof(LectorMomentDetailPage)}?{nameof(LectorMomentDetailViewModel.MomentId)}={moment.Id}");
        }
    }
}