using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    public class Options
    {
        int optionID;
        int quantity;
        string name;
        double value;

        public Options()
        {

        }

        public Options(int id, string optionName, double optionPrice)
        {
            optionID = id;
            Quantity = 1;
            Name = optionName;
            Value = optionPrice;
        }

        public Options(int id, int optionQuantity, string optionName, double optionPrice)
        {
            optionID = id;
            Quantity = optionQuantity;
            Name = optionName;
            Value = optionPrice;
        }

        public int Quantity { get => quantity; set => quantity = value; }
        public string Name { get => name; set => name = value; }
        public double Value { get => value; set => this.value = value; }
    }
}
