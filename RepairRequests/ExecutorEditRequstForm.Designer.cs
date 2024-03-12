namespace RepairRequests
{
    partial class ExecutorEditRequstForm
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
            this.saveBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.equipmentTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addDetailsBtn = new System.Windows.Forms.Button();
            this.detailsView = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.addCommentsBtn = new System.Windows.Forms.Button();
            this.commentView = new System.Windows.Forms.DataGridView();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.closeWindowBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.executorsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentView)).BeginInit();
            this.SuspendLayout();
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
            this.executorsView.Location = new System.Drawing.Point(18, 305);
            this.executorsView.Name = "executorsView";
            this.executorsView.RowHeadersWidth = 51;
            this.executorsView.RowTemplate.Height = 24;
            this.executorsView.Size = new System.Drawing.Size(349, 244);
            this.executorsView.TabIndex = 103;
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
            this.label11.Location = new System.Drawing.Point(13, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(335, 25);
            this.label11.TabIndex = 102;
            this.label11.Text = "Дополнительные исполнители";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(385, 489);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 16);
            this.label10.TabIndex = 101;
            this.label10.Text = "Срок выполнения";
            // 
            // endDatePick
            // 
            this.endDatePick.Enabled = false;
            this.endDatePick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endDatePick.Location = new System.Drawing.Point(388, 508);
            this.endDatePick.Name = "endDatePick";
            this.endDatePick.Size = new System.Drawing.Size(323, 30);
            this.endDatePick.TabIndex = 100;
            // 
            // phoneNumberTxt
            // 
            this.phoneNumberTxt.Enabled = false;
            this.phoneNumberTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneNumberTxt.Location = new System.Drawing.Point(18, 103);
            this.phoneNumberTxt.MaxLength = 300;
            this.phoneNumberTxt.Name = "phoneNumberTxt";
            this.phoneNumberTxt.ReadOnly = true;
            this.phoneNumberTxt.Size = new System.Drawing.Size(229, 30);
            this.phoneNumberTxt.TabIndex = 99;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 16);
            this.label9.TabIndex = 98;
            this.label9.Text = "Номер телефона";
            // 
            // fullNameTxt
            // 
            this.fullNameTxt.Enabled = false;
            this.fullNameTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullNameTxt.Location = new System.Drawing.Point(17, 164);
            this.fullNameTxt.MaxLength = 500;
            this.fullNameTxt.Multiline = true;
            this.fullNameTxt.Name = "fullNameTxt";
            this.fullNameTxt.ReadOnly = true;
            this.fullNameTxt.Size = new System.Drawing.Size(229, 94);
            this.fullNameTxt.TabIndex = 97;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 96;
            this.label7.Text = "ФИО";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 25);
            this.label6.TabIndex = 95;
            this.label6.Text = "Данные отправителя";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(389, 450);
            this.textBox1.MaxLength = 300;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(325, 30);
            this.textBox1.TabIndex = 94;
            this.textBox1.Text = "В работе";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 93;
            this.label5.Text = "Статус";
            // 
            // priorityBox
            // 
            this.priorityBox.Enabled = false;
            this.priorityBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priorityBox.FormattingEnabled = true;
            this.priorityBox.Location = new System.Drawing.Point(388, 391);
            this.priorityBox.Name = "priorityBox";
            this.priorityBox.Size = new System.Drawing.Size(326, 30);
            this.priorityBox.TabIndex = 92;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(385, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 91;
            this.label4.Text = "Приоритетность";
            // 
            // executorBox
            // 
            this.executorBox.Enabled = false;
            this.executorBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.executorBox.FormattingEnabled = true;
            this.executorBox.Location = new System.Drawing.Point(388, 327);
            this.executorBox.Name = "executorBox";
            this.executorBox.Size = new System.Drawing.Size(326, 30);
            this.executorBox.TabIndex = 90;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(385, 305);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 16);
            this.label12.TabIndex = 89;
            this.label12.Text = "Исполнитель";
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Enabled = false;
            this.descriptionTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionTxt.Location = new System.Drawing.Point(387, 201);
            this.descriptionTxt.MaxLength = 500;
            this.descriptionTxt.Multiline = true;
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.ReadOnly = true;
            this.descriptionTxt.Size = new System.Drawing.Size(325, 94);
            this.descriptionTxt.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(383, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 87;
            this.label2.Text = "Описание проблемы";
            // 
            // typeBox
            // 
            this.typeBox.Enabled = false;
            this.typeBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Location = new System.Drawing.Point(388, 133);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(326, 30);
            this.typeBox.TabIndex = 86;
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.Location = new System.Drawing.Point(388, 591);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(322, 41);
            this.saveBtn.TabIndex = 85;
            this.saveBtn.Text = "Завершить работу";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(385, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 16);
            this.label8.TabIndex = 84;
            this.label8.Text = "Тип неисправности";
            // 
            // equipmentTxt
            // 
            this.equipmentTxt.Enabled = false;
            this.equipmentTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equipmentTxt.Location = new System.Drawing.Point(388, 70);
            this.equipmentTxt.MaxLength = 300;
            this.equipmentTxt.Name = "equipmentTxt";
            this.equipmentTxt.ReadOnly = true;
            this.equipmentTxt.Size = new System.Drawing.Size(325, 30);
            this.equipmentTxt.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 82;
            this.label3.Text = "Оборудование";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(491, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 37);
            this.label1.TabIndex = 81;
            this.label1.Text = "Заявка";
            // 
            // addDetailsBtn
            // 
            this.addDetailsBtn.Location = new System.Drawing.Point(741, 61);
            this.addDetailsBtn.Name = "addDetailsBtn";
            this.addDetailsBtn.Size = new System.Drawing.Size(221, 41);
            this.addDetailsBtn.TabIndex = 107;
            this.addDetailsBtn.Text = "Добавить запчасти";
            this.addDetailsBtn.UseVisualStyleBackColor = true;
            this.addDetailsBtn.Click += new System.EventHandler(this.addDetailsBtn_Click);
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
            this.detailsView.Location = new System.Drawing.Point(741, 111);
            this.detailsView.Name = "detailsView";
            this.detailsView.RowHeadersWidth = 51;
            this.detailsView.RowTemplate.Height = 24;
            this.detailsView.Size = new System.Drawing.Size(563, 244);
            this.detailsView.TabIndex = 106;
            this.detailsView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.detailsView_CellDoubleClick);
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
            this.label13.Location = new System.Drawing.Point(736, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(293, 25);
            this.label13.TabIndex = 105;
            this.label13.Text = "Дополнительные запчасти";
            // 
            // addCommentsBtn
            // 
            this.addCommentsBtn.Location = new System.Drawing.Point(741, 400);
            this.addCommentsBtn.Name = "addCommentsBtn";
            this.addCommentsBtn.Size = new System.Drawing.Size(221, 41);
            this.addCommentsBtn.TabIndex = 110;
            this.addCommentsBtn.Text = "Добавить комментарий";
            this.addCommentsBtn.UseVisualStyleBackColor = true;
            this.addCommentsBtn.Click += new System.EventHandler(this.addCommentsBtn_Click);
            // 
            // commentView
            // 
            this.commentView.AllowUserToAddRows = false;
            this.commentView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.commentView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.commentView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commentView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Description});
            this.commentView.Location = new System.Drawing.Point(741, 450);
            this.commentView.Name = "commentView";
            this.commentView.RowHeadersWidth = 51;
            this.commentView.RowTemplate.Height = 24;
            this.commentView.Size = new System.Drawing.Size(563, 244);
            this.commentView.TabIndex = 109;
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
            this.label14.Location = new System.Drawing.Point(736, 366);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(158, 25);
            this.label14.TabIndex = 108;
            this.label14.Text = "Комментарии";
            // 
            // closeWindowBtn
            // 
            this.closeWindowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeWindowBtn.Location = new System.Drawing.Point(387, 653);
            this.closeWindowBtn.Name = "closeWindowBtn";
            this.closeWindowBtn.Size = new System.Drawing.Size(322, 41);
            this.closeWindowBtn.TabIndex = 111;
            this.closeWindowBtn.Text = "Закрыть окно";
            this.closeWindowBtn.UseVisualStyleBackColor = true;
            this.closeWindowBtn.Click += new System.EventHandler(this.closeWindowBtn_Click);
            // 
            // ExecutorEditRequstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1336, 724);
            this.Controls.Add(this.closeWindowBtn);
            this.Controls.Add(this.addCommentsBtn);
            this.Controls.Add(this.commentView);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.addDetailsBtn);
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
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.equipmentTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ExecutorEditRequstForm";
            this.Text = "Заявка";
            this.Load += new System.EventHandler(this.ExecutorEditRequstForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.executorsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox equipmentTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addDetailsBtn;
        private System.Windows.Forms.DataGridView detailsView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button addCommentsBtn;
        private System.Windows.Forms.DataGridView commentView;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.Button closeWindowBtn;
    }
}