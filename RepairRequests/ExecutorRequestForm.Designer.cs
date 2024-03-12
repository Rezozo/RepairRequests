namespace RepairRequests
{
    partial class ExecutorRequestForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.requestsView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Equipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeRepair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SenderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.requestsView)).BeginInit();
            this.SuspendLayout();
            // 
            // infoLabel2
            // 
            this.infoLabel2.AutoSize = true;
            this.infoLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel2.Location = new System.Drawing.Point(17, 44);
            this.infoLabel2.Name = "infoLabel2";
            this.infoLabel2.Size = new System.Drawing.Size(701, 22);
            this.infoLabel2.TabIndex = 86;
            this.infoLabel2.Text = "Вы можете изменить данные по заявке, нажав два раза на любую ячейку заявки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 85;
            this.label1.Text = "Исполняемые заявки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 84;
            this.label2.Text = "Поиск";
            // 
            // searchTxt
            // 
            this.searchTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searchTxt.Location = new System.Drawing.Point(94, 94);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(272, 26);
            this.searchTxt.TabIndex = 83;
            this.searchTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchTxt_KeyPress);
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
            this.Status,
            this.SenderId});
            this.requestsView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.requestsView.Location = new System.Drawing.Point(17, 138);
            this.requestsView.Name = "requestsView";
            this.requestsView.RowHeadersWidth = 51;
            this.requestsView.RowTemplate.Height = 24;
            this.requestsView.Size = new System.Drawing.Size(1033, 455);
            this.requestsView.TabIndex = 82;
            this.requestsView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.requestsView_CellDoubleClick);
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
            // SenderId
            // 
            this.SenderId.HeaderText = "Отправитель";
            this.SenderId.MinimumWidth = 6;
            this.SenderId.Name = "SenderId";
            this.SenderId.Visible = false;
            this.SenderId.Width = 125;
            // 
            // ExecutorRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 607);
            this.Controls.Add(this.infoLabel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.requestsView);
            this.MaximumSize = new System.Drawing.Size(1085, 654);
            this.MinimumSize = new System.Drawing.Size(1085, 654);
            this.Name = "ExecutorRequestForm";
            this.Text = "Исполняемые заявки";
            this.Load += new System.EventHandler(this.ExecutorRequestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.requestsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.DataGridView requestsView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Equipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeRepair;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn SenderId;
    }
}