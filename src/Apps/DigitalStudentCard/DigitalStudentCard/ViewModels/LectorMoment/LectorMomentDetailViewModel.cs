using DigitalStudentCard.Core.Enums;
using DigitalStudentCard.Core.Models;
using DigitalStudentCard.Core.Services.Contracts.Data;
using DigitalStudentCard.Core.Services.Contracts.General;
using DigitalStudentCard.Core.Views.QRCode;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using Xamarin.Forms;

namespace DigitalStudentCard.Core.ViewModels.LectorMoment
{
    [QueryProperty(nameof(MomentId), nameof(MomentId))]
    public class LectorMomentDetailViewModel : BaseViewModel
    {
        private IMomentDataService _momentDataService;
        private IStudentDataService _studentDataService;
        private IPresenceDataService _presenceDataService;
        private IQRCodeService _qRCodeService;

        private int momentId;
        private string name;
        private MomentType momentType;
        private DateTime date;
        private string location;
        private ICollection<Presence> presences;
        private ObservableCollection<Student> _absentStudents;
        
        public LectorMomentDetailViewModel(IMomentDataService momentDataService,
            IStudentDataService studentDataService,
            IPresenceDataService presenceDataService,
            IQRCodeService qRCodeService)
        {
            _momentDataService = momentDataService;
            _studentDataService = studentDataService;
            _presenceDataService = presenceDataService;
            _qRCodeService = qRCodeService;

            ScanQRCodeCommand = new Command(OnScanQRCode);
            ScanQRCodeBlancoCommand = new Command(OnScanQRCodeBlanco);
        }

        public Command ScanQRCodeCommand { get; }
        public Command ScanQRCodeBlancoCommand { get; }
        public int Id { get; set; }

        public ObservableCollection<Student> AbsentStudents
        {
            get => _absentStudents;
            set => SetProperty(ref _absentStudents, value);
        }

        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        public MomentType MomentType
        {
            get => momentType;
            set => SetProperty(ref momentType, value);
        }

        public DateTime Date
        {
            get => date;
            set => SetProperty(ref date, value);
        }

        public string Location
        {
            get => location;
            set => SetProperty(ref location, value);
        }

        public ICollection<Presence> Presences
        {
            get => presences;
            set => SetProperty(ref presences, value);
        }

        public int MomentId
        {
            get
            {
                return momentId;
            }
            set
            {
                momentId = value;
                LoadMomentId(value);
            }
        }

        public async void LoadMomentId(int momentId)
        {
            try
            {
                var moment = await _momentDataService.GetMomentAsync(momentId);
                Id = moment.Id;
                Name = moment.Name;
                momentType = moment.MomentType;
                Date = (DateTime)moment.Date;
                Location = moment.Location;
                Presences = moment.Presences;

                AbsentStudents = await _studentDataService.GetAbsentStudentsForMomentsAsync(momentId);
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }

        internal void OnAppearing()
        {
            // IsBusy = true;
        }

        private async void OnScanQRCode(object obj)
        {
            await Shell.Current.GoToAsync($"{nameof(QRScanningPage)}");
        }

        private async void OnScanQRCodeBlanco(object obj)
        {
            await Shell.Current.GoToAsync($"{nameof(QRScanningPage)}");
        }
    }
}
