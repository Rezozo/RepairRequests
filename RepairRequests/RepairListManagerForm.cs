using RepairRequests.model;
using RepairRequests.provider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RepairRequests
{
    public partial class RepairListManagerForm : Form
    {
        public User currentUser { get; set; }
        private RequestProvider requestProvider = new RequestProvider();
        private List<ShortRequest> requests;

        public RepairListManagerForm()
        {
            InitializeComponent();
        }

        private void RepairListManagerForm_Load(object sender, EventArgs e)
        {
            UpdateRequests();
        }

        private void searchTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            string searchText = searchTxt.Text;
            if (string.IsNullOrWhiteSpace(searchText))
            {
                UpdateRequests();
                return;
            }

            requestsView.Rows.Clear();

            List<ShortRequest> newRequests = requests
                .Where(p => p.Status.Contains(searchText) ||
                p.Description.Contains(searchText) ||
                p.Equipment.Contains(searchText))
                .ToList();

            foreach (ShortRequest request in newRequests)
            {
                string endDate = request.EndDate.ToShortDateString();
                if (request.EndDate < DateTime.Now)
                {
                    endDate = "";
                }
                requestsView.Rows.Add(request.Id, request.CreationDate.ToShortDateString(), endDate, request.Equipment,
                    request.TypeOfRepair, request.Description, request.Status, request.SenderId);
            }
        }

        private void UpdateRequests()
        {
            requestsView.Rows.Clear();
            requests = requestProvider.GetAllRequests();

            foreach (ShortRequest request in requests)
            {
                string endDate = request.EndDate.ToShortDateString();
                if (request.EndDate < DateTime.Now)
                {
                    endDate = "";
                }

                requestsView.Rows.Add(request.Id, request.CreationDate.ToShortDateString(), endDate, request.Equipment,
                    request.TypeOfRepair, request.Description, request.Status, request.SenderId);
            }
        }

        private void requestsView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = requestsView.Rows[e.RowIndex];

            if (row.Cells != null)
            {
                switch (row.Cells["Status"].Value.ToString())
                {
                    case "В ожидании":
                        RequestRegistrationForm requestRegistrationForm = new RequestRegistrationForm();
                        requestRegistrationForm.UserId = currentUser.Id;
                        requestRegistrationForm.RequestId = (int)row.Cells["Id"].Value;
                        requestRegistrationForm.Equipment = (string)row.Cells["Equipment"].Value;
                        requestRegistrationForm.Description = (string)row.Cells["Description"].Value;
                        requestRegistrationForm.TypeName = (string)row.Cells["TypeRepair"].Value;
                        requestRegistrationForm.SenderId = (int)row.Cells["SenderId"].Value;
                        requestRegistrationForm.ShowDialog();
                        break;
                    case "В работе":
                        ManagerEditRequestForm managerEdit = new ManagerEditRequestForm();
                        managerEdit.UserId = currentUser.Id;
                        managerEdit.RequestId = (int)row.Cells["Id"].Value;
                        managerEdit.ShowDialog();
                        break;
                    default:
                        MessageBox.Show("Заявка уже выполнена");
                        return;
                }
            }
            UpdateRequests();
        }

        private void statisticBtn_Click(object sender, EventArgs e)
        {
            StatisticForm statistic = new StatisticForm();
            statistic.ShowDialog();
        }

        private void allReportsBtn_Click(object sender, EventArgs e)
        {
            ReportsListForm reportsListForm = new ReportsListForm();
            reportsListForm.ShowDialog();
        }
    }
}
