using System;
using System.Windows.Forms;

namespace QrHandler_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            slider.Height = createButton.Height;
            slider.Top = createButton.Top;
            createPage.BringToFront();
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            slider.Height = downloadButton.Height;
            slider.Top = downloadButton.Top;
            PassImageBetweenPages();
            downloadPage.BringToFront();
        }

        private void PassImageBetweenPages()
        {
            downloadPage.ImageToSave = createPage.Image;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
