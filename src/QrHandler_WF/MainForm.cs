using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QrHandler_WF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void createButton_Click(object sender, EventArgs e)
        {
            createPage.BringToFront();
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            PassImageBetweenPages();
            downloadPage.BringToFront();
        }

        private void PassImageBetweenPages()
        {
            downloadPage.DownloadImage = createPage.QRImage;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
