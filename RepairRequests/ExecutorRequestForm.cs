using RepairRequests.model;
using RepairRequests.provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RepairRequests
{
    public partial class ExecutorRequestForm : Form
    {
        public User currentUser { get; set; }
        private RequestProvider requestProvider = new RequestProvider();
        private NotificationProvider notificationProvider = new NotificationProvider();
        private List<ShortRequest> requests;

        public ExecutorRequestForm()
        {
            InitializeComponent();
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
                    request.TypeOfRepair, request.Description, request.Status);
            }
        }

        private void UpdateRequests()
        {
            requestsView.Rows.Clear();
            requests = requestProvider.GetAllRequestsByExecutor(currentUser.Id);

            foreach (ShortRequest request in requests)
            {
                string endDate = request.EndDate.ToShortDateString();
                if (request.EndDate < DateTime.Now)
                {
                    endDate = "";
                }

                requestsView.Rows.Add(request.Id, request.CreationDate.ToShortDateString(), endDate, request.Equipment,
                    request.TypeOfRepair, request.Description, request.Status);
            }
        }

        private void requestsView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = requestsView.Rows[e.RowIndex];

            if (row.Cells != null)
            {
                ExecutorEditRequstForm addRequestForm = new ExecutorEditRequstForm();
                addRequestForm.UserId = currentUser.Id;
                addRequestForm.RequestId = (int)row.Cells["Id"].Value;
                addRequestForm.ShowDialog();
            }

            UpdateRequests();
        }

        private void ExecutorRequestForm_Load(object sender, EventArgs e)
        {
            UpdateRequests();
        }
    }
}
