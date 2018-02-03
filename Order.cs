using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    public class Order
    {
        List<OrderLine> lineItems = new List<OrderLine>();
        double orderTotal;
        int orderItemCount;

        public List<OrderLine> LineItems { get => lineItems; set => lineItems = value; }

        public Order()
        {
            orderTotal = 0.0d;
        }

        public void AddItemToOrder(OrderLine OL)
        {
            LineItems.Add(OL);            
        }

        public void RemoveItemFromOrder(OrderLine OL)
        {
            LineItems.Remove(OL);
        }

        public List<Options> GetOptionsAsOptionsList()
        {
            List<Options> result = new List<Options>();

            foreach (OrderLine o in lineItems)
            {
                foreach(Options op in o.OrderLineOptions)
                {
                   result.Add(op);
                }
            }

            return result;
        }

        public double GetOrderValue()
        {
            double d = 0.00d;
            foreach(OrderLine ol in LineItems)
            {
                d = d + ol.TotalLineValue();
            }

            orderTotal = d;

            return orderTotal;
        }

        public double GetTotalItems()
        {
            orderItemCount = LineItems.Count();

            return orderItemCount;
        }

        public void ClearOrder()
        {
            LineItems.Clear();
        }
    }
}
