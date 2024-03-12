using RepairRequests.model;
using RepairRequests.provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RepairRequests
{
    public partial class RequestListForm : Form
    {
        public User currentUser { get; set; }
        private RequestProvider requestProvider = new RequestProvider();
        private NotificationProvider notificationProvider = new NotificationProvider();
        private List<ShortRequest> requests;
        public RequestListForm()
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
                if (request.EndDate <  DateTime.Now)
                {
                    endDate = "";
                }
                requestsView.Rows.Add(request.Id, request.CreationDate.ToShortDateString(), endDate, request.Equipment,
                    request.TypeOfRepair, request.Description, request.Status);
            }
        }

        private void RequestListForm_Load(object sender, EventArgs e)
        {
            if (currentUser.Role == "Клиент")
            {
                progressRequestBtn.Visible = false;
            } else
            {
                quizBtn.Visible = false;
            }

            UpdateRequests();
        }

        private void UpdateRequests()
        {
            requestsView.Rows.Clear();
            requests = requestProvider.GetAllRequestsByUser(currentUser.Id);
           
            foreach(ShortRequest request in requests)
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

        private void addRequest_Click(object sender, EventArgs e)
        {
            AddRequestForm addRequest = new AddRequestForm();
            addRequest.UserId = currentUser.Id;
            addRequest.ShowDialog();

            UpdateRequests();
        }

        private void requestsView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = requestsView.Rows[e.RowIndex];

            if (row.Cells != null)
            {
                if (!row.Cells["Status"].Value.ToString().Equals("В ожидании"))
                {
                    MessageBox.Show("Нельзя менять заявку, которая не в статусе \"В ожидании\"");
                    return;
                }

                AddRequestForm addRequestForm = new AddRequestForm();
                addRequestForm.UserId = currentUser.Id;
                addRequestForm.RequestId = (int)row.Cells["Id"].Value;
                addRequestForm.Equipment = (string)row.Cells["Equipment"].Value;
                addRequestForm.Description = (string)row.Cells["Description"].Value;
                addRequestForm.TypeName = (string)row.Cells["TypeRepair"].Value;
                addRequestForm.ShowDialog();
            }

            UpdateRequests();
        }

        private void progressRequestBtn_Click(object sender, EventArgs e)
        {
            ExecutorRequestForm executorRequestForm = new ExecutorRequestForm();
            executorRequestForm.currentUser = currentUser;
            executorRequestForm.ShowDialog();
        }

        private void getNotificationBtn_Click(object sender, EventArgs e)
        {
            List<Notification> notifications = notificationProvider.GetAllNotificationByRequest(currentUser.Id);

            if (notifications.Count == 0)
            {
                MessageBox.Show("Статус ни одной заявки не был обновлен");
                return;
            }

            foreach (Notification notification in notifications)
            {
                MessageBox.Show($"Обновлен статус у заявки №{notification.Id}, новый статус: {notification.Status}");
                notificationProvider.DeleteNotification(notification.Id);
            }
        }

        private void quizBtn_Click(object sender, EventArgs e)
        {
            QrCodeForm qrCodeForm = new QrCodeForm();
            qrCodeForm.ShowDialog();
        }
    }
}
