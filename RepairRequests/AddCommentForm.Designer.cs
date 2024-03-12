namespace RepairRequests
{
    partial class AddCommentForm
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
            this.addCommentBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.commentTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addCommentBtn
            // 
            this.addCommentBtn.Location = new System.Drawing.Point(125, 246);
            this.addCommentBtn.Name = "addCommentBtn";
            this.addCommentBtn.Size = new System.Drawing.Size(215, 41);
            this.addCommentBtn.TabIndex = 116;
            this.addCommentBtn.Text = "Добавить комментарий";
            this.addCommentBtn.UseVisualStyleBackColor = true;
            this.addCommentBtn.Click += new System.EventHandler(this.addCommentBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(118, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 37);
            this.label1.TabIndex = 111;
            this.label1.Text = "Комментарий";
            // 
            // commentTxt
            // 
            this.commentTxt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.commentTxt.Location = new System.Drawing.Point(70, 112);
            this.commentTxt.MaxLength = 300;
            this.commentTxt.Multiline = true;
            this.commentTxt.Name = "commentTxt";
            this.commentTxt.Size = new System.Drawing.Size(325, 103);
            this.commentTxt.TabIndex = 110;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 109;
            this.label3.Text = "Комментарий";
            // 
            // AddCommentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 280);
            this.Controls.Add(this.addCommentBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.commentTxt);
            this.Controls.Add(this.label3);
            this.MaximumSize = new System.Drawing.Size(482, 397);
            this.MinimumSize = new System.Drawing.Size(482, 397);
            this.Name = "AddCommentForm";
            this.Text = "Комментарий";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addCommentBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox commentTxt;
        private System.Windows.Forms.Label label3;
    }
}