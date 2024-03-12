namespace RepairRequests
{
    partial class AddDetailForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.executorBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.saveDetailBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(83, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Дополнительный исполнитель";
            // 
            // executorBox
            // 
            this.executorBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.executorBox.FormattingEnabled = true;
            this.executorBox.Location = new System.Drawing.Point(71, 81);
            this.executorBox.Name = "executorBox";
            this.executorBox.Size = new System.Drawing.Size(326, 30);
            this.executorBox.TabIndex = 46;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(68, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 16);
            this.label12.TabIndex = 45;
            this.label12.Text = "Исполнитель";
            // 
            // saveDetailBtn
            // 
            this.saveDetailBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveDetailBtn.Location = new System.Drawing.Point(103, 136);
            this.saveDetailBtn.Name = "saveDetailBtn";
            this.saveDetailBtn.Size = new System.Drawing.Size(268, 41);
            this.saveDetailBtn.TabIndex = 47;
            this.saveDetailBtn.Text = "Добавить";
            this.saveDetailBtn.UseVisualStyleBackColor = true;
            this.saveDetailBtn.Click += new System.EventHandler(this.saveDetailBtn_Click);
            // 
            // AddDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 233);
            this.Controls.Add(this.saveDetailBtn);
            this.Controls.Add(this.executorBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(491, 280);
            this.MinimumSize = new System.Drawing.Size(491, 280);
            this.Name = "AddDetailForm";
            this.Text = "Выберите помощника";
            this.Load += new System.EventHandler(this.AddDetailForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox executorBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button saveDetailBtn;
    }
}