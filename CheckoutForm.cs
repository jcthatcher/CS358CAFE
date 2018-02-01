using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe
{
    public partial class CheckoutForm : Form
    {
        Order order;

        public CheckoutForm(Order myOrder)
        {
            order = myOrder;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newForm1 = new Form1();
            newForm1.Show();
        }

        private void UpdateLabelTotal()
        {
            lblPrice.Text = "Total " + order.GetOrderValue().ToString("C");
        }

        private void CheckoutForm_Load(object sender, EventArgs e)
        {
            UpdateLabelTotal();
            PopulateListView();
        }

        private void PopulateListView()
        {
            int p = Convert.ToInt32(order.GetTotalItems());
            Control[] myC = new Control[p];
            int x = 5;
            int y = 50;
            int i = 0;
            foreach(OrderLine o in order.LineItems)
            {
                CheckoutItems myCheck = new CheckoutItems
                {
                    Name = "myCheck" + i,
                    Location = new Point(x, y + i * 100),
                    Size = new Size(550, 100),
                    ItemName = o.ProductName,
                    Price = o.ProductPrice.ToString("C"),
                    LinePrice = o.TotalLineValue().ToString("C"),
                    Ops = o.OrderLineOptions,
                    Tag = "myCheck" + i,                 
                };
                myC[i] = myCheck;
                i += 1;
            }
            this.Controls.AddRange(myC);
        }

        private void btnFinalCheckOut(object sender, EventArgs e)
        {

        }
    }
}
