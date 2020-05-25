using QrHandler_WF.Model;
using QrHandler_WF.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrHandler_WF.Presenter
{
    public class CreatePresenter
    {
        ICreatePage createPage;

        public CreatePresenter(ICreatePage view)
        {
            createPage = view;
        }

        public void GetQrCode()
        {
            CreateModel model = new CreateModel();

            createPage.QRImage = model.GetQrCode(createPage.QRContent);
        }
    }
}
