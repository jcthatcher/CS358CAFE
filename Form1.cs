using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Cafe
{
    public partial class Form1 : Form
    {
        string dir = AppDomain.CurrentDomain.BaseDirectory;
        Order masterOrder = new Order();
        OrderLine myLine;
        bool firstItem;

        public Form1()
        {
            InitializeComponent();
            LoadCoffeeListView();
            LoadCoffeeOptions("1");
            firstItem = true;
        } 

        public Form1(Order myOrder)
        {
            InitializeComponent();
            LoadCoffeeListView();
            LoadCoffeeOptions("1");
            firstItem = false;
            masterOrder = myOrder;

        }

        public void AddedFirstItem()
        {
            string msg = "Click checkout button above or continue shopping. You will not see this message again with this order.";
            MessageBox.Show(msg, "Success!  Order updated.");
        }

        public void LoadCafeOptionsFromCSVFileToListBox(string csvName, ListBox box)
        {
            char separator = ',';

            string pathCSV = dir + csvName;

            using (StreamReader sReader = new StreamReader(pathCSV))
            {
                while (true)
                {
                    string line = sReader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }

                    string[] columns = line.Split(separator);

                    box.Items.Add(columns[1]);
                }
            }            
        }

        public void LoadCoffeeListView()
        {
            LoadCafeOptionsFromCSVFileToListBox("/data/Coffees.txt", listBoxCoffee);
        }

        public void LoadCoffeeOptions(string selectionID)
        {
            string[] columns= ReturnSelectionInformation("/data/Coffees.txt", selectionID);
            WriteToDetailsFromSelection(columns);
            LoadCafeOptionCheckBoxes("/data/CoffeeOptions.txt");
        }

        public void LoadCoffeeOptionsByName(string selectionName)
        {
            string[] columns = ReturnSelectionInformationByName("/data/Coffees.txt", selectionName);
            WriteToDetailsFromSelection(columns);
            LoadCafeOptionCheckBoxes("/data/CoffeeOptions.txt");
        }
        private void WriteToDetailsFromSelection(string[] details)
        {
            this.txtName.Text = details[1];
            this.txtRank.Text = details[0];
            this.txtPrice.Text = details[2];
            this.txtDescription.Text = details[3];
        }
               
        public void LoadCafeOptionCheckBoxes(string fileName)
        {
            int i = 1;
            string path = dir + fileName; 

            using (StreamReader sReader = new StreamReader(path))
            {
                while (true)
                {
                    string line = sReader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }

                    string[] columns = line.Split(',');

                    CheckBox box = new CheckBox
                    {
                        Name = "chkbx" + columns[1],
                        Text = columns[1] + " - " + columns[2],
                        AutoSize = true,
                        Checked = false,
                        Tag = columns[0],
                        Location = new Point(100, 185 + i * 18)
                    };
                    this.panel1.Controls.Add(box);
                    i = i + 1;
                }
            }
        }

        public void LoadTeaListView()
        {

        }

        public string[] ReturnSelectionInformation(string fileName, string selectionID)
        {
            string[] result;
            string path = dir + fileName; 

            using (StreamReader sReader = new StreamReader(path))
            {
                result = new string[] { "0", "0", "0", "0" };

                while (true)
                {
                    string line = sReader.ReadLine();
                    if (line == null)
                    {                        
                        break;
                    }

                    string[] columns = line.Split(',');

                    if (columns[0] == selectionID)
                    {
                        result = new string[] { columns[0], columns[1], columns[2], columns[3] };
                        break;
                    }                    
                }
            }

            return result;
        }

        public string[] ReturnSelectionInformationByName(string fileName, string selectionName)
        {
            string[] result;
            string path = dir + fileName;

            using (StreamReader sReader = new StreamReader(path))
            {
                while (true)
                {
                    string line = sReader.ReadLine();
                    if (line == null)
                    {
                        result = new string[] { "0", "0", "0", "0" };
                        break;
                    }

                    string[] columns = line.Split(',');

                    if (columns[1] == selectionName)
                    {
                        result = new string[] { columns[0], columns[1], columns[2], columns[3] };
                        break;
                    }
                }
            }

            return result;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            LoadTopCoffee();
            
        }

        private void LoadTopCoffee()
        {
            lblName.Text = "Top Pick";
            btnAddItem.Text = "Add Top Pick";
            string[] columns = ReturnSelectionInformation("/data/Coffees.txt", "1");
            WriteToDetailsFromSelection(columns);
        }
        

        private void lblRank_Click(object sender, EventArgs e)
        {

        }

        private void txtRank_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void listBoxCoffee_SelectedValueChanged(object sender, EventArgs e)
        {
            lblName.Text = "Selection";
            btnAddItem.Text = "Add Selection to Order";            
            LoadCoffeeOptionsByName(listBoxCoffee.SelectedItem.ToString());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if(txtDescription.Text.Length > 0)
            {
                string price = txtPrice.Text;
                string priceUpdate = price.Remove(0, 1);
                AddItemToOrder(txtName.Text, Convert.ToDouble(priceUpdate), txtDescription.Text);
                UpdateCart();
                ClearTextBoxes();
            }
        }

        private void ClearTextBoxes()
        {
            txtDescription.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtRank.Clear();
        }

        private void AddItemToOrder(string itemName, double price, string description)
        {
            myLine = new OrderLine(1, itemName, price, description);

            foreach (var control in panel1.Controls)
            {

                if (control is CheckBox)
                {
                    CheckBox box = (CheckBox)control;

                    if (box.Checked)
                    {
                        Options op = new Options();
                        string[] optionValues = ReturnSelectionInformation("/data/CoffeeOptions.txt", box.Tag.ToString());
                        op.Name = optionValues[1];
                        op.Quantity = 1;
                        op.Value = Convert.ToDouble(optionValues[3]);
                        myLine.OrderLineOptions.Add(op);
                    }
                }
            }
            masterOrder.AddItemToOrder(myLine);
            if (firstItem)
            {
                AddedFirstItem();
            }
            
            firstItem = false;
        }

        private void UpdateCart()
        {
            lblItemInfo.Text = "Items: " + masterOrder.GetTotalItems().ToString();
            lblItemSubtotal.Text = masterOrder.GetOrderValue().ToString("C");

            //string btnString = String.Format("Checkout:  {0} item at {1:C}", masterOrder.GetTotalItems(), masterOrder.GetOrderValue());
            //btnCheckout.Text = btnString;
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            CheckoutForm cForm = new CheckoutForm(masterOrder);
            cForm.ShowDialog();            
        }

        private void lblItemSubtotal_Click(object sender, EventArgs e)
        {

        }

        private void lblItemInfo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            masterOrder.ClearOrder();
            UpdateCart();
        }
    }
}
