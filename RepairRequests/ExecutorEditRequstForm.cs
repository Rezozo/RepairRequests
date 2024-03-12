using RepairRequests.model;
using RepairRequests.provider;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RepairRequests
{
    public partial class ExecutorEditRequstForm : Form
    {
        public int UserId { get; set; }
        public int RequestId { get; set; }

        private RequestProvider provider = new RequestProvider();
        private UserProvider userProvider = new UserProvider();
        private CommentProvider commentProvider = new CommentProvider();
        private DetailProvider detailProvider = new DetailProvider();

        public ExecutorEditRequstForm()
        {
            InitializeComponent();
        }

        private void ExecutorEditRequstForm_Load(object sender, System.EventArgs e)
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

            List<User> executors = userProvider.GetAllExecutorsByRequest(RequestId);

            foreach (User user in executors)
            {
                string userNum = user.PhoneNumber;
                string formatteduserNum = $"+7 ({userNum.Substring(1, 3)}) {userNum.Substring(4, 3)}-{userNum.Substring(7, 2)}-{userNum.Substring(9, 2)}";

                executorsView.Rows.Add(user.Name, formatteduserNum);
            }

            UpdateDetails();
            UpdateComments();
        }

        private void UpdateDetails()
        {
            detailsView.Rows.Clear();

            List<Details> details = detailProvider.GetByRequest(RequestId);

            foreach(Details detailsItem in details)
            {
                detailsView.Rows.Add(detailsItem.Title, detailsItem.Cost, detailsItem.Count);
            }
        }

        private void UpdateComments()
        {
            commentView.Rows.Clear();

            List<Comment> comments = commentProvider.GetCommentsByRequest(RequestId);

            foreach (Comment comment in comments)
            {
                commentView.Rows.Add(comment.Description);
            }
        }

        private void addDetailsBtn_Click(object sender, System.EventArgs e)
        {
            AddOneDetailForm addOneDetailForm = new AddOneDetailForm();
            addOneDetailForm.RequestId = RequestId; 
            addOneDetailForm.ShowDialog();
            UpdateDetails();
        }

        private void addCommentsBtn_Click(object sender, System.EventArgs e)
        {
            AddCommentForm addCommentForm = new AddCommentForm();
            addCommentForm.RequestId = RequestId;
            addCommentForm.ShowDialog();
            UpdateComments();
        }

        private void closeWindowBtn_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void detailsView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = executorsView.Rows[e.RowIndex];

            DialogResult result = MessageBox.Show("Вы хотите удалить этого исполнителя?", "Удаление", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                detailProvider.DeleteDetail(1);
                UpdateDetails();
            }
        }

        private void saveBtn_Click(object sender, System.EventArgs e)
        {
            AddReportForm addReportForm = new AddReportForm();
            addReportForm.RequestId = RequestId;
            addReportForm.ShowDialog();

            Close();
        }
    }
}
