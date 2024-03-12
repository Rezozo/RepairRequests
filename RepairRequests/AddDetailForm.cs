using RepairRequests.provider;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RepairRequests
{
    public partial class AddDetailForm : Form
    {
        public int RequestId { get; set; }
        private UserProvider userProvider = new UserProvider();

        public AddDetailForm()
        {
            InitializeComponent();
        }

        private void AddDetailForm_Load(object sender, EventArgs e)
        {
            List<string> executors = userProvider.GetAllExecutors();
            string[] executorsArray = new string[executors.Count];
            executors.CopyTo(executorsArray, 0);
            executorBox.Items.AddRange(executorsArray);
        }

        private void saveDetailBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(executorBox.Text))
            {
                MessageBox.Show("Выберите исполнителя");
                return;
            }

            userProvider.SetExecutor(RequestId, executorBox.Text);
            Close();
        }
    }
}
