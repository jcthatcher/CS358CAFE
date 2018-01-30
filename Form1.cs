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
        public Form1()
        {
            InitializeComponent();
            LoadCoffeeListView();
            LoadCoffeeOptionListView();
        }

        public void LoadCoffeeListView()
        {
            string path =AppDomain.CurrentDomain.BaseDirectory + "/data/Coffees.txt"; //System.IO.Directory.GetCurrentDirectory() + "data/Coffees.txt";

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

                    //for (int i = 0; i < columns.Count(); i++)
                    //{
                    //    lvi.SubItems.Add(columns[i]);
                    //}

                    listBoxCoffee.Items.Add(columns[1]);
                }
            }

        }

        public void LoadCoffeeOptionListView()
        {
            int i = 1;
            string path = AppDomain.CurrentDomain.BaseDirectory + "/data/CoffeeOptions.txt"; //System.IO.Directory.GetCurrentDirectory() + "data/CoffeeOptions.txt";

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

                    //for (int i = 0; i < columns.Count(); i++)
                    //{
                    //    lvi.SubItems.Add(columns[i]);
                    //}

                    CheckBox box = new CheckBox
                    {
                        Name = "chkbx" + columns[0],
                        Text = columns[0] + " - " + columns[1],
                        AutoSize = true,
                        Checked = true,
                        Location = new Point(105, 180 + i * 21)
                    };
                    this.panel1.Controls.Add(box);
                    i = i + 1;
                }
            }
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
            lblName.Text = "Top Pick";
            btnAddItem.Text = "Add Top Pick";

            string path = AppDomain.CurrentDomain.BaseDirectory + "/data/Coffees.txt"; //System.IO.Directory.GetCurrentDirectory() + "data/Coffees.txt";

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

                    //for (int i = 0; i < columns.Count(); i++)
                    //{
                    //    lvi.SubItems.Add(columns[i]);
                    //}

                    if (columns[0] == "1")
                    {
                        WriteToPanel1(columns);
                    }
                }
            }
        }

        private void WriteToPanel1(string[] details)
        {
            this.txtName.Text = details[1];
            this.txtRank.Text = details[0];
            this.txtPrice.Text = details[2];
            this.txtDescription.Text = details[3];
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

            string path = AppDomain.CurrentDomain.BaseDirectory + "/data/Coffees.txt"; //System.IO.Directory.GetCurrentDirectory() + "data/Coffees.txt";

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

                    //for (int i = 0; i < columns.Count(); i++)
                    //{
                    //    lvi.SubItems.Add(columns[i]);
                    //}

                    if (columns[1] == listBoxCoffee.SelectedItem.ToString())
                    {
                        WriteToPanel1(columns);
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
