﻿using System;
using System.Drawing;
using System.Windows.Forms;
using QRCoder;
using QrHandler_WF.Presenter;
using QrHandler_WF.View;

namespace QrHandler_WF.Pages
{
    public partial class CreatePage : UserControl, ICreatePage
    {
        public string QRContent => contentInputField.Text;
        public Image QRImage { get => pictureBox1.Image; set => ChangeQrImage (value); }

        public CreatePage()
        {
            InitializeComponent();
        }

        private void createQrButton_Click(object sender, EventArgs e)
        {
            CreatePresenter presenter = new CreatePresenter(this);
            presenter.GetQrCode();
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void ChangeQrImage(Image image)
        {
            pictureBox1.Image = image;
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }
    }
}
