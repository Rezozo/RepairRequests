using RepairRequests.provider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace RepairRequests
{
    public partial class AddRequestForm : Form
    {
        public int UserId { get; set; }
        public int RequestId { get; set; }
        public string Equipment { get; set; }
        public string Description { get; set; }
        public string TypeName { get; set; } 

        private RequestProvider provider = new RequestProvider();
        private DictionaryProvider dictionaryProvider = new DictionaryProvider();

        public AddRequestForm()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(equipmentTxt.Text) ||
                string.IsNullOrWhiteSpace(descriptionTxt.Text) ||
                string.IsNullOrWhiteSpace(typeBox.Text))
            {
                MessageBox.Show("Корректно заполните информацию о заявке");
                return;
            }

            if (RequestId != 0)
            {
                provider.UpdateShortRequest(RequestId, equipmentTxt.Text, descriptionTxt.Text, typeBox.Text);
                MessageBox.Show("Заявка успешно обновленаы");
            }
            else
            {
                provider.SaveRequest(equipmentTxt.Text, descriptionTxt.Text, typeBox.Text, UserId);
                MessageBox.Show("Заявка успешно создана");
            }
            Close();
        }

        private void AddRequestForm_Load(object sender, EventArgs e)
        {
            List<string> types = dictionaryProvider.GetAllRepairTypes();
            string[] typeArray = new string[types.Count];
            types.CopyTo(typeArray, 0);
            typeBox.Items.AddRange(typeArray);

            if (RequestId != 0)
            {
                createBtn.Text = "Обновить заявку";
                equipmentTxt.Text = Equipment;
                descriptionTxt.Text = Description;
                typeBox.Text = TypeName;
            }
        }
    }
}
