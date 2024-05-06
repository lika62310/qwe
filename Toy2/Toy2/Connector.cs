using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy2
{
    public class Connector : StockItem
    {
        public int ConnectorID { get; set; }
        public Connector(int connectorID, string name, double cost)
        {
            ConnectorID = connectorID;
            Name = name;
            Cost = cost;
        }
    }
}
