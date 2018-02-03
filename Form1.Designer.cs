namespace Cafe
{
    partial class Form1
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
            this.listBoxCoffee = new System.Windows.Forms.ListBox();
            this.lblSelection = new System.Windows.Forms.Label();
            this.txtRank = new System.Windows.Forms.TextBox();
            this.lblRank = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblItemSubtotal = new System.Windows.Forms.Label();
            this.pnlCheckout = new System.Windows.Forms.Panel();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lblOptions = new System.Windows.Forms.Label();
            this.lblItemInfo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_OptionsReset = new System.Windows.Forms.Button();
            this.radioCoffee = new System.Windows.Forms.RadioButton();
            this.radioTea = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioPastry = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxCoffee
            // 
            this.listBoxCoffee.BackColor = System.Drawing.Color.Gray;
            this.listBoxCoffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCoffee.FormattingEnabled = true;
            this.listBoxCoffee.ItemHeight = 16;
            this.listBoxCoffee.Location = new System.Drawing.Point(20, 47);
            this.listBoxCoffee.MultiColumn = true;
            this.listBoxCoffee.Name = "listBoxCoffee";
            this.listBoxCoffee.Size = new System.Drawing.Size(159, 164);
            this.listBoxCoffee.TabIndex = 3;
            this.listBoxCoffee.SelectedValueChanged += new System.EventHandler(this.listBoxCoffee_SelectedValueChanged);
            // 
            // lblSelection
            // 
            this.lblSelection.AutoSize = true;
            this.lblSelection.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelection.ForeColor = System.Drawing.Color.White;
            this.lblSelection.Location = new System.Drawing.Point(16, 16);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(163, 22);
            this.lblSelection.TabIndex = 2;
            this.lblSelection.Text = "Coffee Selections";
            // 
            // txtRank
            // 
            this.txtRank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRank.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtRank.Location = new System.Drawing.Point(231, 149);
            this.txtRank.Name = "txtRank";
            this.txtRank.ReadOnly = true;
            this.txtRank.Size = new System.Drawing.Size(49, 16);
            this.txtRank.TabIndex = 7;
            this.txtRank.TextChanged += new System.EventHandler(this.txtRank_TextChanged);
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblRank.Location = new System.Drawing.Point(184, 149);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(45, 17);
            this.lblRank.TabIndex = 6;
            this.lblRank.Text = "Rank:";
            this.lblRank.Click += new System.EventHandler(this.lblRank_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPrice.Location = new System.Drawing.Point(231, 183);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(49, 16);
            this.txtPrice.TabIndex = 9;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblPrice.Location = new System.Drawing.Point(185, 183);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 17);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Price:";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtDescription.Location = new System.Drawing.Point(186, 51);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(155, 92);
            this.txtDescription.TabIndex = 11;
            this.txtDescription.Text = "Hello";
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblItemSubtotal);
            this.panel1.Controls.Add(this.pnlCheckout);
            this.panel1.Controls.Add(this.btnCheckout);
            this.panel1.Controls.Add(this.lblItemInfo);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(370, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 488);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblItemSubtotal
            // 
            this.lblItemSubtotal.AutoSize = true;
            this.lblItemSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemSubtotal.ForeColor = System.Drawing.Color.White;
            this.lblItemSubtotal.Location = new System.Drawing.Point(351, 446);
            this.lblItemSubtotal.Name = "lblItemSubtotal";
            this.lblItemSubtotal.Size = new System.Drawing.Size(66, 26);
            this.lblItemSubtotal.TabIndex = 9;
            this.lblItemSubtotal.Text = "$0.00";
            this.lblItemSubtotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblItemSubtotal.Click += new System.EventHandler(this.lblItemSubtotal_Click);
            // 
            // pnlCheckout
            // 
            this.pnlCheckout.AutoScroll = true;
            this.pnlCheckout.BackColor = System.Drawing.Color.Gray;
            this.pnlCheckout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlCheckout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCheckout.Location = new System.Drawing.Point(13, 47);
            this.pnlCheckout.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCheckout.Name = "pnlCheckout";
            this.pnlCheckout.Size = new System.Drawing.Size(406, 389);
            this.pnlCheckout.TabIndex = 13;
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.Green;
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(13, 447);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(0);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(134, 30);
            this.btnCheckout.TabIndex = 7;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(338, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 27);
            this.button1.TabIndex = 10;
            this.button1.Text = " Clear Order";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Order Summary";
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.Olive;
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(20, 446);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(311, 30);
            this.btnAddItem.TabIndex = 14;
            this.btnAddItem.Text = "Add Item to Cart";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptions.ForeColor = System.Drawing.Color.White;
            this.lblOptions.Location = new System.Drawing.Point(17, 224);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(134, 24);
            this.lblOptions.TabIndex = 13;
            this.lblOptions.Text = "Coffee Options";
            // 
            // lblItemInfo
            // 
            this.lblItemInfo.AutoSize = true;
            this.lblItemInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemInfo.Location = new System.Drawing.Point(207, 451);
            this.lblItemInfo.Name = "lblItemInfo";
            this.lblItemInfo.Size = new System.Drawing.Size(66, 20);
            this.lblItemInfo.TabIndex = 8;
            this.lblItemInfo.Text = "Items: 0";
            this.lblItemInfo.Click += new System.EventHandler(this.lblItemInfo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btnAddItem);
            this.panel2.Controls.Add(this.listBoxCoffee);
            this.panel2.Controls.Add(this.lblOptions);
            this.panel2.Controls.Add(this.txtDescription);
            this.panel2.Controls.Add(this.lblSelection);
            this.panel2.Controls.Add(this.lblRank);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.lblPrice);
            this.panel2.Controls.Add(this.txtRank);
            this.panel2.Controls.Add(this.btn_OptionsReset);
            this.panel2.Location = new System.Drawing.Point(13, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 488);
            this.panel2.TabIndex = 9;
            // 
            // btn_OptionsReset
            // 
            this.btn_OptionsReset.FlatAppearance.BorderSize = 0;
            this.btn_OptionsReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OptionsReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OptionsReset.ForeColor = System.Drawing.Color.Gray;
            this.btn_OptionsReset.Location = new System.Drawing.Point(17, 246);
            this.btn_OptionsReset.Name = "btn_OptionsReset";
            this.btn_OptionsReset.Size = new System.Drawing.Size(75, 18);
            this.btn_OptionsReset.TabIndex = 15;
            this.btn_OptionsReset.Text = "(RESET)";
            this.btn_OptionsReset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_OptionsReset.UseVisualStyleBackColor = true;
            this.btn_OptionsReset.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioCoffee
            // 
            this.radioCoffee.AutoSize = true;
            this.radioCoffee.BackColor = System.Drawing.Color.Gray;
            this.radioCoffee.Checked = true;
            this.radioCoffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCoffee.ForeColor = System.Drawing.Color.Black;
            this.radioCoffee.Location = new System.Drawing.Point(13, 23);
            this.radioCoffee.Name = "radioCoffee";
            this.radioCoffee.Size = new System.Drawing.Size(86, 21);
            this.radioCoffee.TabIndex = 15;
            this.radioCoffee.TabStop = true;
            this.radioCoffee.Text = "COFFEE";
            this.radioCoffee.UseVisualStyleBackColor = false;
            this.radioCoffee.CheckedChanged += new System.EventHandler(this.radioMenuOptions_CheckerChanged);
            // 
            // radioTea
            // 
            this.radioTea.AutoSize = true;
            this.radioTea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTea.ForeColor = System.Drawing.Color.Black;
            this.radioTea.Location = new System.Drawing.Point(143, 23);
            this.radioTea.Name = "radioTea";
            this.radioTea.Size = new System.Drawing.Size(56, 21);
            this.radioTea.TabIndex = 16;
            this.radioTea.TabStop = true;
            this.radioTea.Text = "TEA";
            this.radioTea.UseVisualStyleBackColor = true;
            this.radioTea.CheckedChanged += new System.EventHandler(this.radioMenuOptions_CheckerChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.radioPastry);
            this.groupBox1.Controls.Add(this.radioCoffee);
            this.groupBox1.Controls.Add(this.radioTea);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(13, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 53);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu Options";
            // 
            // radioPastry
            // 
            this.radioPastry.AutoSize = true;
            this.radioPastry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPastry.ForeColor = System.Drawing.Color.Black;
            this.radioPastry.Location = new System.Drawing.Point(244, 23);
            this.radioPastry.Name = "radioPastry";
            this.radioPastry.Size = new System.Drawing.Size(87, 21);
            this.radioPastry.TabIndex = 18;
            this.radioPastry.TabStop = true;
            this.radioPastry.Text = "PASTRY";
            this.radioPastry.UseVisualStyleBackColor = true;
            this.radioPastry.CheckedChanged += new System.EventHandler(this.radioMenuOptions_CheckerChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(822, 563);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cafe Kiosk";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblSelection;
        private System.Windows.Forms.ListBox listBoxCoffee;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtRank;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label lblItemInfo;
        private System.Windows.Forms.Label lblItemSubtotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlCheckout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioCoffee;
        private System.Windows.Forms.RadioButton radioTea;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioPastry;
        private System.Windows.Forms.Button btn_OptionsReset;
    }
}

