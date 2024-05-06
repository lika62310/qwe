using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy2
{
    public class Order
    {
        public string Name { get; set; }
        public int OrderID { get; set; }
        public double Cost { get; set; }
        public DateTime Date { get; set; }

        public Order(string name, int orderID, double cost, DateTime date, BoxSet boxSet)
        {
            Name = name;
            OrderID = orderID;
            Cost = cost;
            Date = date;
        }
    }
}
