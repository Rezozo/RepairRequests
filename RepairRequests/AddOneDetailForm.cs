using RepairRequests.provider;
using System;
using System.Windows.Forms;

namespace RepairRequests
{
    public partial class AddOneDetailForm : Form
    {
        public int RequestId { get; set; }
        private DetailProvider provider = new DetailProvider();

        public AddOneDetailForm()
        {
            InitializeComponent();
        }

        private void addDetailsBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(titleTxt.Text) ||
                string.IsNullOrEmpty(costTxt.Text) ||
                string.IsNullOrEmpty(countTxt.Text))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            try
            {
                int count = int.Parse(countTxt.Text);
                decimal cost = decimal.Parse(costTxt.Text);

                provider.CreateDetail(RequestId, titleTxt.Text, cost, count.ToString());
                Close();
            } catch
            {
                MessageBox.Show("Количество и цена должны состоять только из цифр");
            }
        }
    }
}
