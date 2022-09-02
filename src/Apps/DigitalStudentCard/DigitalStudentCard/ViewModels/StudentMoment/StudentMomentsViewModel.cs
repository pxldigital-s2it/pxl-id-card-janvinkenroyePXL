using DigitalStudentCard.Core.DataStores.Contracts;
using DigitalStudentCard.Core.Models;
using DigitalStudentCard.Core.Views.StudentMoment;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DigitalStudentCard.Core.ViewModels.StudentMoment
{
    public class StudentMomentsViewModel : BaseViewModel
    {
        public IDataStore<Moment> DataStore => DependencyService.Get<IDataStore<Moment>>();
        public ObservableCollection<Moment> Moments { get; }
        public Command LoadMomentsCommand { get; }
        public Command ShowQRCodeCommand { get; }
        public StudentMomentsViewModel()
        {
            Title = "Browse";
            Moments = new ObservableCollection<Moment>();
            LoadMomentsCommand = new Command(async () => await ExecuteLoadMomentsCommand());

            ShowQRCodeCommand = new Command(OnShowQRCode);
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
        }

        private async void OnShowQRCode(object obj)
        {
            await Shell.Current.GoToAsync($"{nameof(QRCodePage)}");
        }
    }
}