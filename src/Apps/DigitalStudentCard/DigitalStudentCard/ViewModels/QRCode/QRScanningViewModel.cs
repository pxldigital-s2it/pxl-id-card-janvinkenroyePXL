﻿using DigitalStudentCard.Core.Models;
using DigitalStudentCard.Core.Services.Contracts.Data;
using DigitalStudentCard.Core.Services.Contracts.General;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing;

namespace DigitalStudentCard.Core.ViewModels.QRCode
{
    public class QRScanningViewModel : BaseViewModel
    {
        private readonly IQRCodeService _qRCodeService = null;
        private readonly IPresenceDataService _presenceDataService = null;
        private bool _isBlanco = false;
        public QRScanningViewModel(IQRCodeService qRCodeService, IPresenceDataService presenceDataService)
        {
            _qRCodeService = qRCodeService;
            _presenceDataService = presenceDataService;
        }

        public bool IsBlanco { get; set; }

        public async Task HandleScanResult(Result scanResult)
        {
            try
            {
                if (scanResult != null)
                {
                    var newPresence = new Presence
                    {
                        MomentId = 1, // momentId,
                        StudentId = int.Parse(scanResult.Text),
                        IsBlanco = IsBlanco
                    };
                    await _presenceDataService.AddPresence(newPresence);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }



    }
}
