using RepairRequests.model;
using RepairRequests.provider;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RepairRequests
{
    public partial class ManagerEditRequestForm : Form
    {
        public int UserId { get; set; }
        public int RequestId { get; set; }

        private RequestProvider provider = new RequestProvider();
        private UserProvider userProvider = new UserProvider();

        public ManagerEditRequestForm()
        {
            InitializeComponent();
        }

        private void ManagerEditRequestForm_Load(object sender, EventArgs e)
        {
            Request request = provider.GetFullInfoById(RequestId);
            equipmentTxt.Text = request.Equipment;
            typeBox.Text = request.TypeOfRepair;
            descriptionTxt.Text = request.Description;
            executorBox.Text = request.Executor.Name;
            priorityBox.Text = request.Priority;
            endDatePick.Value = request.EndDate;

            fullNameTxt.Text = request.Sender.Name;

            string phoneNumber = request.Sender.PhoneNumber;
            string formattedPhoneNumber = $"+7 ({phoneNumber.Substring(1, 3)}) {phoneNumber.Substring(4, 3)}-{phoneNumber.Substring(7, 2)}-{phoneNumber.Substring(9, 2)}";
            phoneNumberTxt.Text = formattedPhoneNumber;

            UpdateExecutors();
        }

        public void UpdateExecutors()
        {
            executorsView.Rows.Clear();
            List<User> executors = userProvider.GetAllExecutorsByRequest(RequestId);

            foreach (User user in executors)
            {
                string phoneNumber = user.PhoneNumber;
                string formattedPhoneNumber = $"+7 ({phoneNumber.Substring(1, 3)}) {phoneNumber.Substring(4, 3)}-{phoneNumber.Substring(7, 2)}-{phoneNumber.Substring(9, 2)}";

                executorsView.Rows.Add(user.Name, formattedPhoneNumber);
            }
        }

        private void executorsView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = executorsView.Rows[e.RowIndex];

            DialogResult result = MessageBox.Show("Вы хотите удалить этого исполнителя?", "Удаление", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                userProvider.DeleteExecutor(RequestId, row.Cells["FullName"].Value.ToString());
                UpdateExecutors();
            }
        }

        private void addExecutor_Click(object sender, EventArgs e)
        {
            AddDetailForm addDetail = new AddDetailForm();
            addDetail.RequestId = RequestId;
            addDetail.ShowDialog();
            UpdateExecutors();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            provider.UpdateEndData(RequestId, endDatePick.Value);
            MessageBox.Show("Данные успешно обновлены");
            Close();
        }
    }
}
