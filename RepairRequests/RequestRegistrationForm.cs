using RepairRequests.model;
using RepairRequests.provider;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RepairRequests
{
    public partial class RequestRegistrationForm : Form
    {
        public int UserId { get; set; }
        public int RequestId { get; set; }
        public string Equipment { get; set; }
        public string Description { get; set; }
        public string TypeName { get; set; }
        public int SenderId { get; set; }

        private RequestProvider provider = new RequestProvider();
        private DictionaryProvider dictionaryProvider = new DictionaryProvider();
        private UserProvider userProvider = new UserProvider();
        private NotificationProvider notificationProvider = new NotificationProvider();

        public RequestRegistrationForm()
        {
            InitializeComponent();
        }

        private void RequestRegistrationForm_Load(object sender, EventArgs e)
        {
            equipmentTxt.Text = Equipment;
            descriptionTxt.Text = Description;
            typeBox.Text = TypeName;

            List<string> priorities = dictionaryProvider.GetAllPriority();
            string[] priorityArray = new string[priorities.Count];
            priorities.CopyTo(priorityArray, 0);
            priorityBox.Items.AddRange(priorityArray);

            List<string> executors = userProvider.GetAllExecutors();
            string[] executorsArray = new string[executors.Count];
            executors.CopyTo(executorsArray, 0);
            executorBox.Items.AddRange(executorsArray);

            User user = userProvider.GetUserById(SenderId);
            fullNameTxt.Text = user.Name;

            string phoneNumber = user.PhoneNumber;
            string formattedPhoneNumber = $"+7 ({phoneNumber.Substring(1, 3)}) {phoneNumber.Substring(4, 3)}-{phoneNumber.Substring(7, 2)}-{phoneNumber.Substring(9, 2)}";

            phoneNumberTxt.Text = formattedPhoneNumber;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            provider.DeleteById(RequestId);
            MessageBox.Show("Заявка успешно удалена");
            Close();
        }

        private void registrationBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(executorBox.Text) ||
                string.IsNullOrWhiteSpace(priorityBox.Text) ||
                string.IsNullOrWhiteSpace(endDatePick.Text) || 
                endDatePick.Value < DateTime.Now)
            {
                MessageBox.Show("Не все данные заполнены корректно");
                return;
            }

            provider.RegistrationRequest(RequestId, executorBox.Text, priorityBox.Text, endDatePick.Value);

            notificationProvider.SaveNotification(RequestId);

            MessageBox.Show("Заявка успешно зарегистрирована");
            Close();
        }
    }
}
