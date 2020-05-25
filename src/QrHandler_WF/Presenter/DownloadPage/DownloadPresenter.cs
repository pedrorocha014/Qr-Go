using QrHandler_WF.Model.DownloadPage;
using QrHandler_WF.View.DownloadPage;

namespace QrHandler_WF.Presenter.DownloadPage
{
    public class DownloadPresenter
    {
        IDownloadPage downloadView;
        private DownloadModel model = new DownloadModel();

        public DownloadPresenter(IDownloadPage view)
        {
            downloadView = view;
        }

        public void GetPathToDownload()
        {
            downloadView.PathToSave = model.GetPathToDownload();
        }

        public void ExecuteDownload()
        {
            DownloadModel model = new DownloadModel();
            model.ExecuteDownload(downloadView.DownloadImage, downloadView.PathToSave);
        }
    }
}
