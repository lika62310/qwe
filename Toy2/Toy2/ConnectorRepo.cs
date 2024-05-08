using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy2
{
    public class ConnectorRepo
    {
        public List<Connector> Connectors;

        public ConnectorRepo()
        {
            Connectors = new List<Connector>();
        }

        public void AddConnector(Connector connector)
        {
            Connectors.Add(connector);
        }
    }
}
