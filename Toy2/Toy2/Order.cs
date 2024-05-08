using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy2
{
    public class Order
    {
        public int OrderID { get; set; }
        public double Cost { get; set; }
        public DateTime Date { get; set; }

        public List<StockItem> Items { get; set; }

        public Order(int orderID, double cost, DateTime date)
        {
            OrderID = orderID;
            Cost = cost;
            Date = date;
            Items = new List<StockItem>();
        }
    }
}
