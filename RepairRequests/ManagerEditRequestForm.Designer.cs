namespace RepairRequests
{
    partial class ManagerEditRequestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label10 = new System.Windows.Forms.Label();
            this.endDatePick = new System.Windows.Forms.DateTimePicker();
            this.phoneNumberTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.fullNameTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.priorityBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.executorBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.equipmentTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.executorsView = new System.Windows.Forms.DataGridView();
            this.addExecutor = new System.Windows.Forms.Button();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.executorsView)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(336, 496);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 16);
            this.label10.TabIndex = 77;
            this.label10.Text = "Срок выполнения";
            // 
            // endDatePick
            // 
            this.endDatePick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endDatePick.Location = new System.Drawing.Point(339, 515);
            this.endDatePick.Name = "endDatePick";
            this.endDatePick.Size = new System.Drawing.Size(323, 30);
            this.endDatePick.TabIndex = 76;
            // 
            // phoneNumberTxt
            // 
            this.phoneNumberTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneNumberTxt.Location = new System.Drawing.Point(48, 230);
            this.phoneNumberTxt.MaxLength = 300;
            this.phoneNumberTxt.Name = "phoneNumberTxt";
            this.phoneNumberTxt.ReadOnly = true;
            this.phoneNumberTxt.Size = new System.Drawing.Size(229, 30);
            this.phoneNumberTxt.TabIndex = 75;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 16);
            this.label9.TabIndex = 74;
            this.label9.Text = "Номер телефона";
            // 
            // fullNameTxt
            // 
            this.fullNameTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullNameTxt.Location = new System.Drawing.Point(47, 291);
            this.fullNameTxt.MaxLength = 500;
            this.fullNameTxt.Multiline = true;
            this.fullNameTxt.Name = "fullNameTxt";
            this.fullNameTxt.ReadOnly = true;
            this.fullNameTxt.Size = new System.Drawing.Size(229, 94);
            this.fullNameTxt.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 72;
            this.label7.Text = "ФИО";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(42, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 25);
            this.label6.TabIndex = 71;
            this.label6.Text = "Данные отправителя";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(340, 457);
            this.textBox1.MaxLength = 300;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(325, 30);
            this.textBox1.TabIndex = 70;
            this.textBox1.Text = "В работе";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 69;
            this.label5.Text = "Статус";
            // 
            // priorityBox
            // 
            this.priorityBox.Enabled = false;
            this.priorityBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priorityBox.FormattingEnabled = true;
            this.priorityBox.Location = new System.Drawing.Point(339, 398);
            this.priorityBox.Name = "priorityBox";
            this.priorityBox.Size = new System.Drawing.Size(326, 30);
            this.priorityBox.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 67;
            this.label4.Text = "Приоритетность";
            // 
            // executorBox
            // 
            this.executorBox.Enabled = false;
            this.executorBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.executorBox.FormattingEnabled = true;
            this.executorBox.Location = new System.Drawing.Point(339, 334);
            this.executorBox.Name = "executorBox";
            this.executorBox.Size = new System.Drawing.Size(326, 30);
            this.executorBox.TabIndex = 66;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(336, 312);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 16);
            this.label12.TabIndex = 65;
            this.label12.Text = "Исполнитель";
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionTxt.Location = new System.Drawing.Point(338, 208);
            this.descriptionTxt.MaxLength = 500;
            this.descriptionTxt.Multiline = true;
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.ReadOnly = true;
            this.descriptionTxt.Size = new System.Drawing.Size(325, 94);
            this.descriptionTxt.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 62;
            this.label2.Text = "Описание проблемы";
            // 
            // typeBox
            // 
            this.typeBox.Enabled = false;
            this.typeBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Location = new System.Drawing.Point(339, 140);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(326, 30);
            this.typeBox.TabIndex = 61;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(368, 561);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(268, 41);
            this.saveBtn.TabIndex = 60;
            this.saveBtn.Text = "Сохранить изменения";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(336, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 16);
            this.label8.TabIndex = 59;
            this.label8.Text = "Тип неисправности";
            // 
            // equipmentTxt
            // 
            this.equipmentTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equipmentTxt.Location = new System.Drawing.Point(339, 77);
            this.equipmentTxt.MaxLength = 300;
            this.equipmentTxt.Name = "equipmentTxt";
            this.equipmentTxt.ReadOnly = true;
            this.equipmentTxt.Size = new System.Drawing.Size(325, 30);
            this.equipmentTxt.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 57;
            this.label3.Text = "Оборудование";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(442, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 37);
            this.label1.TabIndex = 56;
            this.label1.Text = "Заявка";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(703, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(335, 25);
            this.label11.TabIndex = 78;
            this.label11.Text = "Дополнительные исполнители";
            // 
            // executorsView
            // 
            this.executorsView.AllowUserToAddRows = false;
            this.executorsView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.executorsView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.executorsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.executorsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName,
            this.PhoneNumber});
            this.executorsView.Location = new System.Drawing.Point(708, 253);
            this.executorsView.Name = "executorsView";
            this.executorsView.RowHeadersWidth = 51;
            this.executorsView.RowTemplate.Height = 24;
            this.executorsView.Size = new System.Drawing.Size(349, 244);
            this.executorsView.TabIndex = 79;
            this.executorsView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.executorsView_CellClick);
            // 
            // addExecutor
            // 
            this.addExecutor.Location = new System.Drawing.Point(708, 203);
            this.addExecutor.Name = "addExecutor";
            this.addExecutor.Size = new System.Drawing.Size(198, 41);
            this.addExecutor.TabIndex = 80;
            this.addExecutor.Text = "Добавить исполнителя";
            this.addExecutor.UseVisualStyleBackColor = true;
            this.addExecutor.Click += new System.EventHandler(this.addExecutor_Click);
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Полное имя";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 200;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "Номер телефона";
            this.PhoneNumber.MinimumWidth = 6;
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Width = 125;
            // 
            // ManagerEditRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 641);
            this.Controls.Add(this.addExecutor);
            this.Controls.Add(this.executorsView);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.endDatePick);
            this.Controls.Add(this.phoneNumberTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.fullNameTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.priorityBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.executorBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.equipmentTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ManagerEditRequestForm";
            this.Text = "Изменение заявки";
            this.Load += new System.EventHandler(this.ManagerEditRequestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.executorsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker endDatePick;
        private System.Windows.Forms.TextBox phoneNumberTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox fullNameTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox priorityBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox executorBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox descriptionTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox equipmentTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView executorsView;
        private System.Windows.Forms.Button addExecutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
    }
}