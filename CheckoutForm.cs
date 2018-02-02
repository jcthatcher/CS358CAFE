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
            //Form1 newForm1 = new Form1();
           // newForm1.Show();
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
            int x = 1;
            int y = 0;
            int i = 0;
            foreach(OrderLine o in order.LineItems)
            {
                CheckoutItems myCheck = new CheckoutItems
                {
                    Name = "myCheck" + i,
                    Location = new Point(x, y),
                    Size = new Size(412, 100),
                    ItemName = o.ProductName,
                    Price = o.ProductPrice.ToString("C"),
                    LinePrice = o.TotalLineValue().ToString("C"),
                    Ops = o.OrderLineOptions,
                    Height = o.OrderLineOptions.Count * 10 + 50,
                    Tag = "myCheck" + i,
                    
                };
                myC[i] = myCheck;
                y = y + o.OrderLineOptions.Count * 8 + 50;
                i += 1;
            }
            this.pnlCheckout.Controls.AddRange(myC);
        }

        private void btnFinalCheckOut(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
