﻿using DigitalStudentCard.Core.Enums;
using DigitalStudentCard.Core.Models;
using DigitalStudentCard.Core.Services;
using DigitalStudentCard.Core.Services.Data;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DigitalStudentCard.Core.ViewModels.LectorMoment
{
    [QueryProperty(nameof(MomentId), nameof(MomentId))]
    public class LectorMomentDetailViewModel : BaseViewModel
    {
        public IDataStore<Moment> DataStore => DependencyService.Get<IDataStore<Moment>>();
        private int momentId;
        private string name;
        private MomentType momentType;
        private DateTime date;
        private string location;
        public int Id { get; set; }
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
                var moment = await DataStore.GetAsync(momentId);
                Id = moment.Id;
                Name = moment.Name;
                momentType = moment.MomentType;
                Date = (DateTime)moment.Date;
                Location = moment.Location;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}
