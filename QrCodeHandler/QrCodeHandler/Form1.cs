using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QrCodeHandler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void CreateBtnClicked(object sender, EventArgs e)
        {
            slider.Height = createBtn.Height;
            slider.Top = createBtn.Top;
        }
        public void DownloadBtnClicked(object sender, EventArgs e)
        {
            slider.Height = downloadBtn.Height;
            slider.Top = downloadBtn.Top;
        }

        public void CloseApp(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
