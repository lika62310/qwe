using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy2
{
    public class BoxSet : StockItem
    {
        public int BoxSetID { get; set; }

        public BoxSet(int boxSetID, string name, double cost, Package package)
        {
            BoxSetID = boxSetID;
            Name = name;
            Cost = cost;
        }
    }
}
