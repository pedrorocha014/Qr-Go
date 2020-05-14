using System;
using System.Windows.Forms;
using System.Drawing;

namespace QrHandler_WF.Pages
{
    public partial class DownloadPage : UserControl
    {
        private string path;

        private Image imageToSave;

        #region"Properties"
        public Image ImageToSave
        {
            get { return imageToSave; }
            set { imageToSave = value; }
        }
        #endregion

        public DownloadPage()
        {
            InitializeComponent();
        }

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                imageToSave.Save(path + "\\qrCode.png");
                DialogResult info = MessageBox.Show("Image saved successfully.", "Confirmation message.", MessageBoxButtons.OK);
            }
            catch (Exception)
            {
                DialogResult info = MessageBox.Show("Enter the location where you want to save the image.", "Lack of argument.", MessageBoxButtons.OK);
            }
        }

        private void folderSearchButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog openFolderDialog = new FolderBrowserDialog())
            {
                openFolderDialog.ShowDialog();
                path = openFolderDialog.SelectedPath;
                pathInputField.Text = path;
            }
        }
    }
}
