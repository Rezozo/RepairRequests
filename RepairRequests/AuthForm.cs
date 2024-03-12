using RepairRequests.model;
using RepairRequests.provider;
using System;
using System.Windows.Forms;

namespace RepairRequests
{
    public partial class AuthForm : Form
    {
        private UserProvider userProvider = new UserProvider();
        public AuthForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string login = loginTxt.Text;
            string password = passwordTxt.Text;
            if (string.IsNullOrEmpty(login) && string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Укажите пароль и логин");
                return;
            }
            User user = userProvider.isValidUser(login, password);
            if (user == null)
            {
                MessageBox.Show("Неправильный логин или пароль");
                return;
            }

            switch (user.Role)
            {
                case "Администратор":
                    break;
                case "Менеджер":
                    RepairListManagerForm repairListManagerForm = new RepairListManagerForm();
                    repairListManagerForm.currentUser = user;
                    repairListManagerForm.FormClosed += (s, a) => Close();
                    repairListManagerForm.Show();
                    Hide();
                    break;
                case "Исполнитель":
                case "Клиент":
                    RequestListForm requestListForm = new RequestListForm();
                    requestListForm.currentUser = user;
                    requestListForm.FormClosed += (s, a) => Close();
                    requestListForm.Show();
                    Hide();
                    break;
            }
        }
    }
}
