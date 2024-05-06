using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy2
{
    public class Package : StockItem
    {
        public int PackageID { get; set; }
        public Package (int packageID, string name, double cost, ConnectorRepo connectors)
        { 
            PackageID = packageID;
            Name = name;
            Cost = cost;
        }
    }
}
