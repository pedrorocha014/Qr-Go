using System;
using System.Windows.Forms;
using QrHandler_WF.Scripts;
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
            }
            catch (Exception)
            {
                DialogResult info = MessageBox.Show("Informe o local onde deseja salvar a imagem.", "Falta de argumento.", MessageBoxButtons.OK);
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
