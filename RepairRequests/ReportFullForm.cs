using RepairRequests.model;
using RepairRequests.provider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairRequests
{
    public partial class ReportFullForm : Form
    {
        public int ReportId { get; set; }
        private ReportProvider reportProvider = new ReportProvider();
        private DetailProvider detailProvider = new DetailProvider();
        private RequestProvider provider = new RequestProvider();
        private UserProvider userProvider = new UserProvider(); 
        private CommentProvider commentProvider = new CommentProvider();

        public ReportFullForm()
        {
            InitializeComponent();
        }

        private void ReportFullForm_Load(object sender, EventArgs e)
        {
            Report report = reportProvider.GetAllReports().Where(R => R.Id == ReportId).FirstOrDefault();
            descWorkTxt.Text = report.Description;
            Request request = report.request;
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

            List<User> executors = userProvider.GetAllExecutorsByRequest(request.Id);

            foreach (User user in executors)
            {
                string userNum = user.PhoneNumber;
                string formatteduserNum = $"+7 ({userNum.Substring(1, 3)}) {userNum.Substring(4, 3)}-{userNum.Substring(7, 2)}-{userNum.Substring(9, 2)}";

                executorsView.Rows.Add(user.Name, formatteduserNum);
            }

            UpdateDetails(request.Id);
            UpdateComments(request.Id);
        }

        private void UpdateDetails(int RequestId)
        {
            detailsView.Rows.Clear();

            List<Details> details = detailProvider.GetByRequest(RequestId);

            foreach (Details detailsItem in details)
            {
                detailsView.Rows.Add(detailsItem.Title, detailsItem.Cost, detailsItem.Count);
            }
        }

        private void UpdateComments(int RequestId)
        {
            commentView.Rows.Clear();

            List<Comment> comments = commentProvider.GetCommentsByRequest(RequestId);

            foreach (Comment comment in comments)
            {
                commentView.Rows.Add(comment.Description);
            }
        }
    }
}
