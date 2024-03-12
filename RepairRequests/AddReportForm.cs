using RepairRequests.provider;
using System;
using System.Windows.Forms;

namespace RepairRequests
{
    public partial class AddReportForm : Form
    {
        public int RequestId { get; set; }
        private ReportProvider reportProvider = new ReportProvider();
        private NotificationProvider notificationProvider = new NotificationProvider();

        public AddReportForm()
        {
            InitializeComponent();
        }

        private void addReportBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(descriptionTxt.Text))
            {
                MessageBox.Show("Укажите отчет");
                return;
            }

            reportProvider.CreateReport(RequestId, descriptionTxt.Text);
            notificationProvider.SaveNotification(RequestId);

            Close();
        }
    }
}
