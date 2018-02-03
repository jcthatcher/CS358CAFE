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

        private void UpdateLabelTotal()
        {
            lblPrice.Text = "Your Total: " + order.GetOrderValue().ToString("C");
            lblConfoOrderNumber.Text = "Order Number: " + GetOrderNumber().ToString();
            lblConfoWaitTime.Text = "Estimated Wait Time: " + GetWaitTime().ToString() + " Minutes";
        }

        private void CheckoutForm_Load(object sender, EventArgs e)
        {
            UpdateLabelTotal();
        }
        
        private int GetWaitTime()
        {
            System.Random random = new Random();
            int result = random.Next(6, 13);
            return result;
        }

        private int GetOrderNumber()
        {
            System.Random random = new Random();
            int result = random.Next(4, 12);
            return result;            
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
