using DigitalStudentCard.Core.Services.Contracts.General;
using QRCoder;
using System.IO;
using System.Threading.Tasks;
using Xamarin.Forms;
using ZXing.Mobile;

namespace DigitalStudentCard.Core.Services.General
{
    public class QRCodeService : IQRCodeService
    {
        private QRCodeGenerator _qrGenerator;
        public QRCodeService()
        {
            _qrGenerator = new QRCodeGenerator();
        }

        public ImageSource GenerateQRCode(string plainText)
        {
            var qrCodeData = _qrGenerator.CreateQrCode(plainText, QRCodeGenerator.ECCLevel.Q);
            PngByteQRCode qRCode = new PngByteQRCode(qrCodeData);
            byte[] qrCodeBytes = qRCode.GetGraphic(20);
            return ImageSource.FromStream(() => new MemoryStream(qrCodeBytes));
        }

        public async Task<string> ScanQRCode()
        {
            var scanningOptions = new MobileBarcodeScanningOptions();

            var scanner = new MobileBarcodeScanner()
            {
                TopText = "Scan the QR Code",
                BottomText = "Please Wait",
            };

            var scanResult = await scanner.Scan(scanningOptions);  
            return scanResult.Text;
        }
    }
}
