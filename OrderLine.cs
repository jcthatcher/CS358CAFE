using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    class OrderLine
    {
        int optionIDTracker;
        string itemType;
        int quantityOrdered;
        string productName;
        double productPrice;
        double lineValue;
        string productDescription;
        List<Options> orderLineOptions = new List<Options>();

        public string ItemType { get => itemType; set => itemType = value; }
        public int QuantityOrdered { get => quantityOrdered; set => quantityOrdered = value; }
        public string ProductName { get => productName; }
        public double ProductPrice { get => productPrice;}
        public string ProductDescription { get => productDescription; set => productDescription = value; }
        internal List<Options> OrderLineOptions { get => orderLineOptions; set => orderLineOptions = value; }

        public OrderLine(string pName, double pPrice)
        {
            productName = pName;
            productPrice = pPrice;
            lineValue = TotalLineValue();
        }

        public OrderLine(string pName, double pPrice, List<Options> options)
        {
            productName = pName;
            productPrice = pPrice;
            OrderLineOptions = options;
            lineValue = TotalLineValue();
        }

        public OrderLine(int quantity, string pName, double pPrice, string pDescription)
        {
            QuantityOrdered = quantity;
            productName = pName;
            productPrice = pPrice;
            ProductDescription = pDescription;
            lineValue = TotalLineValue();
        }

        public double TotalLineValue()
        {
            double optionValue = 0.0d;

            foreach (Options o in OrderLineOptions)
            {
                optionValue += o.Quantity * o.Value;
            }

            return Convert.ToDouble(QuantityOrdered) * ProductPrice + optionValue;
        }

        public void RemoveAllOptions(string optionName, double optionValue)
        {
            OrderLineOptions = new List<Options>();
        }    
        
        public void RemoveOptionByID(int optionID)
        {
            OrderLineOptions.RemoveAt(optionID);
        }
    }
}
