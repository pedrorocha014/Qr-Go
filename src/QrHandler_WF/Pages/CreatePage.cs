using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using QRCoder;

namespace QrHandler_WF.Pages
{
    public partial class CreatePage : UserControl
    {
        private QRCodeGenerator qrCodeGenerator;
        private QRCodeData qrCodeData;
        private QRCode qrCode;

        private Image image;

        #region"Properties"
        [Category("QR Code")]
        public Image Image
        {
            get { return image; }
            set { image = value; pictureBox1.Image = value; }
        }
        #endregion

        public CreatePage()
        {
            InitializeComponent();
        }

        private void createQrButton_Click(object sender, EventArgs e)
        {
            try
            {
                qrCodeGenerator = new QRCodeGenerator();
                qrCodeData = qrCodeGenerator.CreateQrCode(contentInputField.Text, QRCodeGenerator.ECCLevel.Q);
                qrCode = new QRCode(qrCodeData);

                Image qrCodeImage = qrCode.GetGraphic(5);
                Image = qrCodeImage;
            }
            catch (Exception)
            {
                DialogResult info = MessageBox.Show("Enter the content of the QR Code.", "Lack of argument.", MessageBoxButtons.OK);
            }
        }
    }
}
