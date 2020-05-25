using System.Drawing;

namespace QrHandler_WF.View.DownloadPage
{
    public interface IDownloadPage
    {
        string PathToSave { get; set; }
        Image DownloadImage { get; set; }
    }
}
