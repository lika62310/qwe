using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy2
{
    abstract public class StockItem
    {
        public string Name { get; set; }
        public double Cost { get; set; }

        public int Amount { get; set; }

        public StockItem()
        { }
    }
}
