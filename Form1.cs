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
        string selectionCsvFile;
        string lblSelectionText;
        string lblOptionsText;
        MenuSelection CurrentMenuSelection;
        string optionCsvFile;
        Order masterOrder = new Order();
        OrderLine myLine;

        enum MenuSelection { Coffee, Tea, Pastry };
        
        public Form1()
        {
            InitializeComponent();
            InitializeOrder();
        }

        private void InitializeOrder()
        {            
            radioCoffee.Checked = true;
            MenuSelection CurrentMenuSelection = MenuSelection.Coffee;
            UpdateEnvironmentalVariables();
            ClearMenuListBox();
            LoadCafeMenuFromCSVFileToListBox();
            LoadMenuSelectionOptions("1");
            UncheckAllCheckBoxes();
            LoadTopPick();
        }

        private void UpdateEnvironmentalVariables()
        {
            switch (CurrentMenuSelection)
            {
                case MenuSelection.Coffee:
                    selectionCsvFile = "/data/Coffees.txt";
                    optionCsvFile = "/data/CoffeeOptions.txt";
                    lblSelectionText = "Coffee Selections";
                    lblOptionsText = "Coffee Options";
                    break;

                case MenuSelection.Tea:
                    selectionCsvFile = "/data/Teas.txt";
                    optionCsvFile = "/data/TeaOptions.txt";
                    lblSelectionText = "Tea Selections";
                    lblOptionsText = "Tea Options";
                    break;

                case MenuSelection.Pastry:
                    selectionCsvFile = "/data/Pastries.txt";
                    optionCsvFile = "/data/PastryOptions.txt";
                    lblSelectionText = "Pastry Selections";
                    lblOptionsText = "Pastry Options";
                    break;

                default:
                    selectionCsvFile = "/data/Coffees.txt";
                    optionCsvFile = "/data/CoffeeOptions.txt";
                    break;
            }
        }

        private void BigSpenderAlert()
        {
            MessageBox.Show("Orders over $35.00 require prepayment", "Hey Big Spender!");
        }

        public void LoadCafeMenuFromCSVFileToListBox()
        {
            char separator = ',';

            string pathCSV = dir + selectionCsvFile;

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

                    listBoxCoffee.Items.Add(columns[1]);
                }
            }

            lblOptions.Text = lblOptionsText;
            lblSelection.Text = lblSelectionText;
        }

        private void AddItemToOrder(string itemName, double price, string description)
        {
            if (masterOrder.GetOrderValue() + price > 35.00d)
            {
                BigSpenderAlert();
            }
            else
            {
                myLine = new OrderLine(1, itemName, price, description);

                foreach (var control in panel2.Controls)
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
            }
        }

        private void UpdateCart()
        {
            lblItemInfo.Text = "Items: " + masterOrder.GetTotalItems().ToString();
            lblItemSubtotal.Text = masterOrder.GetOrderValue().ToString("C");
        }

        public void LoadMenuSelectionOptions(string selectionID)
        {
            string[] columns = ReturnSelectionInformation(selectionCsvFile, selectionID);
            WriteToDetailsFromSelection(columns);
            LoadCafeOptionCheckBoxes();
        }

        public void LoadOptionsByName(string selectionName)
        {
            string[] columns = ReturnSelectionInformationByName(selectionCsvFile, selectionName);
            WriteToDetailsFromSelection(columns);
            LoadCafeOptionCheckBoxes();
        }

        private void WriteToDetailsFromSelection(string[] details)
        {
            this.txtRank.Text = details[0];
            this.txtPrice.Text = details[2];
            this.txtDescription.Text = details[3];
        }
               
        public void LoadCafeOptionCheckBoxes()
        {
            int i = 1;
            string path = dir + optionCsvFile; 

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
                        Location = new Point(25, 250 + i * 18)
                    };
                    box.Font = new Font(box.Font.FontFamily, 8f);
                    this.panel2.Controls.Add(box);
                    i = i + 1;
                }
            }
        }

        public void RemoveCheckBoxes()
        {
            int checkBoxControls = panel2.Controls.OfType<CheckBox>().Count();
            int i = 0;

            CheckBox[] checkBoxes = new CheckBox[checkBoxControls];
            
            foreach (Control control in panel2.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox box = (CheckBox)control;
                    checkBoxes[i] = box;
                    i++;
                }
            }

            for (int j = 0; j<checkBoxes.Length; j++)
            {
                panel2.Controls.Remove(checkBoxes[j]);
            }
        }

        public void UncheckAllCheckBoxes()
        {
            foreach (var control in panel2.Controls)
            {

                if (control is CheckBox)
                {
                    CheckBox box = (CheckBox)control;

                    box.Checked = false;
                }
            }
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
       
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadTopPick()
        {
            string[] columns = ReturnSelectionInformation(selectionCsvFile, "1");
            WriteToDetailsFromSelection(columns);
            int listLocation = listBoxCoffee.FindString(columns[1]);
            listBoxCoffee.SetSelected(listLocation, true);
        }

        private void UpdateMenuItems()
        {
            ClearMenuListBox();
            RemoveCheckBoxes();

            if (radioCoffee.Checked)
            {
                CurrentMenuSelection = MenuSelection.Coffee;
            }
            if (radioPastry.Checked)
            {
                CurrentMenuSelection = MenuSelection.Pastry;
            }
            if (radioTea.Checked)
            {
                CurrentMenuSelection = MenuSelection.Tea;
            }

            UpdateEnvironmentalVariables();
            LoadCafeMenuFromCSVFileToListBox();
            LoadCafeOptionCheckBoxes();
        }

        private void ClearMenuListBox()
        {
            listBoxCoffee.Items.Clear();
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
            LoadOptionsByName(listBoxCoffee.SelectedItem.ToString());
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
                AddItemToOrder(listBoxCoffee.Text, Convert.ToDouble(priceUpdate), txtDescription.Text);
                UpdateCart();
                UpdateOrderSummaryView();
            }
        }

        private void UpdateOrderSummaryView()
        {
            this.pnlCheckout.Controls.Clear();

            int p = Convert.ToInt32(masterOrder.GetTotalItems());
            Control[] myC = new Control[p];
            int x = 1;
            int y = 0;
            int i = 0;
            foreach (OrderLine o in masterOrder.LineItems)
            {
                CheckoutItems myCheck = new CheckoutItems
                {
                    Name = "myCheck" + i,
                    Location = new Point(x, y),
                    Size = new Size(322, 100),
                    BackColor = Color.FromName("Gray"),
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

        private void ClearTextBoxes()
        {
            txtDescription.Clear();
            txtPrice.Clear();
            txtRank.Clear();
        }        

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            CheckoutForm cForm = new CheckoutForm(masterOrder);
            cForm.ShowDialog();
            masterOrder.ClearOrder();
            UpdateCart();
            UpdateOrderSummaryView();
            InitializeOrder();
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
            UpdateOrderSummaryView();
            InitializeOrder();
            LoadTopPick();
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

        private void button2_Click(object sender, EventArgs e)
        {
            UncheckAllCheckBoxes();            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateMenuItems();
        }

        private void radioMenuOptions_CheckerChanged(object sender, EventArgs e)
        {
            UpdateMenuItems();
            LoadTopPick();
        }

        
    }
}
