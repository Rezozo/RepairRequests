using MessagingToolkit.QRCode.Codec;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RepairRequests
{
    public partial class QrCodeForm : Form
    {
        public QrCodeForm()
        {
            InitializeComponent();
        }

        private void QrCodeForm_Load(object sender, EventArgs e)
        {
            string url = "https://www.google.ru/forms/about/";

            QRCodeEncoder encoder = new QRCodeEncoder();
            Bitmap qrcode = encoder.Encode(url);

            qrCodeBox.Image = qrcode;
        }
    }
}
