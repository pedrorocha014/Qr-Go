using System.Drawing;
using QRCoder;

namespace QrHandler_WF.Model
{
    public class CreateModel
    {
        private QRCodeGenerator qrCodeGenerator;
        private QRCodeData qrCodeData;
        private QRCode qrCode;

        public Image GetQrCode(string content)
        {
            qrCodeGenerator = new QRCodeGenerator();
            qrCodeData = qrCodeGenerator.CreateQrCode(content, QRCodeGenerator.ECCLevel.Q);
            qrCode = new QRCode(qrCodeData);

            Image qrCodeImage = qrCode.GetGraphic(5);

            return qrCodeImage;
        }
    }
}
