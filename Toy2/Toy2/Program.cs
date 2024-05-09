using System.Xml.XPath;

namespace Toy2
{
    public class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int orderID = rnd.Next(100000, 999999);
            DateTime date = DateTime.Now;
            Order order = new Order(orderID, date);

            Console.WriteLine("Hello,Toy2!");
            Controller controller = new Controller();
            DataHandler handler = new DataHandler("text.csv");
            Connector connector = new Connector(123, "Anchor", 55.0, 700);
            Connector connectorBasis = new Connector(124, "Basis", 45.0, 800);
            controller.AddNewProduct(connector);
            controller.AddNewProduct(connectorBasis);
            Console.WriteLine(controller.Connectors[0].Name);
            handler.PrintOrders(controller.Connectors);
            handler.ReadOrders();
            controller.AddToOrder(connector, order);
            controller.AddToOrder(connectorBasis, order);
            order.UpdateCost();
            Console.WriteLine(order.Cost);
            Console.WriteLine(order.Items.Count);







            //Random rnd = new Random();
            //int orderID = rnd.Next(100000, 999999);
            //// Træk pris, temp variable
            //double ocost = 749;
            //DateTime date = DateTime.Now;
            //Order order = new Order(orderID, ocost, date);
            //bool orderDone = false;
            //do
            //{
            //    // ID
            //    int ID = rnd.Next(100000, 999999);
            //    // Navn
            //    Console.WriteLine("Indtast produktnavn: ");
            //    string name = Console.ReadLine();
            //    // Pris
            //    //Træk pris, temp variabel:
            //    double cost = 599;
            //    // Amount
            //    Console.WriteLine("Indtast ønskede antal: ");
            //    int amount = int.Parse(Console.ReadLine());
            //    Connector connector = new Connector(ID, name, cost, amount);
            //    // Tilføj til ordre
            //    order.Items.Add(connector);
            //    Console.WriteLine("Afslut ordre? y/n");
            //    string done = Console.ReadLine();
            //    if (done[0] == 'y')
            //    {
            //        orderDone = true;
            //    }

            //}
            //while (orderDone == false);


        }
    }
}
