namespace RepairRequests
{
    partial class ReportsListForm
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
            this.requestsView = new System.Windows.Forms.DataGridView();
            this.infoLabel2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.requestsView)).BeginInit();
            this.SuspendLayout();
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
            this.DateTo,
            this.Description});
            this.requestsView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.requestsView.Location = new System.Drawing.Point(12, 88);
            this.requestsView.Name = "requestsView";
            this.requestsView.RowHeadersWidth = 51;
            this.requestsView.RowTemplate.Height = 24;
            this.requestsView.Size = new System.Drawing.Size(1033, 518);
            this.requestsView.TabIndex = 89;
            this.requestsView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.requestsView_CellDoubleClick);
            // 
            // infoLabel2
            // 
            this.infoLabel2.AutoSize = true;
            this.infoLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel2.Location = new System.Drawing.Point(8, 41);
            this.infoLabel2.Name = "infoLabel2";
            this.infoLabel2.Size = new System.Drawing.Size(725, 22);
            this.infoLabel2.TabIndex = 88;
            this.infoLabel2.Text = "Вы можете подробнее посмотреть данные, нажав два раза на любую ячейку отчета";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 87;
            this.label1.Text = "Все отчеты";
            // 
            // Id
            // 
            this.Id.HeaderText = "Ид";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // DateFrom
            // 
            this.DateFrom.HeaderText = "Дата Начала";
            this.DateFrom.MinimumWidth = 6;
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.ReadOnly = true;
            this.DateFrom.Width = 125;
            // 
            // DateTo
            // 
            this.DateTo.HeaderText = "Дата окончания работы";
            this.DateTo.MinimumWidth = 6;
            this.DateTo.Name = "DateTo";
            this.DateTo.ReadOnly = true;
            this.DateTo.Width = 125;
            // 
            // Description
            // 
            this.Description.HeaderText = "Описание проблемы";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 250;
            // 
            // ReportsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 618);
            this.Controls.Add(this.requestsView);
            this.Controls.Add(this.infoLabel2);
            this.Controls.Add(this.label1);
            this.Name = "ReportsListForm";
            this.Text = "Все отчеты";
            this.Load += new System.EventHandler(this.ReportsListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.requestsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView requestsView;
        private System.Windows.Forms.Label infoLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}