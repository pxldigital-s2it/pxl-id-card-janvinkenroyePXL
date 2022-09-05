using DigitalStudentCard.Core.Enums;
using DigitalStudentCard.Core.Models;
using DigitalStudentCard.Core.Services.Contracts.Data;
using DigitalStudentCard.Core.Services.Contracts.General;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing;

namespace DigitalStudentCard.Core.ViewModels.QRCode
{
    [QueryProperty(nameof(IsBlanco), nameof(IsBlanco))]
    [QueryProperty(nameof(MomentId), nameof(MomentId))]
    public class QRScanningViewModel : BaseViewModel
    {
        private readonly IQRCodeService _qRCodeService = null;
        private readonly IPresenceDataService _presenceDataService = null;
        private bool _isBlanco = false;
        private int _momentId;
        public QRScanningViewModel(IQRCodeService qRCodeService, IPresenceDataService presenceDataService)
        {
            _qRCodeService = qRCodeService;
            _presenceDataService = presenceDataService;
        }

        public bool IsBlanco
        {
            get
            {
                return _isBlanco;
            }
            set
            {
                _isBlanco = value;
            }
        }

        public int MomentId
        {
            get
            {
                return _momentId;
            }
            set
            {
                _momentId = value;
            }
        }

        public async Task HandleScanResult(Result scanResult)
        {
            try
            {
                if (scanResult != null)
                {
                    var newPresence = new Presence
                    {
                        MomentId = MomentId,
                        StudentId = int.Parse(scanResult.Text),
                        IsBlanco = IsBlanco
                    };
                    await _presenceDataService.AddPresence(newPresence);
                    MessagingCenter.Send<QRScanningViewModel, Presence>(this, "PresenceAdded", newPresence);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }



    }
}
