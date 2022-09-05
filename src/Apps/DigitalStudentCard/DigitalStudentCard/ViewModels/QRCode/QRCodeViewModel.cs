using DigitalStudentCard.Core.DataStores.Contracts;
using System.Collections.Generic;
using System.Diagnostics;
using System;
using Xamarin.Forms;
using DigitalStudentCard.Core.Services.Contracts.General;
using Xamarin.Essentials;

namespace DigitalStudentCard.Core.ViewModels.QRCode
{
    [QueryProperty(nameof(UserNumber), nameof(UserNumber))]
    public class QRCodeViewModel : BaseViewModel
    {
        private int _userNumber;
        private ImageSource _qRCodeImage;
        private readonly IQRCodeService _qRCodeService = null;
        public QRCodeViewModel(IQRCodeService qRCodeService)
        {
            _qRCodeService = qRCodeService;
        }

        public int UserNumber
        {
            get
            {
                return _userNumber;
            }
            set
            {
                _userNumber = value;
                LoadUserNumber(value);
            }
        }

        public ImageSource QRCodeImage
        {
            get => _qRCodeImage;
            set => SetProperty(ref _qRCodeImage, value);
        }

        public void LoadUserNumber(int userNumber)
        {
            try
            {
                QRCodeImage = _qRCodeService.GenerateQRCode(userNumber.ToString());
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Generate QR Code");
            }
        }

    }
}