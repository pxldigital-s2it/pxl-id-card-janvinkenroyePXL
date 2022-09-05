using DigitalStudentCard.Core.Services.Contracts.General;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DigitalStudentCard.Core.Services.General
{
    internal class AlertService : IAlertService
    {
        public async Task ShowAsync(string message)
        {
            await App.Current.MainPage.DisplayAlert("DigitalStudentCard", message, "Ok");
        }
    }
}
