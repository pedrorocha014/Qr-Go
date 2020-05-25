using System;
using System.Windows.Forms;
using System.Drawing;
using QrHandler_WF.View.DownloadPage;
using QrHandler_WF.Presenter.DownloadPage;

namespace QrHandler_WF.Pages
{
    public partial class DownloadPage : UserControl, IDownloadPage
    {
        private string pathToSave;
        private Image dowloadImage;
        private DownloadPresenter presenter;

        public Image DownloadImage { get => dowloadImage; set => dowloadImage = value; }
        public string PathToSave {
            get {
                return pathToSave;
            }
            set
            {
                pathToSave = value;
                pathInputField.Text = pathToSave;
            }
        }

        public DownloadPage()
        {
            InitializeComponent();
            presenter = new DownloadPresenter(this);
        }

        private void downloadBtn_Click(object sender, EventArgs e)
        {
            presenter.ExecuteDownload();
        }

        private void folderSearchButton_Click(object sender, EventArgs e)
        {
            presenter.GetPathToDownload();
        }
    }
}
