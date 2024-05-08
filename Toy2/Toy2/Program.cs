namespace Toy2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello,Toy2!");
            Controller controller = new Controller();
            DataHandler handler = new DataHandler("text.txt");
            controller.AddNewProduct("Anchor", 123, 55.0, 700);
            Console.WriteLine(controller.Connectors[0].Name);
            handler.PrintOrders();

        }
    }
}
