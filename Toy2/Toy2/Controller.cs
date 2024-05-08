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
        public List<Connector> Connectors = new List<Connector>();
        public Controller() 
        { 
            
        }

        public void AddNewProduct(string productName, int ID, double cost, int amount) 
        {
            Connector connector = new Connector(ID, productName, cost, amount);
           // connectorRepo.AddConnector(connector);
           Connectors.Add(connector);   
        }

        public void RemoveProduct(string productName)
        {
            //Connector connector = new Connector(ID, productName, cost);
            //Connectors.Remove(connector);
        }

        public void RegisterOrder()
        {
            Random rnd = new Random();
            int orderID = rnd.Next(100000, 999999);
            // Træk pris, temp variable
            double ocost = 749;
            DateTime date = DateTime.Now;
            Order order = new Order(orderID, ocost, date);
            bool orderDone = false; 
            do
            {
                // ID
                int ID = rnd.Next(100000, 999999);
                // Navn
                Console.WriteLine("Indtast produktnavn: ");
                string name = Console.ReadLine();
                // Pris
                //Træk pris, temp variabel:
                double cost = 599;
                // Amount
                Console.WriteLine("Indtast ønskede antal: ");
                int amount = int.Parse(Console.ReadLine());
                Connector connector = new Connector(ID, name, cost, amount);
                // Tilføj til ordre
                order.Items.Add(connector);
                Console.WriteLine("Afslut ordre? y/n");
                string done = Console.ReadLine();
                if (done[0] == 'y')
                {
                    orderDone = true;
                }
 
            }
            while (orderDone == false);
        }

        //public void AddItem(StockItem item, List<>)
        //{

        //}

        public void ChangeOrder(Order order)
        {

        }
    }
}
