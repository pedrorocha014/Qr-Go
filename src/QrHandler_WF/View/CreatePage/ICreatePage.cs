using System.Drawing;

namespace QrHandler_WF.View
{
    public interface ICreatePage
    {
        string QRContent { get; }
        Image QRImage { get; set; }
    }
}
