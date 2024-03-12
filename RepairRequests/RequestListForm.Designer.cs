namespace RepairRequests
{
    partial class RequestListForm
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
            this.infoLabel2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.requestsView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeRepair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.getNotificationBtn = new System.Windows.Forms.Button();
            this.addRequest = new System.Windows.Forms.Button();
            this.progressRequestBtn = new System.Windows.Forms.Button();
            this.quizBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.requestsView)).BeginInit();
            this.SuspendLayout();
            // 
            // infoLabel2
            // 
            this.infoLabel2.AutoSize = true;
            this.infoLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel2.Location = new System.Drawing.Point(11, 50);
            this.infoLabel2.Name = "infoLabel2";
            this.infoLabel2.Size = new System.Drawing.Size(701, 22);
            this.infoLabel2.TabIndex = 6;
            this.infoLabel2.Text = "Вы можете изменить данные по заявке, нажав два раза на любую ячейку заявки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ваши заявки";
            // 
            // requestsView
            // 
            this.requestsView.AllowUserToAddRows = false;
            this.requestsView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.requestsView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.requestsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DateFrom,
            this.EndDate,
            this.Equipment,
            this.TypeRepair,
            this.Description,
            this.Status});
            this.requestsView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.requestsView.Location = new System.Drawing.Point(15, 147);
            this.requestsView.Name = "requestsView";
            this.requestsView.RowHeadersWidth = 51;
            this.requestsView.RowTemplate.Height = 24;
            this.requestsView.Size = new System.Drawing.Size(1033, 448);
            this.requestsView.TabIndex = 7;
            this.requestsView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.requestsView_CellClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Номер заявки";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // DateFrom
            // 
            this.DateFrom.HeaderText = "Дата";
            this.DateFrom.MinimumWidth = 6;
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.ReadOnly = true;
            this.DateFrom.Width = 125;
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "Дата окончания работы";
            this.EndDate.MinimumWidth = 6;
            this.EndDate.Name = "EndDate";
            this.EndDate.ReadOnly = true;
            this.EndDate.Width = 125;
            // 
            // Equipment
            // 
            this.Equipment.HeaderText = "Оборудование";
            this.Equipment.MinimumWidth = 6;
            this.Equipment.Name = "Equipment";
            this.Equipment.ReadOnly = true;
            this.Equipment.Width = 125;
            // 
            // TypeRepair
            // 
            this.TypeRepair.HeaderText = "Тип неисправности";
            this.TypeRepair.MinimumWidth = 6;
            this.TypeRepair.Name = "TypeRepair";
            this.TypeRepair.ReadOnly = true;
            this.TypeRepair.Width = 125;
            // 
            // Description
            // 
            this.Description.HeaderText = "Описание проблемы";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 250;
            // 
            // Status
            // 
            this.Status.HeaderText = "Статус заявки";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 125;
            // 
            // searchTxt
            // 
            this.searchTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searchTxt.Location = new System.Drawing.Point(92, 96);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(272, 26);
            this.searchTxt.TabIndex = 10;
            this.searchTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTxt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Поиск";
            // 
            // getNotificationBtn
            // 
            this.getNotificationBtn.Location = new System.Drawing.Point(399, 90);
            this.getNotificationBtn.Name = "getNotificationBtn";
            this.getNotificationBtn.Size = new System.Drawing.Size(300, 38);
            this.getNotificationBtn.TabIndex = 83;
            this.getNotificationBtn.Text = "Обновить информацию о статусах";
            this.getNotificationBtn.UseVisualStyleBackColor = true;
            this.getNotificationBtn.Click += new System.EventHandler(this.getNotificationBtn_Click);
            // 
            // addRequest
            // 
            this.addRequest.Location = new System.Drawing.Point(839, 15);
            this.addRequest.Name = "addRequest";
            this.addRequest.Size = new System.Drawing.Size(209, 38);
            this.addRequest.TabIndex = 84;
            this.addRequest.Text = "Добавить заявку";
            this.addRequest.UseVisualStyleBackColor = true;
            this.addRequest.Click += new System.EventHandler(this.addRequest_Click);
            // 
            // progressRequestBtn
            // 
            this.progressRequestBtn.Location = new System.Drawing.Point(839, 103);
            this.progressRequestBtn.Name = "progressRequestBtn";
            this.progressRequestBtn.Size = new System.Drawing.Size(209, 38);
            this.progressRequestBtn.TabIndex = 85;
            this.progressRequestBtn.Text = "Исполняемые заявки";
            this.progressRequestBtn.UseVisualStyleBackColor = true;
            this.progressRequestBtn.Click += new System.EventHandler(this.progressRequestBtn_Click);
            // 
            // quizBtn
            // 
            this.quizBtn.Location = new System.Drawing.Point(839, 59);
            this.quizBtn.Name = "quizBtn";
            this.quizBtn.Size = new System.Drawing.Size(209, 38);
            this.quizBtn.TabIndex = 86;
            this.quizBtn.Text = "Пройти опрос";
            this.quizBtn.UseVisualStyleBackColor = true;
            this.quizBtn.Click += new System.EventHandler(this.quizBtn_Click);
            // 
            // RequestListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 607);
            this.Controls.Add(this.quizBtn);
            this.Controls.Add(this.progressRequestBtn);
            this.Controls.Add(this.addRequest);
            this.Controls.Add(this.getNotificationBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.requestsView);
            this.Controls.Add(this.infoLabel2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1085, 654);
            this.MinimumSize = new System.Drawing.Size(1085, 654);
            this.Name = "RequestListForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.RequestListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.requestsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView requestsView;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeRepair;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button getNotificationBtn;
        private System.Windows.Forms.Button addRequest;
        private System.Windows.Forms.Button progressRequestBtn;
        private System.Windows.Forms.Button quizBtn;
    }
}