using RepairRequests.provider;
using System;
using System.Windows.Forms;

namespace RepairRequests
{
    public partial class AddCommentForm : Form
    {
        public int RequestId { get; set; }
        private CommentProvider commentProvider;

        public AddCommentForm()
        {
            InitializeComponent();
        }

        private void addCommentBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(commentTxt.Text))
            {
                MessageBox.Show("Укажите комментарий");
                return;
            }

            commentProvider = new CommentProvider();
            commentProvider.CreateCommentByRequest(RequestId, commentTxt.Text);
            Close();
        }
    }
}
