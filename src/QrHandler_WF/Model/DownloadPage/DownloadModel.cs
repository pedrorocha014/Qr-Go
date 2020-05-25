using System.Drawing;
using System.Windows.Forms;

namespace QrHandler_WF.Model.DownloadPage
{
    public class DownloadModel
    {
        public string GetPathToDownload()
        {
            string path = "";

            using (FolderBrowserDialog openFolderDialog = new FolderBrowserDialog())
            {
                openFolderDialog.ShowDialog();
                path = openFolderDialog.SelectedPath;
            }

            return path;
        }

        public void ExecuteDownload(Image image, string path)
        {
            image.Save(path + "\\qrCode.png");
            DialogResult info = MessageBox.Show("Image saved successfully.", "Confirmation message.", MessageBoxButtons.OK);
        }
    }
}
