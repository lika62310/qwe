using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy2
{
    public class Order

    {
        public List<StockItem> Items { get; set; }
        public int OrderID { get; set; }
        public double Cost { get; set; }
        public DateTime Date { get; set; }


        public Order(int orderID, DateTime date)
        {
            OrderID = orderID;
            Cost = 0;
            Date = date;
            Items = new List<StockItem>();
        }

        public void UpdateCost()
        {
            foreach (StockItem item in Items)
            {
                Cost += item.Cost;
            }
        }
    }
}
