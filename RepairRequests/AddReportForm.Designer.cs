namespace RepairRequests
{
    partial class AddReportForm
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
            this.addReportBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addReportBtn
            // 
            this.addReportBtn.Location = new System.Drawing.Point(103, 250);
            this.addReportBtn.Name = "addReportBtn";
            this.addReportBtn.Size = new System.Drawing.Size(215, 41);
            this.addReportBtn.TabIndex = 120;
            this.addReportBtn.Text = "Создать отчет";
            this.addReportBtn.UseVisualStyleBackColor = true;
            this.addReportBtn.Click += new System.EventHandler(this.addReportBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(151, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 37);
            this.label1.TabIndex = 119;
            this.label1.Text = "Отчет";
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descriptionTxt.Location = new System.Drawing.Point(50, 98);
            this.descriptionTxt.MaxLength = 300;
            this.descriptionTxt.Multiline = true;
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(325, 131);
            this.descriptionTxt.TabIndex = 118;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 16);
            this.label3.TabIndex = 117;
            this.label3.Text = "Опишите результат работы";
            // 
            // AddReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 341);
            this.Controls.Add(this.addReportBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.label3);
            this.MaximumSize = new System.Drawing.Size(454, 388);
            this.MinimumSize = new System.Drawing.Size(454, 388);
            this.Name = "AddReportForm";
            this.Text = "Создание отчета";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addReportBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descriptionTxt;
        private System.Windows.Forms.Label label3;
    }
}