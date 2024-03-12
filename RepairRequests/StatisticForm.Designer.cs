namespace RepairRequests
{
    partial class StatisticForm
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
            this.statisticView = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.countDone = new System.Windows.Forms.Label();
            this.rangeTimeLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.statisticView)).BeginInit();
            this.SuspendLayout();
            // 
            // statisticView
            // 
            this.statisticView.AllowUserToAddRows = false;
            this.statisticView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.statisticView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statisticView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statisticView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Count});
            this.statisticView.Location = new System.Drawing.Point(12, 160);
            this.statisticView.Name = "statisticView";
            this.statisticView.RowHeadersWidth = 51;
            this.statisticView.RowTemplate.Height = 24;
            this.statisticView.Size = new System.Drawing.Size(510, 244);
            this.statisticView.TabIndex = 82;
            // 
            // Title
            // 
            this.Title.HeaderText = "Название";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 200;
            // 
            // Count
            // 
            this.Count.HeaderText = "Количество";
            this.Count.MinimumWidth = 6;
            this.Count.Name = "Count";
            this.Count.ReadOnly = true;
            this.Count.Width = 125;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(171, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 25);
            this.label11.TabIndex = 81;
            this.label11.Text = "Статистика";
            // 
            // countDone
            // 
            this.countDone.AutoSize = true;
            this.countDone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countDone.Location = new System.Drawing.Point(60, 67);
            this.countDone.Name = "countDone";
            this.countDone.Size = new System.Drawing.Size(261, 23);
            this.countDone.TabIndex = 83;
            this.countDone.Text = "Количество выполненных:";
            // 
            // rangeTimeLbl
            // 
            this.rangeTimeLbl.AutoSize = true;
            this.rangeTimeLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rangeTimeLbl.Location = new System.Drawing.Point(60, 108);
            this.rangeTimeLbl.Name = "rangeTimeLbl";
            this.rangeTimeLbl.Size = new System.Drawing.Size(350, 23);
            this.rangeTimeLbl.TabIndex = 84;
            this.rangeTimeLbl.Text = "Среднее время выполнения заявки: ";
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 444);
            this.Controls.Add(this.rangeTimeLbl);
            this.Controls.Add(this.countDone);
            this.Controls.Add(this.statisticView);
            this.Controls.Add(this.label11);
            this.MaximumSize = new System.Drawing.Size(552, 491);
            this.MinimumSize = new System.Drawing.Size(552, 491);
            this.Name = "StatisticForm";
            this.Text = "Статистика";
            this.Load += new System.EventHandler(this.StatisticForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.statisticView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView statisticView;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.Label countDone;
        private System.Windows.Forms.Label rangeTimeLbl;
    }
}