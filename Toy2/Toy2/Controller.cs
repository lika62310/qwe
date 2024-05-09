using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Toy2
{
    public class Controller
    {
        //public ConnectorRepo connectorRepo;
        public List<StockItem> Connectors = new List<StockItem>();
        public Controller() 
        { 
            
        }

        public void AddNewProduct(Connector connector) 
        {
           Connectors.Add(connector);   
        }

        public void RemoveProduct(Connector connector)
        {
            Connectors.Remove(connector);
        }

        public void AddToOrder(StockItem item, Order order)
        {
            //Random rnd = new Random();
            //int orderID = rnd.Next(100000, 999999);
            //// Træk pris, temp variable
            //double ocost = 749;
            //DateTime date = DateTime.Now;
            //Order order = new Order(orderID, ocost, date);
            order.Items.Add(item);
        }


        public void ChangeOrder(Order order)
        {

        }
    }
}
