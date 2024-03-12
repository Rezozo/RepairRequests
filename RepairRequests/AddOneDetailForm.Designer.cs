namespace RepairRequests
{
    partial class AddOneDetailForm
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
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.costTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.countTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addDetailsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleTxt
            // 
            this.titleTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.titleTxt.Location = new System.Drawing.Point(104, 83);
            this.titleTxt.MaxLength = 300;
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(325, 30);
            this.titleTxt.TabIndex = 90;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 89;
            this.label3.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(204, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 37);
            this.label1.TabIndex = 95;
            this.label1.Text = "Деталь";
            // 
            // costTxt
            // 
            this.costTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costTxt.Location = new System.Drawing.Point(104, 145);
            this.costTxt.MaxLength = 9;
            this.costTxt.Name = "costTxt";
            this.costTxt.Size = new System.Drawing.Size(325, 30);
            this.costTxt.TabIndex = 97;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 96;
            this.label4.Text = "Цена";
            // 
            // countTxt
            // 
            this.countTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countTxt.Location = new System.Drawing.Point(104, 210);
            this.countTxt.MaxLength = 2;
            this.countTxt.Name = "countTxt";
            this.countTxt.Size = new System.Drawing.Size(325, 30);
            this.countTxt.TabIndex = 99;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 98;
            this.label2.Text = "Количество";
            // 
            // addDetailsBtn
            // 
            this.addDetailsBtn.Location = new System.Drawing.Point(153, 262);
            this.addDetailsBtn.Name = "addDetailsBtn";
            this.addDetailsBtn.Size = new System.Drawing.Size(221, 41);
            this.addDetailsBtn.TabIndex = 108;
            this.addDetailsBtn.Text = "Добавить запчасти";
            this.addDetailsBtn.UseVisualStyleBackColor = true;
            this.addDetailsBtn.Click += new System.EventHandler(this.addDetailsBtn_Click);
            // 
            // AddOneDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 350);
            this.Controls.Add(this.addDetailsBtn);
            this.Controls.Add(this.countTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.costTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.label3);
            this.Name = "AddOneDetailForm";
            this.Text = "Добавление детали";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox costTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox countTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addDetailsBtn;
    }
}