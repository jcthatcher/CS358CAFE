namespace Cafe
{
    partial class CheckoutItems
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtOptions = new System.Windows.Forms.TextBox();
            this.txtLinePrice = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Control;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.CausesValidation = false;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(9, 8);
            this.txtName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.txtName.MaximumSize = new System.Drawing.Size(360, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 23);
            this.txtName.TabIndex = 0;
            // 
            // txtOptions
            // 
            this.txtOptions.BackColor = System.Drawing.SystemColors.Control;
            this.txtOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOptions.CausesValidation = false;
            this.txtOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOptions.Location = new System.Drawing.Point(35, 34);
            this.txtOptions.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.txtOptions.MaximumSize = new System.Drawing.Size(360, 0);
            this.txtOptions.Multiline = true;
            this.txtOptions.Name = "txtOptions";
            this.txtOptions.Size = new System.Drawing.Size(133, 37);
            this.txtOptions.TabIndex = 1;
            // 
            // txtLinePrice
            // 
            this.txtLinePrice.BackColor = System.Drawing.SystemColors.Control;
            this.txtLinePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLinePrice.CausesValidation = false;
            this.txtLinePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLinePrice.Location = new System.Drawing.Point(255, 7);
            this.txtLinePrice.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.txtLinePrice.MaximumSize = new System.Drawing.Size(360, 0);
            this.txtLinePrice.Name = "txtLinePrice";
            this.txtLinePrice.Size = new System.Drawing.Size(65, 23);
            this.txtLinePrice.TabIndex = 2;
            this.txtLinePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLinePrice.TextChanged += new System.EventHandler(this.txtLinePrice_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.CausesValidation = false;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(134, 10);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.txtPrice.MaximumSize = new System.Drawing.Size(360, 0);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(64, 20);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.TabStop = false;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CheckoutItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtLinePrice);
            this.Controls.Add(this.txtOptions);
            this.Controls.Add(this.txtName);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.Name = "CheckoutItems";
            this.Size = new System.Drawing.Size(330, 77);
            this.Load += new System.EventHandler(this.CheckoutItems_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtOptions;
        private System.Windows.Forms.TextBox txtLinePrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
