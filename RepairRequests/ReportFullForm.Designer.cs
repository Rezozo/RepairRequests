namespace RepairRequests
{
    partial class ReportFullForm
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
            this.commentView = new System.Windows.Forms.DataGridView();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.detailsView = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.executorsView = new System.Windows.Forms.DataGridView();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
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
            this.label8 = new System.Windows.Forms.Label();
            this.equipmentTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.descWorkTxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.commentView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.executorsView)).BeginInit();
            this.SuspendLayout();
            // 
            // commentView
            // 
            this.commentView.AllowUserToAddRows = false;
            this.commentView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.commentView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.commentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commentView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Description});
            this.commentView.Location = new System.Drawing.Point(745, 332);
            this.commentView.Name = "commentView";
            this.commentView.RowHeadersWidth = 51;
            this.commentView.RowTemplate.Height = 24;
            this.commentView.Size = new System.Drawing.Size(563, 244);
            this.commentView.TabIndex = 139;
            // 
            // Description
            // 
            this.Description.HeaderText = "Название";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 400;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(740, 304);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(158, 25);
            this.label14.TabIndex = 138;
            this.label14.Text = "Комментарии";
            // 
            // detailsView
            // 
            this.detailsView.AllowUserToAddRows = false;
            this.detailsView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.detailsView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Cost,
            this.Count});
            this.detailsView.Location = new System.Drawing.Point(745, 52);
            this.detailsView.Name = "detailsView";
            this.detailsView.RowHeadersWidth = 51;
            this.detailsView.RowTemplate.Height = 24;
            this.detailsView.Size = new System.Drawing.Size(546, 244);
            this.detailsView.TabIndex = 136;
            // 
            // Title
            // 
            this.Title.HeaderText = "Название";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 200;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Стоимость";
            this.Cost.MinimumWidth = 6;
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Width = 125;
            // 
            // Count
            // 
            this.Count.HeaderText = "Количество";
            this.Count.MinimumWidth = 6;
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Width = 125;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(740, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(293, 25);
            this.label13.TabIndex = 135;
            this.label13.Text = "Дополнительные запчасти";
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
            this.executorsView.Location = new System.Drawing.Point(22, 302);
            this.executorsView.Name = "executorsView";
            this.executorsView.RowHeadersWidth = 51;
            this.executorsView.RowTemplate.Height = 24;
            this.executorsView.Size = new System.Drawing.Size(349, 244);
            this.executorsView.TabIndex = 134;
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(17, 265);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(335, 25);
            this.label11.TabIndex = 133;
            this.label11.Text = "Дополнительные исполнители";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(389, 486);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 16);
            this.label10.TabIndex = 132;
            this.label10.Text = "Срок выполнения";
            // 
            // endDatePick
            // 
            this.endDatePick.Enabled = false;
            this.endDatePick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endDatePick.Location = new System.Drawing.Point(392, 505);
            this.endDatePick.Name = "endDatePick";
            this.endDatePick.Size = new System.Drawing.Size(323, 30);
            this.endDatePick.TabIndex = 131;
            // 
            // phoneNumberTxt
            // 
            this.phoneNumberTxt.Enabled = false;
            this.phoneNumberTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneNumberTxt.Location = new System.Drawing.Point(22, 100);
            this.phoneNumberTxt.MaxLength = 300;
            this.phoneNumberTxt.Name = "phoneNumberTxt";
            this.phoneNumberTxt.ReadOnly = true;
            this.phoneNumberTxt.Size = new System.Drawing.Size(229, 30);
            this.phoneNumberTxt.TabIndex = 130;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 16);
            this.label9.TabIndex = 129;
            this.label9.Text = "Номер телефона";
            // 
            // fullNameTxt
            // 
            this.fullNameTxt.Enabled = false;
            this.fullNameTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullNameTxt.Location = new System.Drawing.Point(21, 161);
            this.fullNameTxt.MaxLength = 500;
            this.fullNameTxt.Multiline = true;
            this.fullNameTxt.Name = "fullNameTxt";
            this.fullNameTxt.ReadOnly = true;
            this.fullNameTxt.Size = new System.Drawing.Size(229, 94);
            this.fullNameTxt.TabIndex = 128;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 127;
            this.label7.Text = "ФИО";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(16, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 25);
            this.label6.TabIndex = 126;
            this.label6.Text = "Данные отправителя";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(393, 447);
            this.textBox1.MaxLength = 300;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(325, 30);
            this.textBox1.TabIndex = 125;
            this.textBox1.Text = "В работе";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 124;
            this.label5.Text = "Статус";
            // 
            // priorityBox
            // 
            this.priorityBox.Enabled = false;
            this.priorityBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priorityBox.FormattingEnabled = true;
            this.priorityBox.Location = new System.Drawing.Point(392, 388);
            this.priorityBox.Name = "priorityBox";
            this.priorityBox.Size = new System.Drawing.Size(326, 30);
            this.priorityBox.TabIndex = 123;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 122;
            this.label4.Text = "Приоритетность";
            // 
            // executorBox
            // 
            this.executorBox.Enabled = false;
            this.executorBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.executorBox.FormattingEnabled = true;
            this.executorBox.Location = new System.Drawing.Point(392, 324);
            this.executorBox.Name = "executorBox";
            this.executorBox.Size = new System.Drawing.Size(326, 30);
            this.executorBox.TabIndex = 121;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(389, 302);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 16);
            this.label12.TabIndex = 120;
            this.label12.Text = "Исполнитель";
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Enabled = false;
            this.descriptionTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionTxt.Location = new System.Drawing.Point(391, 198);
            this.descriptionTxt.MaxLength = 500;
            this.descriptionTxt.Multiline = true;
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.ReadOnly = true;
            this.descriptionTxt.Size = new System.Drawing.Size(325, 94);
            this.descriptionTxt.TabIndex = 119;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 118;
            this.label2.Text = "Описание проблемы";
            // 
            // typeBox
            // 
            this.typeBox.Enabled = false;
            this.typeBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Location = new System.Drawing.Point(392, 130);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(326, 30);
            this.typeBox.TabIndex = 117;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(389, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 16);
            this.label8.TabIndex = 115;
            this.label8.Text = "Тип неисправности";
            // 
            // equipmentTxt
            // 
            this.equipmentTxt.Enabled = false;
            this.equipmentTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equipmentTxt.Location = new System.Drawing.Point(392, 67);
            this.equipmentTxt.MaxLength = 300;
            this.equipmentTxt.Name = "equipmentTxt";
            this.equipmentTxt.ReadOnly = true;
            this.equipmentTxt.Size = new System.Drawing.Size(325, 30);
            this.equipmentTxt.TabIndex = 114;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 113;
            this.label3.Text = "Оборудование";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(495, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 37);
            this.label1.TabIndex = 112;
            this.label1.Text = "Отчет";
            // 
            // descWorkTxt
            // 
            this.descWorkTxt.Enabled = false;
            this.descWorkTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descWorkTxt.Location = new System.Drawing.Point(392, 582);
            this.descWorkTxt.MaxLength = 500;
            this.descWorkTxt.Multiline = true;
            this.descWorkTxt.Name = "descWorkTxt";
            this.descWorkTxt.ReadOnly = true;
            this.descWorkTxt.Size = new System.Drawing.Size(325, 94);
            this.descWorkTxt.TabIndex = 142;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(388, 560);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(205, 16);
            this.label15.TabIndex = 141;
            this.label15.Text = "Описание выполненных работ";
            // 
            // ReportFullForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 701);
            this.Controls.Add(this.descWorkTxt);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.commentView);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.detailsView);
            this.Controls.Add(this.label13);
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
            this.Controls.Add(this.label8);
            this.Controls.Add(this.equipmentTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ReportFullForm";
            this.Text = "ReportFullForm";
            this.Load += new System.EventHandler(this.ReportFullForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.commentView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.executorsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView commentView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView detailsView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView executorsView;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.Label label11;
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox equipmentTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descWorkTxt;
        private System.Windows.Forms.Label label15;
    }
}