using RepairRequests.model;
using RepairRequests.provider;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RepairRequests
{
    public partial class ReportsListForm : Form
    {
        private RequestProvider requestProvider = new RequestProvider();
        private ReportProvider reportProvider = new ReportProvider();

        List<Report> reportList = new List<Report>();

        public ReportsListForm()
        {
            InitializeComponent();
        }

        private void ReportsListForm_Load(object sender, EventArgs e)
        {
            reportList = reportProvider.GetAllReports();

            foreach (Report report in reportList)
            {
                requestsView.Rows.Add(report.Id, report.DateFrom.ToShortDateString(), report.DateTo.ToShortDateString(), report.Description);
            }
        }

        private void requestsView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = requestsView.Rows[e.RowIndex];

            int id = int.Parse(row.Cells["Id"].Value.ToString());

            ReportFullForm reportFullForm = new ReportFullForm();
            reportFullForm.ReportId = id;
            reportFullForm.ShowDialog();
        }
    }
}
