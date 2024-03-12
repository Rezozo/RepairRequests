namespace RepairRequests
{
    partial class RequestRegistrationForm
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
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.registrationBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.equipmentTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.executorBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.priorityBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fullNameTxt = new System.Windows.Forms.TextBox();
            this.phoneNumberTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.endDatePick = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionTxt.Location = new System.Drawing.Point(320, 198);
            this.descriptionTxt.MaxLength = 500;
            this.descriptionTxt.Multiline = true;
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.ReadOnly = true;
            this.descriptionTxt.Size = new System.Drawing.Size(325, 94);
            this.descriptionTxt.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 40;
            this.label2.Text = "Описание проблемы";
            // 
            // typeBox
            // 
            this.typeBox.Enabled = false;
            this.typeBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Location = new System.Drawing.Point(321, 130);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(326, 30);
            this.typeBox.TabIndex = 39;
            // 
            // registrationBtn
            // 
            this.registrationBtn.Location = new System.Drawing.Point(354, 552);
            this.registrationBtn.Name = "registrationBtn";
            this.registrationBtn.Size = new System.Drawing.Size(268, 41);
            this.registrationBtn.TabIndex = 38;
            this.registrationBtn.Text = "Зарегистрировать заявку";
            this.registrationBtn.UseVisualStyleBackColor = true;
            this.registrationBtn.Click += new System.EventHandler(this.registrationBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(318, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "Тип неисправности";
            // 
            // equipmentTxt
            // 
            this.equipmentTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equipmentTxt.Location = new System.Drawing.Point(321, 67);
            this.equipmentTxt.MaxLength = 300;
            this.equipmentTxt.Name = "equipmentTxt";
            this.equipmentTxt.ReadOnly = true;
            this.equipmentTxt.Size = new System.Drawing.Size(325, 30);
            this.equipmentTxt.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Оборудование";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(424, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 37);
            this.label1.TabIndex = 34;
            this.label1.Text = "Заявка";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(354, 609);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(268, 41);
            this.deleteBtn.TabIndex = 42;
            this.deleteBtn.Text = "Удалить заявку";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // executorBox
            // 
            this.executorBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.executorBox.FormattingEnabled = true;
            this.executorBox.Location = new System.Drawing.Point(321, 324);
            this.executorBox.Name = "executorBox";
            this.executorBox.Size = new System.Drawing.Size(326, 30);
            this.executorBox.TabIndex = 44;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(318, 302);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 16);
            this.label12.TabIndex = 43;
            this.label12.Text = "Исполнитель";
            // 
            // priorityBox
            // 
            this.priorityBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priorityBox.FormattingEnabled = true;
            this.priorityBox.Location = new System.Drawing.Point(321, 388);
            this.priorityBox.Name = "priorityBox";
            this.priorityBox.Size = new System.Drawing.Size(326, 30);
            this.priorityBox.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "Приоритетность";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(322, 447);
            this.textBox1.MaxLength = 300;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(325, 30);
            this.textBox1.TabIndex = 48;
            this.textBox1.Text = "В работе";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 47;
            this.label5.Text = "Статус";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(24, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 25);
            this.label6.TabIndex = 49;
            this.label6.Text = "Данные отправителя";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 50;
            this.label7.Text = "ФИО";
            // 
            // fullNameTxt
            // 
            this.fullNameTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullNameTxt.Location = new System.Drawing.Point(29, 281);
            this.fullNameTxt.MaxLength = 500;
            this.fullNameTxt.Multiline = true;
            this.fullNameTxt.Name = "fullNameTxt";
            this.fullNameTxt.ReadOnly = true;
            this.fullNameTxt.Size = new System.Drawing.Size(229, 94);
            this.fullNameTxt.TabIndex = 51;
            // 
            // phoneNumberTxt
            // 
            this.phoneNumberTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneNumberTxt.Location = new System.Drawing.Point(30, 220);
            this.phoneNumberTxt.MaxLength = 300;
            this.phoneNumberTxt.Name = "phoneNumberTxt";
            this.phoneNumberTxt.ReadOnly = true;
            this.phoneNumberTxt.Size = new System.Drawing.Size(229, 30);
            this.phoneNumberTxt.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 16);
            this.label9.TabIndex = 52;
            this.label9.Text = "Номер телефона";
            // 
            // endDatePick
            // 
            this.endDatePick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endDatePick.Location = new System.Drawing.Point(321, 505);
            this.endDatePick.Name = "endDatePick";
            this.endDatePick.Size = new System.Drawing.Size(323, 30);
            this.endDatePick.TabIndex = 54;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(318, 486);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 16);
            this.label10.TabIndex = 55;
            this.label10.Text = "Срок выполнения";
            // 
            // RequestRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 662);
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
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.registrationBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.equipmentTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(715, 709);
            this.MinimumSize = new System.Drawing.Size(715, 709);
            this.Name = "RequestRegistrationForm";
            this.Text = "Регистрация заявки";
            this.Load += new System.EventHandler(this.RequestRegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox descriptionTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.Button registrationBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox equipmentTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ComboBox executorBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox priorityBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox fullNameTxt;
        private System.Windows.Forms.TextBox phoneNumberTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker endDatePick;
        private System.Windows.Forms.Label label10;
    }
}