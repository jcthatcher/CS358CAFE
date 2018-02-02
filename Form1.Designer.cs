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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCoffee = new System.Windows.Forms.TabPage();
            this.listBoxCoffee = new System.Windows.Forms.ListBox();
            this.lblCoffeeSelect = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxTea = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBoxPastry = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRank = new System.Windows.Forms.TextBox();
            this.lblRank = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.lblItemInfo = new System.Windows.Forms.Label();
            this.lblItemSubtotal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlCheckout = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabCoffee.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCoffee);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(29, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(25, 5);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(373, 521);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCoffee
            // 
            this.tabCoffee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabCoffee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabCoffee.Controls.Add(this.listBoxCoffee);
            this.tabCoffee.Controls.Add(this.btnAddItem);
            this.tabCoffee.Controls.Add(this.txtDescription);
            this.tabCoffee.Controls.Add(this.lblCoffeeSelect);
            this.tabCoffee.Controls.Add(this.lblDescription);
            this.tabCoffee.Controls.Add(this.label1);
            this.tabCoffee.Controls.Add(this.txtPrice);
            this.tabCoffee.Controls.Add(this.txtRank);
            this.tabCoffee.Controls.Add(this.lblPrice);
            this.tabCoffee.Controls.Add(this.lblRank);
            this.tabCoffee.Location = new System.Drawing.Point(4, 33);
            this.tabCoffee.Name = "tabCoffee";
            this.tabCoffee.Padding = new System.Windows.Forms.Padding(29, 3, 29, 3);
            this.tabCoffee.Size = new System.Drawing.Size(365, 484);
            this.tabCoffee.TabIndex = 0;
            this.tabCoffee.Text = "Coffee";
            // 
            // listBoxCoffee
            // 
            this.listBoxCoffee.BackColor = System.Drawing.Color.Silver;
            this.listBoxCoffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCoffee.FormattingEnabled = true;
            this.listBoxCoffee.ItemHeight = 16;
            this.listBoxCoffee.Location = new System.Drawing.Point(16, 42);
            this.listBoxCoffee.MultiColumn = true;
            this.listBoxCoffee.Name = "listBoxCoffee";
            this.listBoxCoffee.Size = new System.Drawing.Size(159, 164);
            this.listBoxCoffee.TabIndex = 3;
            this.listBoxCoffee.SelectedValueChanged += new System.EventHandler(this.listBoxCoffee_SelectedValueChanged);
            // 
            // lblCoffeeSelect
            // 
            this.lblCoffeeSelect.AutoSize = true;
            this.lblCoffeeSelect.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoffeeSelect.Location = new System.Drawing.Point(12, 10);
            this.lblCoffeeSelect.Name = "lblCoffeeSelect";
            this.lblCoffeeSelect.Size = new System.Drawing.Size(163, 22);
            this.lblCoffeeSelect.TabIndex = 2;
            this.lblCoffeeSelect.Text = "Coffee Selections";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxTea);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(329, 484);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tea";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxTea
            // 
            this.listBoxTea.BackColor = System.Drawing.Color.Silver;
            this.listBoxTea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxTea.FormattingEnabled = true;
            this.listBoxTea.ItemHeight = 20;
            this.listBoxTea.Location = new System.Drawing.Point(16, 65);
            this.listBoxTea.MultiColumn = true;
            this.listBoxTea.Name = "listBoxTea";
            this.listBoxTea.Size = new System.Drawing.Size(290, 244);
            this.listBoxTea.TabIndex = 5;
            this.listBoxTea.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select Tea";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listBoxPastry);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(329, 484);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pastry";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listBoxPastry
            // 
            this.listBoxPastry.BackColor = System.Drawing.Color.Silver;
            this.listBoxPastry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxPastry.FormattingEnabled = true;
            this.listBoxPastry.ItemHeight = 20;
            this.listBoxPastry.Location = new System.Drawing.Point(16, 65);
            this.listBoxPastry.MultiColumn = true;
            this.listBoxPastry.Name = "listBoxPastry";
            this.listBoxPastry.Size = new System.Drawing.Size(290, 244);
            this.listBoxPastry.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Select Pastry";
            // 
            // txtRank
            // 
            this.txtRank.BackColor = System.Drawing.Color.White;
            this.txtRank.Enabled = false;
            this.txtRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRank.Location = new System.Drawing.Point(229, 39);
            this.txtRank.Name = "txtRank";
            this.txtRank.Size = new System.Drawing.Size(49, 23);
            this.txtRank.TabIndex = 7;
            this.txtRank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRank.TextChanged += new System.EventHandler(this.txtRank_TextChanged);
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank.Location = new System.Drawing.Point(182, 42);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(41, 17);
            this.lblRank.TabIndex = 6;
            this.lblRank.Text = "Rank";
            this.lblRank.Click += new System.EventHandler(this.lblRank_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.White;
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(229, 70);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(49, 23);
            this.txtPrice.TabIndex = 9;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(183, 73);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(40, 17);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Price";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.Enabled = false;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(187, 128);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(165, 78);
            this.txtDescription.TabIndex = 11;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(184, 103);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 17);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Description";
            this.lblDescription.Click += new System.EventHandler(this.lblDescription_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.pnlCheckout);
            this.panel1.Controls.Add(this.btnCheckout);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(408, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 488);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(118, 446);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(234, 30);
            this.btnAddItem.TabIndex = 14;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Coffee Options";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(274, 449);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(134, 28);
            this.btnCheckout.TabIndex = 7;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // lblItemInfo
            // 
            this.lblItemInfo.AutoSize = true;
            this.lblItemInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemInfo.Location = new System.Drawing.Point(881, 74);
            this.lblItemInfo.Name = "lblItemInfo";
            this.lblItemInfo.Size = new System.Drawing.Size(90, 26);
            this.lblItemInfo.TabIndex = 8;
            this.lblItemInfo.Text = "Items: 0";
            this.lblItemInfo.Click += new System.EventHandler(this.lblItemInfo_Click);
            // 
            // lblItemSubtotal
            // 
            this.lblItemSubtotal.AutoSize = true;
            this.lblItemSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemSubtotal.Location = new System.Drawing.Point(1042, 74);
            this.lblItemSubtotal.Name = "lblItemSubtotal";
            this.lblItemSubtotal.Size = new System.Drawing.Size(66, 26);
            this.lblItemSubtotal.TabIndex = 9;
            this.lblItemSubtotal.Text = "$0.00";
            this.lblItemSubtotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblItemSubtotal.Click += new System.EventHandler(this.lblItemSubtotal_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(326, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
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
            this.label5.Location = new System.Drawing.Point(11, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "Order Summary";
            // 
            // pnlCheckout
            // 
            this.pnlCheckout.AutoScroll = true;
            this.pnlCheckout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlCheckout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCheckout.Location = new System.Drawing.Point(13, 47);
            this.pnlCheckout.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCheckout.Name = "pnlCheckout";
            this.pnlCheckout.Size = new System.Drawing.Size(395, 395);
            this.pnlCheckout.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1387, 580);
            this.Controls.Add(this.lblItemSubtotal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblItemInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Cafe Kiosk";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabCoffee.ResumeLayout(false);
            this.tabCoffee.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCoffee;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblCoffeeSelect;
        private System.Windows.Forms.ListBox listBoxCoffee;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtRank;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxTea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxPastry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label lblItemInfo;
        private System.Windows.Forms.Label lblItemSubtotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlCheckout;
    }
}

