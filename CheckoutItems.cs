using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe
{
    public partial class CheckoutItems : UserControl
    {
        string itemName;
        List<Options> ops;
        string price;
        string linePrice;

        public CheckoutItems()
        {
            InitializeComponent();
        }

        public string ItemName
        {
            get { return itemName; }
            set
            {
                itemName = value;
                txtName.Text = itemName;
            }
        }
        public List<Options> Ops
        {
            get { return ops; }
            set
            {
                ops = value;

                string optionString = "";

                foreach (Options o in Ops)
                {
                    optionString += o.Name + " - " + o.Value.ToString("C") + Environment.NewLine;
                }

                txtOptions.Text = optionString;
            }
        }
        public string Price { get => price; set
            {
                price = value;
                txtPrice.Text = $"{Price:C2}";
            }
        }
        public string LinePrice
        {
            get
            {
                return linePrice;
            }
            set
            {
                linePrice = value;
                txtLinePrice.Text = $"{LinePrice:C2}";
            }
        }

        public void PopulateThisControl()
        {   
         
        }

        private void txtLinePrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
