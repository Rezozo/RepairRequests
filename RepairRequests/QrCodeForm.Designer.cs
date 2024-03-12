namespace RepairRequests
{
    partial class QrCodeForm
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
            this.qrCodeBox = new System.Windows.Forms.PictureBox();
            this.infoLabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qrCodeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // qrCodeBox
            // 
            this.qrCodeBox.Location = new System.Drawing.Point(90, 70);
            this.qrCodeBox.Name = "qrCodeBox";
            this.qrCodeBox.Size = new System.Drawing.Size(292, 248);
            this.qrCodeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.qrCodeBox.TabIndex = 0;
            this.qrCodeBox.TabStop = false;
            // 
            // infoLabel2
            // 
            this.infoLabel2.AutoSize = true;
            this.infoLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoLabel2.Location = new System.Drawing.Point(93, 24);
            this.infoLabel2.Name = "infoLabel2";
            this.infoLabel2.Size = new System.Drawing.Size(289, 22);
            this.infoLabel2.TabIndex = 7;
            this.infoLabel2.Text = "Ваш отзыв очень важен для нас!";
            // 
            // QrCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 345);
            this.Controls.Add(this.infoLabel2);
            this.Controls.Add(this.qrCodeBox);
            this.MaximumSize = new System.Drawing.Size(505, 392);
            this.MinimumSize = new System.Drawing.Size(505, 392);
            this.Name = "QrCodeForm";
            this.Text = "QrCode";
            this.Load += new System.EventHandler(this.QrCodeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qrCodeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox qrCodeBox;
        private System.Windows.Forms.Label infoLabel2;
    }
}