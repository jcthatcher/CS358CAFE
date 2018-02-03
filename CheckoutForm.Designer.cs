namespace Cafe
{
    partial class CheckoutForm
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
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblConfoOrderNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblConfoWaitTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(185, 123);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(208, 26);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Your Total: $35.00";
            // 
            // lblConfoOrderNumber
            // 
            this.lblConfoOrderNumber.AutoSize = true;
            this.lblConfoOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfoOrderNumber.ForeColor = System.Drawing.Color.Maroon;
            this.lblConfoOrderNumber.Location = new System.Drawing.Point(100, 68);
            this.lblConfoOrderNumber.Name = "lblConfoOrderNumber";
            this.lblConfoOrderNumber.Size = new System.Drawing.Size(385, 55);
            this.lblConfoOrderNumber.TabIndex = 5;
            this.lblConfoOrderNumber.Text = "Order Number: 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Please have payment ready";
            // 
            // lblConfoWaitTime
            // 
            this.lblConfoWaitTime.AutoSize = true;
            this.lblConfoWaitTime.Location = new System.Drawing.Point(207, 216);
            this.lblConfoWaitTime.Name = "lblConfoWaitTime";
            this.lblConfoWaitTime.Size = new System.Drawing.Size(162, 13);
            this.lblConfoWaitTime.TabIndex = 9;
            this.lblConfoWaitTime.Text = "Estimated Wait Time: 22 Minutes";
            // 
            // CheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(580, 259);
            this.Controls.Add(this.lblConfoWaitTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblConfoOrderNumber);
            this.Controls.Add(this.lblPrice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CheckoutForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cafe Kiosk - Order Confirmation";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CheckoutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblConfoOrderNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblConfoWaitTime;
    }
}