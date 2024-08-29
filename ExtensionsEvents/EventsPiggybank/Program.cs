using System.Security.Cryptography.X509Certificates;

namespace EventsPiggybank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Piggybank piggybank = new Piggybank();
            Customer customer = new Customer();

            customer.Subscribe(piggybank);


            while (true)
            {
                Console.Clear();
                Console.WriteLine("Insæt værdi: " + piggybank.Amount);

                double input = double.Parse(Console.ReadLine());
                if (input == 0) break;
                piggybank.InsertAmount(input);
            }
        }
    }
}
