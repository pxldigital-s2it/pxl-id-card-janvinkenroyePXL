using DigitalStudentCard.Core.DataStores.Contracts;
using DigitalStudentCard.Core.Models;
using DigitalStudentCard.Core.Services;
using DigitalStudentCard.Core.Views;
using DigitalStudentCard.Core.Views.LectorMoment;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DigitalStudentCard.Core.ViewModels.LectorMoment
{
    public class LectorMomentsViewModel : BaseViewModel
    {
        public IDataStore<Moment> DataStore => DependencyService.Get<IDataStore<Moment>>();
        private Moment _selectedMoment;
        public ObservableCollection<Moment> Moments { get; }
        public Command LoadMomentsCommand { get; }
        public Command ScanQRCodeCommand { get; }
        public Command<Moment> MomentTapped { get; }

        public LectorMomentsViewModel()
        {
            Title = "Browse";
            Moments = new ObservableCollection<Moment>();
            LoadMomentsCommand = new Command(async () => await ExecuteLoadMomentsCommand());

            MomentTapped = new Command<Moment>(OnMomentSelected);

            ScanQRCodeCommand = new Command(OnScanQRCode);
        }

        async Task ExecuteLoadMomentsCommand()
        {
            IsBusy = true;

            try
            {
                Moments.Clear();
                var moments = await DataStore.GetAllAsync(true);
                foreach (var moment in moments)
                {
                    Moments.Add(moment);
                }
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
        
        private void OnAddMoment(object obj)
        {
            // await Shell.Current.GoToAsync(nameof(ShowQRCodePage));
        }

        async void OnMomentSelected(Moment moment)
        {
            if (moment == null)
                return;

            // This will push the MomentDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(LectorMomentDetailPage)}?{nameof(LectorMomentDetailViewModel.MomentId)}={moment.Id}");
        }
        private void OnScanQRCode(object obj)
        {
            // await Shell.Current.GoToAsync(nameof(ScanQRCodePage));
        }
    }
}